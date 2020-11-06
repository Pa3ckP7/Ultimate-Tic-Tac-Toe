using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;

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
            switch (button.TabIndex) 
            {
                case 0:
                    NextMove("tl");
                    break;
                case 1:
                    NextMove("tm");
                    break;
                case 2:
                    NextMove("tr");
                    break;
                case 3:
                    NextMove("ml");
                    break;
                case 4:
                    NextMove("mm");
                    break;
                case 5:
                    NextMove("mr");
                    break;
                case 6:
                    NextMove("bl");
                    break;
                case 7:
                    NextMove("bm");
                    break;
                case 8:
                    NextMove("bl");
                    break;
            }
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
            if (LBoard1.BackColor == LBoard2.BackColor && LBoard2.BackColor == LBoard3.BackColor && (LBoard1.BackColor != SystemColors.Control && LBoard1.BackColor != Color.Gray))
            {
                if (LBoard1.BackColor == Color.Aqua) FinalWinner = "x";
                else FinalWinner = "o";
                EndGame();
            }
            if (LBoard4.BackColor == LBoard5.BackColor && LBoard5.BackColor == LBoard6.BackColor && (LBoard4.BackColor != SystemColors.Control && LBoard4.BackColor != Color.Gray))
            {
                if (LBoard1.BackColor == Color.Aqua) FinalWinner = "x";
                else FinalWinner = "o";
                EndGame();
            }
            if (LBoard7.BackColor == LBoard8.BackColor && LBoard8.BackColor == LBoard9.BackColor && (LBoard7.BackColor != SystemColors.Control && LBoard7.BackColor != Color.Gray))
            {
                if (LBoard1.BackColor == Color.Aqua) FinalWinner = "x";
                else FinalWinner = "o";
                EndGame();
            }
            if (LBoard1.BackColor == LBoard4.BackColor && LBoard4.BackColor == LBoard7.BackColor && (LBoard1.BackColor != SystemColors.Control && LBoard1.BackColor != Color.Gray))
            {
                if (LBoard1.BackColor == Color.Aqua) FinalWinner = "x";
                else FinalWinner = "o";
                EndGame();
            }
            if (LBoard2.BackColor == LBoard5.BackColor && LBoard5.BackColor == LBoard8.BackColor && (LBoard2.BackColor != SystemColors.Control && LBoard2.BackColor != Color.Gray))
            {
                if (LBoard1.BackColor == Color.Aqua) FinalWinner = "x";
                else FinalWinner = "o";
                EndGame();
            }
            if (LBoard3.BackColor == LBoard6.BackColor && LBoard6.BackColor == LBoard9.BackColor && (LBoard3.BackColor != SystemColors.Control && LBoard3.BackColor != Color.Gray))
            {
                if (LBoard1.BackColor == Color.Aqua) FinalWinner = "x";
                else FinalWinner = "o";
                EndGame();
            }
            if (LBoard1.BackColor == LBoard5.BackColor && LBoard5.BackColor == LBoard9.BackColor && (LBoard1.BackColor != SystemColors.Control && LBoard1.BackColor != Color.Gray))
            {
                if (LBoard1.BackColor == Color.Aqua) FinalWinner = "x";
                else FinalWinner = "o";
                EndGame();
            }
            if (LBoard3.BackColor == LBoard5.BackColor && LBoard5.BackColor == LBoard7.BackColor && (LBoard3.BackColor != SystemColors.Control && LBoard3.BackColor != Color.Gray))
            {
                if (LBoard1.BackColor == Color.Aqua) FinalWinner = "x";
                else FinalWinner = "o";
                EndGame();
            }
        }
        private void EndGame() 
        {
            MessageBox.Show($"The Winner is {FinalWinner}!", "Winner", MessageBoxButtons.OK);
            Close();
        }
        private void NextMove(string location) 
        {
            switch (location) 
            {
                case "tl":
                    if (!LBoard1.BoardWon)
                    {
                        LBoard1.Enable();
                        LBoard2.Disable();
                        LBoard3.Disable();
                        LBoard4.Disable();
                        LBoard5.Disable();
                        LBoard6.Disable();
                        LBoard7.Disable();
                        LBoard8.Disable();
                        LBoard9.Disable();
                    }
                    else 
                    {
                        LBoard2.Enable();
                        LBoard3.Enable();
                        LBoard4.Enable();
                        LBoard5.Enable();
                        LBoard6.Enable();
                        LBoard7.Enable();
                        LBoard8.Enable();
                        LBoard9.Enable();
                    }
                    break;
                case "tm":
                    if (!LBoard2.BoardWon)
                    {
                        LBoard2.Enable();
                        LBoard1.Disable();
                        LBoard3.Disable();
                        LBoard4.Disable();
                        LBoard5.Disable();
                        LBoard6.Disable();
                        LBoard7.Disable();
                        LBoard8.Disable();
                        LBoard9.Disable();
                    }
                    else
                    {
                        LBoard1.Enable();
                        LBoard3.Enable();
                        LBoard4.Enable();
                        LBoard5.Enable();
                        LBoard6.Enable();
                        LBoard7.Enable();
                        LBoard8.Enable();
                        LBoard9.Enable();
                    }
                    break;
                case "tr":
                    if (!LBoard3.BoardWon)
                    {
                        LBoard3.Enable();
                        LBoard2.Disable();
                        LBoard1.Disable();
                        LBoard4.Disable();
                        LBoard5.Disable();
                        LBoard6.Disable();
                        LBoard7.Disable();
                        LBoard8.Disable();
                        LBoard9.Disable();
                    }
                    else
                    {
                        LBoard2.Enable();
                        LBoard1.Enable();
                        LBoard4.Enable();
                        LBoard5.Enable();
                        LBoard6.Enable();
                        LBoard7.Enable();
                        LBoard8.Enable();
                        LBoard9.Enable();
                    }
                    break;
                case "ml":
                    if (!LBoard4.BoardWon)
                    {
                        LBoard4.Enable();
                        LBoard2.Disable();
                        LBoard3.Disable();
                        LBoard1.Disable();
                        LBoard5.Disable();
                        LBoard6.Disable();
                        LBoard7.Disable();
                        LBoard8.Disable();
                        LBoard9.Disable();
                    }
                    else
                    {
                        LBoard2.Enable();
                        LBoard3.Enable();
                        LBoard1.Enable();
                        LBoard5.Enable();
                        LBoard6.Enable();
                        LBoard7.Enable();
                        LBoard8.Enable();
                        LBoard9.Enable();
                    }
                    break;
                case "mm":
                    if (!LBoard5.BoardWon)
                    {
                        LBoard5.Enable();
                        LBoard2.Disable();
                        LBoard3.Disable();
                        LBoard4.Disable();
                        LBoard1.Disable();
                        LBoard6.Disable();
                        LBoard7.Disable();
                        LBoard8.Disable();
                        LBoard9.Disable();
                    }
                    else
                    {
                        LBoard2.Enable();
                        LBoard3.Enable();
                        LBoard4.Enable();
                        LBoard1.Enable();
                        LBoard6.Enable();
                        LBoard7.Enable();
                        LBoard8.Enable();
                        LBoard9.Enable();
                    }
                    break;
                case "mr":
                    if (!LBoard6.BoardWon)
                    {
                        LBoard6.Enable();
                        LBoard2.Disable();
                        LBoard3.Disable();
                        LBoard4.Disable();
                        LBoard5.Disable();
                        LBoard1.Disable();
                        LBoard7.Disable();
                        LBoard8.Disable();
                        LBoard9.Disable();
                    }
                    else
                    {
                        LBoard2.Enable();
                        LBoard3.Enable();
                        LBoard4.Enable();
                        LBoard5.Enable();
                        LBoard1.Enable();
                        LBoard7.Enable();
                        LBoard8.Enable();
                        LBoard9.Enable();
                    }
                    break;
                case "bl":
                    if (!LBoard7.BoardWon)
                    {
                        LBoard7.Enable();
                        LBoard2.Disable();
                        LBoard3.Disable();
                        LBoard4.Disable();
                        LBoard5.Disable();
                        LBoard6.Disable();
                        LBoard1.Disable();
                        LBoard8.Disable();
                        LBoard9.Disable();
                    }
                    else
                    {
                        LBoard2.Enable();
                        LBoard3.Enable();
                        LBoard4.Enable();
                        LBoard5.Enable();
                        LBoard6.Enable();
                        LBoard1.Enable();
                        LBoard8.Enable();
                        LBoard9.Enable();
                    }
                    break;
                case "bm":
                    if (!LBoard8.BoardWon)
                    {
                        LBoard8.Enable();
                        LBoard2.Disable();
                        LBoard3.Disable();
                        LBoard4.Disable();
                        LBoard5.Disable();
                        LBoard6.Disable();
                        LBoard7.Disable();
                        LBoard1.Disable();
                        LBoard9.Disable();
                    }
                    else
                    {
                        LBoard2.Enable();
                        LBoard3.Enable();
                        LBoard4.Enable();
                        LBoard5.Enable();
                        LBoard6.Enable();
                        LBoard7.Enable();
                        LBoard1.Enable();
                        LBoard9.Enable();
                    }
                    break;
                case "br":
                    if (!LBoard9.BoardWon)
                    {
                        LBoard9.Enable();
                        LBoard2.Disable();
                        LBoard3.Disable();
                        LBoard4.Disable();
                        LBoard5.Disable();
                        LBoard6.Disable();
                        LBoard7.Disable();
                        LBoard8.Disable();
                        LBoard1.Disable();
                    }
                    else
                    {
                        LBoard2.Enable();
                        LBoard3.Enable();
                        LBoard4.Enable();
                        LBoard5.Enable();
                        LBoard6.Enable();
                        LBoard7.Enable();
                        LBoard8.Enable();
                        LBoard1.Enable();
                    }
                    break;
            }
        }
    }
}
