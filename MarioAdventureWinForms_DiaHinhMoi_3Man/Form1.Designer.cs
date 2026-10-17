namespace MarioAdventureWinForms
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            label1 = new Label();
            txtPlayerName = new TextBox();
            btnStart = new Button();
            btnScores = new Button();
            btnHelp = new Button();
            btnSound = new Button();
            btnExit = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.None;
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.BorderStyle = BorderStyle.Fixed3D;
            label1.Font = new Font("Segoe Print", 20F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Gold;
            label1.Location = new Point(134, 88);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(476, 49);
            label1.TabIndex = 0;
            label1.Text = "SUPER PLATFORM ADVENTURE";
            label1.Click += label1_Click;
            // 
            // txtPlayerName
            // 
            txtPlayerName.Anchor = AnchorStyles.None;
            txtPlayerName.Location = new Point(260, 152);
            txtPlayerName.Margin = new Padding(2);
            txtPlayerName.Name = "txtPlayerName";
            txtPlayerName.Size = new Size(208, 23);
            txtPlayerName.TabIndex = 1;
            txtPlayerName.Text = "Player";
            txtPlayerName.TextAlign = HorizontalAlignment.Center;
            txtPlayerName.TextChanged += txtPlayerName_TextChanged;
            // 
            // btnStart
            // 
            btnStart.Anchor = AnchorStyles.None;
            btnStart.BackColor = Color.Gold;
            btnStart.FlatStyle = FlatStyle.Flat;
            btnStart.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnStart.ForeColor = Color.Black;
            btnStart.Location = new Point(260, 181);
            btnStart.Margin = new Padding(2);
            btnStart.Name = "btnStart";
            btnStart.Size = new Size(206, 38);
            btnStart.TabIndex = 2;
            btnStart.Text = "BẮT ĐẦU CHƠI";
            btnStart.UseVisualStyleBackColor = false;
            btnStart.Click += btnStart_Click;
            // 
            // btnScores
            // 
            btnScores.Anchor = AnchorStyles.None;
            btnScores.BackColor = Color.Gold;
            btnScores.FlatStyle = FlatStyle.Flat;
            btnScores.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnScores.ForeColor = Color.Black;
            btnScores.Location = new Point(260, 223);
            btnScores.Margin = new Padding(2);
            btnScores.Name = "btnScores";
            btnScores.Size = new Size(206, 39);
            btnScores.TabIndex = 3;
            btnScores.Text = "BẢNG THÀNH TÍCH";
            btnScores.UseVisualStyleBackColor = false;
            btnScores.Click += btnScores_Click;
            // 
            // btnHelp
            // 
            btnHelp.Anchor = AnchorStyles.None;
            btnHelp.BackColor = Color.Gold;
            btnHelp.FlatStyle = FlatStyle.Flat;
            btnHelp.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnHelp.ForeColor = Color.Black;
            btnHelp.Location = new Point(260, 266);
            btnHelp.Margin = new Padding(2);
            btnHelp.Name = "btnHelp";
            btnHelp.Size = new Size(206, 32);
            btnHelp.TabIndex = 4;
            btnHelp.Text = "HƯỚNG DẪN";
            btnHelp.UseVisualStyleBackColor = false;
            btnHelp.Click += btnHelp_Click;
            // 
            // btnSound
            // 
            btnSound.Anchor = AnchorStyles.None;
            btnSound.BackColor = Color.Gold;
            btnSound.FlatStyle = FlatStyle.Flat;
            btnSound.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSound.ForeColor = Color.Black;
            btnSound.Location = new Point(260, 302);
            btnSound.Margin = new Padding(2);
            btnSound.Name = "btnSound";
            btnSound.Size = new Size(206, 32);
            btnSound.TabIndex = 5;
            btnSound.Text = "ÂM THANH : BẬT";
            btnSound.UseVisualStyleBackColor = false;
            btnSound.Click += btnSound_Click;
            // 
            // btnExit
            // 
            btnExit.Anchor = AnchorStyles.None;
            btnExit.BackColor = Color.Gold;
            btnExit.FlatStyle = FlatStyle.Flat;
            btnExit.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnExit.ForeColor = Color.Black;
            btnExit.Location = new Point(260, 338);
            btnExit.Margin = new Padding(2);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(206, 30);
            btnExit.TabIndex = 6;
            btnExit.Text = "THOÁT";
            btnExit.UseVisualStyleBackColor = false;
            btnExit.Click += btnExit_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.HighlightText;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(720, 415);
            Controls.Add(btnExit);
            Controls.Add(btnSound);
            Controls.Add(btnHelp);
            Controls.Add(btnScores);
            Controls.Add(btnStart);
            Controls.Add(txtPlayerName);
            Controls.Add(label1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(2);
            Name = "Form1";
            Text = "SUPER PLATFORM ADVENTURE";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtPlayerName;
        private Button btnStart;
        private Button btnScores;
        private Button btnHelp;
        private Button btnSound;
        private Button btnExit;
    }
}