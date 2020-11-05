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
        String FinalWinner;
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
            CheckWin();
        }
        private void CheckWin()
        {// WHY just WHY again?
            if (LBoard1.BackColor == LBoard2.BackColor && LBoard2.BackColor == LBoard3.BackColor && LBoard1.BackColor != SystemColors.Control)
            {
                if (LBoard1.BackColor == Color.Aqua) FinalWinner = "x";
                else FinalWinner = "o";
                EndGame();
            }
            if (LBoard4.BackColor == LBoard5.BackColor && LBoard5.BackColor == LBoard6.BackColor && LBoard4.BackColor != SystemColors.Control)
            {
                if (LBoard1.BackColor == Color.Aqua) FinalWinner = "x";
                else FinalWinner = "o";
                EndGame();
            }
            if (LBoard7.BackColor == LBoard8.BackColor && LBoard8.BackColor == LBoard9.BackColor && LBoard7.BackColor != SystemColors.Control)
            {
                if (LBoard1.BackColor == Color.Aqua) FinalWinner = "x";
                else FinalWinner = "o";
                EndGame();
            }
            if (LBoard1.BackColor == LBoard4.BackColor && LBoard4.BackColor == LBoard7.BackColor && LBoard1.BackColor != SystemColors.Control)
            {
                if (LBoard1.BackColor == Color.Aqua) FinalWinner = "x";
                else FinalWinner = "o";
                EndGame();
            }
            if (LBoard2.BackColor == LBoard5.BackColor && LBoard5.BackColor == LBoard8.BackColor && LBoard2.BackColor != SystemColors.Control)
            {
                if (LBoard1.BackColor == Color.Aqua) FinalWinner = "x";
                else FinalWinner = "o";
                EndGame();
            }
            if (LBoard3.BackColor == LBoard6.BackColor && LBoard6.BackColor == LBoard9.BackColor && LBoard3.BackColor != SystemColors.Control)
            {
                if (LBoard1.BackColor == Color.Aqua) FinalWinner = "x";
                else FinalWinner = "o";
                EndGame();
            }
            if (LBoard1.BackColor == LBoard5.BackColor && LBoard5.BackColor == LBoard9.BackColor && LBoard1.BackColor != SystemColors.Control)
            {
                if (LBoard1.BackColor == Color.Aqua) FinalWinner = "x";
                else FinalWinner = "o";
                EndGame();
            }
            if (LBoard3.BackColor == LBoard5.BackColor && LBoard5.BackColor == LBoard7.BackColor && LBoard3.BackColor != SystemColors.Control)
            {
                if (LBoard1.BackColor == Color.Aqua) FinalWinner = "x";
                else FinalWinner = "o";
                EndGame();
            }
        }
        private void EndGame() 
        {
            MessageBox.Show($"The Winner is {FinalWinner}!", "Winner", MessageBoxButtons.OK);
        }
    }
}
