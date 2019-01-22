using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GoLWF
{
    public partial class Form1 : Form
    {
        private Player player = new Player();

        public Form1()
        {
            InitializeComponent();
            timerInfo.Enabled = true;
        }

        private void pictureBox1_Paint(object sender, PaintEventArgs e)
        {
            player.Show(e.Graphics);
        }

        private void buttonStart_Click(object sender, EventArgs e)
        {
            timerPlayer.Enabled = true;
        }

        private void buttonStep_Click(object sender, EventArgs e)
        {
            timerPlayer.Enabled = false;
            player.Move();
            pictureBox1.Refresh();
        }

        private void buttonStop_Click(object sender, EventArgs e)
        {
            timerPlayer.Enabled = false;
        }

        private void trackBarSpeed_Scroll(object sender, EventArgs e)
        {
            timerPlayer.Interval = player.GetPlayerSpeed(Decimal.ToInt16(trackBarSpeed.Value));
        }

        private void buttonChaos_Click(object sender, EventArgs e)
        {
            player.Genesis(Universe.TypeOfGenesis.Chaos, Decimal.ToInt16(trackBarChaos.Value));
            pictureBox1.Refresh();
        }

        private void timerPlayer_Tick(object sender, EventArgs e)
        {
            player.Move();
            pictureBox1.Refresh();
        }

        private void timerInfo_Tick(object sender, EventArgs e)
        {
            labelAge.Text = "Age : " + Convert.ToString(player.GetNumberOfMoves());
            labelPopulation.Text = "Cells: " + Convert.ToString(player.GetNumberOfPopulation());
            labelVary.Text = "Vary: " + Convert.ToString(player.GetNumberOfVary());
        }
    }
}
