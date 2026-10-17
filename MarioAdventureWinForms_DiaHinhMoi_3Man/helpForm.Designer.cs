namespace MarioAdventureWinForms
{
    partial class HelpForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HelpForm));
            IBTitle = new Label();
            grpTeam = new GroupBox();
            rtbTeam = new RichTextBox();
            grpGuide = new GroupBox();
            rtbGuide = new RichTextBox();
            btnClose = new Button();
            grpTeam.SuspendLayout();
            grpGuide.SuspendLayout();
            SuspendLayout();
            // 
            // IBTitle
            // 
            IBTitle.AutoSize = true;
            IBTitle.BackColor = Color.Transparent;
            IBTitle.Font = new Font("Segoe UI", 20F, FontStyle.Bold, GraphicsUnit.Point, 0);
            IBTitle.ForeColor = Color.Gold;
            IBTitle.Location = new Point(183, 16);
            IBTitle.Margin = new Padding(2, 0, 2, 0);
            IBTitle.Name = "IBTitle";
            IBTitle.Size = new Size(187, 37);
            IBTitle.TabIndex = 0;
            IBTitle.Text = "HƯỚNG DẪN";
            // 
            // grpTeam
            // 
            grpTeam.BackColor = Color.Transparent;
            grpTeam.Controls.Add(rtbTeam);
            grpTeam.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            grpTeam.ForeColor = Color.Gold;
            grpTeam.Location = new Point(294, 72);
            grpTeam.Margin = new Padding(2);
            grpTeam.Name = "grpTeam";
            grpTeam.Padding = new Padding(2);
            grpTeam.Size = new Size(252, 150);
            grpTeam.TabIndex = 1;
            grpTeam.TabStop = false;
            grpTeam.Text = "THÔNG TIN NHÓM";
            // 
            // rtbTeam
            // 
            rtbTeam.BackColor = SystemColors.MenuHighlight;
            rtbTeam.BorderStyle = BorderStyle.None;
            rtbTeam.Dock = DockStyle.Fill;
            rtbTeam.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            rtbTeam.ForeColor = Color.White;
            rtbTeam.Location = new Point(2, 24);
            rtbTeam.Margin = new Padding(2);
            rtbTeam.Name = "rtbTeam";
            rtbTeam.ReadOnly = true;
            rtbTeam.Size = new Size(248, 124);
            rtbTeam.TabIndex = 3;
            rtbTeam.Text = "Nhóm: NoB \nThành Viên:\n1.Hoàng Đình Trọng/MSSV:51.01.104.108\n2.Trần Anh Minh/MSSV:50.01.103.042\n3:Nguyễn Hữu Hoàng Nam/MSSV:45.01.104.146\n";
            rtbTeam.TextChanged += rtbTeam_TextChanged;
            // 
            // grpGuide
            // 
            grpGuide.BackColor = Color.Transparent;
            grpGuide.Controls.Add(rtbGuide);
            grpGuide.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            grpGuide.ForeColor = Color.Gold;
            grpGuide.Location = new Point(14, 72);
            grpGuide.Margin = new Padding(2);
            grpGuide.Name = "grpGuide";
            grpGuide.Padding = new Padding(2);
            grpGuide.Size = new Size(266, 150);
            grpGuide.TabIndex = 0;
            grpGuide.TabStop = false;
            grpGuide.Text = "HƯỚNG DẪN CHƠI";
            grpGuide.Enter += grpGuide_Enter;
            // 
            // rtbGuide
            // 
            rtbGuide.BackColor = SystemColors.MenuHighlight;
            rtbGuide.BorderStyle = BorderStyle.None;
            rtbGuide.Dock = DockStyle.Fill;
            rtbGuide.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            rtbGuide.ForeColor = Color.White;
            rtbGuide.Location = new Point(2, 24);
            rtbGuide.Margin = new Padding(2);
            rtbGuide.Name = "rtbGuide";
            rtbGuide.ReadOnly = true;
            rtbGuide.Size = new Size(262, 124);
            rtbGuide.TabIndex = 2;
            rtbGuide.Text = resources.GetString("rtbGuide.Text");
            // 
            // btnClose
            // 
            btnClose.BackColor = Color.Gold;
            btnClose.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnClose.ForeColor = Color.Black;
            btnClose.Location = new Point(231, 234);
            btnClose.Margin = new Padding(2);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(98, 25);
            btnClose.TabIndex = 3;
            btnClose.Text = "ĐÓNG";
            btnClose.UseVisualStyleBackColor = false;
            btnClose.Click += btnClose_Click;
            // 
            // HelpForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.MidnightBlue;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(560, 270);
            Controls.Add(btnClose);
            Controls.Add(grpGuide);
            Controls.Add(grpTeam);
            Controls.Add(IBTitle);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(2);
            Name = "HelpForm";
            StartPosition = FormStartPosition.CenterParent;
            Text = "HƯỚNG DẪN";
            grpTeam.ResumeLayout(false);
            grpGuide.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label IBTitle;
        private GroupBox grpTeam;
        private GroupBox grpGuide;
        private RichTextBox rtbGuide;
        private RichTextBox rtbTeam;
        private Button btnClose;
    }
}