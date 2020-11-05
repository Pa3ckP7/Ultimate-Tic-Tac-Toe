using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ultimate_Tic_Tac_Toe
{
    public partial class UTTTForm : Form
    {
        public UTTTForm()
        {
            InitializeComponent();
            PlayerDisplayLabel.Text = "x";
        }
        private void LBoard_Slotclicked(object sender, EventArgs e)
        {
            var button = sender as Button;
            button.Text = PlayerDisplayLabel.Text;
            if (PlayerDisplayLabel.Text == "x") PlayerDisplayLabel.Text = "o";
              else PlayerDisplayLabel.Text = "x";
        }
        private void LBoard_Won(object sender, EventArgs e) 
        {
            var lboard = sender as LocalGrid;
            if (lboard.Winner == "x") lboard.BackColor = Color.Aqua;
            else lboard.BackColor = Color.IndianRed;
        }
    }
}
