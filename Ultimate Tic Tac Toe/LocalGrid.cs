using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ultimate_Tic_Tac_Toe
{
    public partial class LocalGrid : UserControl
    {
        public LocalGrid()
        {
            InitializeComponent();
        }
        public bool BoardWon { get; internal set; } = false;
        public string Winner { get; set; }
        #region Events
        public event EventHandler Slotclicked;
        protected virtual void OnSlotclicked(object sender,EventArgs e) 
        {
            Slotclicked?.Invoke(sender, e);
            CheckWin();
        }
        public event EventHandler GridWon;
        protected virtual void OnGridWon(EventArgs e) 
        {
            button1.Enabled = false;
            button2.Enabled = false;
            button3.Enabled = false;
            button4.Enabled = false;
            button5.Enabled = false;
            button6.Enabled = false;
            button7.Enabled = false;
            button8.Enabled = false;
            button9.Enabled = false;
            GridWon?.Invoke(this, e);
            BoardWon = true;
        }
        #endregion
        #region ClickEvents
        private void button6_Click(object sender, EventArgs e)
        {
            if (!(sender as Button).Enabled) return;
            OnSlotclicked(sender, e);
            (sender as Button).Enabled = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (!(sender as Button).Enabled) return;
            OnSlotclicked(sender, e);
            (sender as Button).Enabled = false;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (!(sender as Button).Enabled) return;
            OnSlotclicked(sender, e);
            (sender as Button).Enabled = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!(sender as Button).Enabled) return;
            OnSlotclicked(sender, e);
            (sender as Button).Enabled = false;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (!(sender as Button).Enabled) return;
            OnSlotclicked(sender, e);
            (sender as Button).Enabled = false;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (!(sender as Button).Enabled) return;
            OnSlotclicked(sender, e);
            (sender as Button).Enabled = false;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (!(sender as Button).Enabled) return;
            OnSlotclicked(sender, e);
            (sender as Button).Enabled = false;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (!(sender as Button).Enabled) return;
            OnSlotclicked(sender, e);
            (sender as Button).Enabled = false;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (!(sender as Button).Enabled) return;
            OnSlotclicked(sender, e);
            (sender as Button).Enabled = false;
        }
        #endregion
        private void CheckWin()
        {// WHY just WHY?
            if (button1.Text == button2.Text && button2.Text == button3.Text && button1.Text!="")
            {
                Winner = button1.Text;
                OnGridWon(EventArgs.Empty);                
            }
            if (button4.Text == button5.Text && button5.Text == button6.Text && button4.Text!="")
            {
                Winner = button4.Text;
                OnGridWon(EventArgs.Empty);
            }
            if (button7.Text == button8.Text && button8.Text == button9.Text && button7.Text!="") 
            {
                Winner = button7.Text;
                OnGridWon(EventArgs.Empty);
            }
            if (button1.Text == button4.Text && button4.Text == button7.Text && button1.Text!="") 
            {
                Winner = button1.Text;
                OnGridWon(EventArgs.Empty);
            }
            if (button2.Text == button5.Text && button5.Text == button8.Text && button2.Text!="") 
            {
                Winner = button2.Text;
                OnGridWon(EventArgs.Empty);
            }
            if (button3.Text == button6.Text && button6.Text == button9.Text && button3.Text!="") 
            {
                Winner = button3.Text;
                OnGridWon(EventArgs.Empty);
            }
            if (button1.Text == button5.Text && button5.Text == button9.Text && button1.Text!="") 
            {
                Winner = button1.Text;
                OnGridWon(EventArgs.Empty);
            }
            if (button3.Text == button5.Text && button5.Text == button7.Text && button3.Text!="") 
            {
                Winner = button3.Text;
                OnGridWon(EventArgs.Empty);
            }
        }
        public void Disable() 
        {
            button1.Enabled = false;
            button2.Enabled = false;
            button3.Enabled = false;
            button4.Enabled = false;
            button5.Enabled = false;
            button6.Enabled = false;
            button7.Enabled = false;
            button8.Enabled = false;
            button9.Enabled = false;
            if (BackColor != Color.IndianRed && BackColor != Color.Aqua) BackColor = Color.Gray;
        }
        public void Enable()
        {
            button1.Enabled = true;
            button2.Enabled = true;
            button3.Enabled = true;
            button4.Enabled = true;
            button5.Enabled = true;
            button6.Enabled = true;
            button7.Enabled = true;
            button8.Enabled = true;
            button9.Enabled = true;
            if (BackColor!= Color.IndianRed && BackColor!= Color.Aqua && BoardWon==false) BackColor = SystemColors.Control;
        }
    }
}
