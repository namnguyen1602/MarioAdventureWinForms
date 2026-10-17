using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace MarioAdventureWinForms
{
    public partial class ScoresForm : Form
    {
        public ScoresForm()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void ScoresForm_Load(object sender, EventArgs e)
        {
            try
            {
                dgvScores.DataSource = MarioAdventure.ScoreStore.Read();
                dgvScores.Columns["Name"].HeaderText = "Tên người chơi";
                dgvScores.Columns["Score"].HeaderText = "Điểm";
                dgvScores.Columns["Level"].HeaderText = "Màn";
                dgvScores.Columns["PlayedAt"].HeaderText = "Ngày chơi";
                dgvScores.Columns["PlayedAt"].DefaultCellStyle.Format = "dd/MM/yyyy HH:mm:ss";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Không đọc được thành tích: " + ex.Message);
            }
        }
    }
}