using System.Text;

namespace GCScript_Text_File_Joiner
{
    public partial class frm_Main : Form
    {
        public frm_Main()
        {
            InitializeComponent();
        }

        private void btn_Add_Click(object sender, EventArgs e)
        {
            var ofd = new OpenFileDialog()
            {
                Filter = "Text Files (*.txt)|*.txt",
                Multiselect = true,
                Title = "Select Text Files to Join"
            };

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                foreach (string file in ofd.FileNames)
                {
                    if (!File.Exists(file) || Path.GetExtension(file) != ".txt" || lst_Main.Items.Contains(file))
                    {
                        continue;
                    }

                    lst_Main.Items.Add(file);
                }
                lbl_Count.Text = lst_Main.Items.Count.ToString();
            }
        }

        private void btn_Remove_Click(object sender, EventArgs e)
        {
            if (lst_Main.SelectedIndex != -1)
            {
                int index = lst_Main.SelectedIndex;
                lst_Main.Items.RemoveAt(index);
                if (lst_Main.Items.Count > 0)
                {
                    lst_Main.SelectedIndex = index > 0 ? index - 1 : 0;
                }
                lbl_Count.Text = lst_Main.Items.Count.ToString();
            }
        }

        private void btn_Save_Click(object sender, EventArgs e)
        {
            try
            {
                if (lst_Main.Items.Count < 2)
                {
                    return;
                }

                List<string> fileContents = new();

                foreach (string file in lst_Main.Items)
                {
                    if (!File.Exists(file) || Path.GetExtension(file) != ".txt")
                    {
                        continue;
                    }

                    string content = File.ReadAllText(file, Encoding.UTF8);
                    if (string.IsNullOrWhiteSpace(content)) { continue; }
                    fileContents.Add(content.Trim());
                }
                string joinedContents = string.Join(Environment.NewLine, fileContents);

                SaveFileDialog sfd = new()
                {
                    Filter = "Text Files (*.txt)|*.txt",
                    Title = "Save Joined Text File",
                    FileName = $"_Joined_{DateTime.Now:yyyy-MM-dd_HH-mm}.txt"
                };

                if (sfd.ShowDialog() != DialogResult.OK)
                {
                    return;
                }

                File.WriteAllText(sfd.FileName, joinedContents, Encoding.UTF8);
                MessageBox.Show("File Saved Successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error Saving File: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}