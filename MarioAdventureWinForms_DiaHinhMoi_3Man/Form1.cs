using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace MarioAdventureWinForms
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void
            btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }
        private void
            txtPlayerName_TextChanged(object sender, EventArgs e)
        { }

        private void btnStart_Click(object sender, EventArgs e)
        {
            try
            {
                string name =
                    MarioAdventure.ScoreStore.CleanName(txtPlayerName.Text);

                Hide();

                DialogResult result;
                do
                {
                    using var game = new MarioAdventure.GameForm(name);
                    result = game.ShowDialog(this);
                }
                while (result == DialogResult.Retry);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Không mở được game: " + ex.Message);
            }
            finally
            {
                Show();
                MarioAdventure.Audio.StopMusic();
            }
        }

        private void btnScores_Click(object sender, EventArgs e)
        {
            using var scores = new ScoresForm();
            scores.ShowDialog(this);
        }

        private void btnSound_Click(object sender, EventArgs e)
        {
            MarioAdventure.Audio.Toggle(false);
            btnSound.Text = MarioAdventure.Audio.Enabled
                ? "ÂM THANH: BẬT"
                : "ÂM THANH: TẮT";
        }

        private void btnHelp_Click(object sender, EventArgs e)
        {
            using var help = new HelpForm();
            help.ShowDialog(this);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
