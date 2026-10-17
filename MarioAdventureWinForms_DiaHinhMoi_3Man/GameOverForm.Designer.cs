namespace MarioAdventureWinForms
{
    partial class GameOverForm 
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GameOverForm));
            lbTitle = new Label();
            lblScore = new Label();
            btnRetry = new Button();
            btnMenu = new Button();
            SuspendLayout();
            // 
            // lbTitle
            // 
            lbTitle.Font = new Font("Segoe UI", 32F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbTitle.ForeColor = Color.Gold;
            lbTitle.Location = new Point(70, 36);
            lbTitle.Margin = new Padding(2, 0, 2, 0);
            lbTitle.Name = "lbTitle";
            lbTitle.Size = new Size(420, 54);
            lbTitle.TabIndex = 0;
            lbTitle.Text = "GAME OVER";
            lbTitle.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblScore
            // 
            lblScore.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblScore.ForeColor = Color.White;
            lblScore.Location = new Point(70, 118);
            lblScore.Margin = new Padding(2, 0, 2, 0);
            lblScore.Name = "lblScore";
            lblScore.Size = new Size(420, 30);
            lblScore.TabIndex = 1;
            lblScore.Text = "Điểm của bạn : 0";
            lblScore.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btnRetry
            // 
            btnRetry.BackColor = Color.Gold;
            btnRetry.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnRetry.ForeColor = Color.Black;
            btnRetry.Location = new Point(126, 180);
            btnRetry.Margin = new Padding(2);
            btnRetry.Name = "btnRetry";
            btnRetry.Size = new Size(140, 33);
            btnRetry.TabIndex = 2;
            btnRetry.Text = "CHƠI LẠI";
            btnRetry.UseVisualStyleBackColor = false;
            btnRetry.Click += btnRetry_Click;
            // 
            // btnMenu
            // 
            btnMenu.BackColor = Color.Gold;
            btnMenu.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnMenu.ForeColor = Color.Black;
            btnMenu.Location = new Point(294, 180);
            btnMenu.Margin = new Padding(2);
            btnMenu.Name = "btnMenu";
            btnMenu.Size = new Size(140, 33);
            btnMenu.TabIndex = 3;
            btnMenu.Text = "VỀ MENU";
            btnMenu.UseVisualStyleBackColor = false;
            btnMenu.Click += btnMenu_Click;
            // 
            // GameOverForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.HotTrack;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(545, 236);
            Controls.Add(btnMenu);
            Controls.Add(btnRetry);
            Controls.Add(lblScore);
            Controls.Add(lbTitle);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(2);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "GameOverForm";
            StartPosition = FormStartPosition.CenterParent;
            Text = "GAME OVER";
            ResumeLayout(false);
        }

        #endregion

        private Label lbTitle;
        private Label lblScore;
        private Button btnRetry;
        private Button btnMenu;
    }
}