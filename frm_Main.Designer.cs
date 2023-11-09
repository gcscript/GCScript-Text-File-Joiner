namespace GCScript_Text_File_Joiner
{
    partial class frm_Main
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_Main));
            tblp_Main = new TableLayoutPanel();
            label1 = new Label();
            btn_Add = new Button();
            btn_Remove = new Button();
            btn_Save = new Button();
            pnl_Main = new Panel();
            lst_Main = new ListBox();
            tblp_Main.SuspendLayout();
            pnl_Main.SuspendLayout();
            SuspendLayout();
            // 
            // tblp_Main
            // 
            tblp_Main.ColumnCount = 2;
            tblp_Main.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tblp_Main.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tblp_Main.Controls.Add(label1, 0, 0);
            tblp_Main.Controls.Add(btn_Add, 0, 2);
            tblp_Main.Controls.Add(btn_Remove, 1, 2);
            tblp_Main.Controls.Add(btn_Save, 0, 3);
            tblp_Main.Controls.Add(pnl_Main, 0, 1);
            tblp_Main.Dock = DockStyle.Fill;
            tblp_Main.Location = new Point(0, 0);
            tblp_Main.Name = "tblp_Main";
            tblp_Main.RowCount = 4;
            tblp_Main.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tblp_Main.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tblp_Main.RowStyles.Add(new RowStyle(SizeType.Absolute, 34F));
            tblp_Main.RowStyles.Add(new RowStyle(SizeType.Absolute, 50F));
            tblp_Main.Size = new Size(484, 361);
            tblp_Main.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Dock = DockStyle.Fill;
            label1.Location = new Point(1, 1);
            label1.Margin = new Padding(1);
            label1.Name = "label1";
            label1.Size = new Size(240, 18);
            label1.TabIndex = 0;
            label1.Text = "Planilhas";
            label1.TextAlign = ContentAlignment.BottomLeft;
            // 
            // btn_Add
            // 
            btn_Add.BackColor = Color.FromArgb(50, 50, 50);
            btn_Add.Dock = DockStyle.Fill;
            btn_Add.FlatStyle = FlatStyle.Flat;
            btn_Add.Location = new Point(3, 280);
            btn_Add.Name = "btn_Add";
            btn_Add.Size = new Size(236, 28);
            btn_Add.TabIndex = 2;
            btn_Add.Text = "Adicionar";
            btn_Add.UseVisualStyleBackColor = false;
            btn_Add.Click += btn_Add_Click;
            // 
            // btn_Remove
            // 
            btn_Remove.BackColor = Color.FromArgb(50, 50, 50);
            btn_Remove.Dock = DockStyle.Fill;
            btn_Remove.FlatStyle = FlatStyle.Flat;
            btn_Remove.Location = new Point(245, 280);
            btn_Remove.Name = "btn_Remove";
            btn_Remove.Size = new Size(236, 28);
            btn_Remove.TabIndex = 3;
            btn_Remove.Text = "Remover";
            btn_Remove.UseVisualStyleBackColor = false;
            btn_Remove.Click += btn_Remove_Click;
            // 
            // btn_Save
            // 
            btn_Save.BackColor = Color.FromArgb(50, 50, 50);
            tblp_Main.SetColumnSpan(btn_Save, 2);
            btn_Save.Dock = DockStyle.Fill;
            btn_Save.FlatStyle = FlatStyle.Flat;
            btn_Save.Location = new Point(3, 314);
            btn_Save.Name = "btn_Save";
            btn_Save.Size = new Size(478, 44);
            btn_Save.TabIndex = 4;
            btn_Save.Text = "Salvar";
            btn_Save.UseVisualStyleBackColor = false;
            btn_Save.Click += btn_Save_Click;
            // 
            // pnl_Main
            // 
            pnl_Main.BackColor = Color.FromArgb(50, 50, 50);
            pnl_Main.BorderStyle = BorderStyle.FixedSingle;
            tblp_Main.SetColumnSpan(pnl_Main, 2);
            pnl_Main.Controls.Add(lst_Main);
            pnl_Main.Dock = DockStyle.Fill;
            pnl_Main.Location = new Point(3, 23);
            pnl_Main.Name = "pnl_Main";
            pnl_Main.Size = new Size(478, 251);
            pnl_Main.TabIndex = 5;
            // 
            // lst_Main
            // 
            lst_Main.BackColor = Color.FromArgb(50, 50, 50);
            lst_Main.BorderStyle = BorderStyle.None;
            lst_Main.Dock = DockStyle.Fill;
            lst_Main.ForeColor = Color.FromArgb(241, 241, 241);
            lst_Main.FormattingEnabled = true;
            lst_Main.ItemHeight = 14;
            lst_Main.Location = new Point(0, 0);
            lst_Main.Margin = new Padding(1);
            lst_Main.Name = "lst_Main";
            lst_Main.Size = new Size(476, 249);
            lst_Main.TabIndex = 0;
            // 
            // frm_Main
            // 
            AutoScaleDimensions = new SizeF(7F, 14F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(38, 38, 39);
            ClientSize = new Size(484, 361);
            Controls.Add(tblp_Main);
            Font = new Font("Consolas", 9F, FontStyle.Regular, GraphicsUnit.Point);
            ForeColor = Color.FromArgb(241, 241, 241);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MinimumSize = new Size(500, 400);
            Name = "frm_Main";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "GCScript Text File Joiner";
            tblp_Main.ResumeLayout(false);
            tblp_Main.PerformLayout();
            pnl_Main.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tblp_Main;
        private Label label1;
        private Button btn_Add;
        private Button btn_Remove;
        private Button btn_Save;
        private Panel pnl_Main;
        private ListBox lst_Main;
    }
}