namespace Ultimate_Tic_Tac_Toe
{
    partial class UTTTForm
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.PlayerDisplayLabel = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.LBoard1 = new Ultimate_Tic_Tac_Toe.LocalGrid();
            this.LBoard2 = new Ultimate_Tic_Tac_Toe.LocalGrid();
            this.LBoard3 = new Ultimate_Tic_Tac_Toe.LocalGrid();
            this.LBoard4 = new Ultimate_Tic_Tac_Toe.LocalGrid();
            this.LBoard5 = new Ultimate_Tic_Tac_Toe.LocalGrid();
            this.LBoard6 = new Ultimate_Tic_Tac_Toe.LocalGrid();
            this.LBoard7 = new Ultimate_Tic_Tac_Toe.LocalGrid();
            this.LBoard8 = new Ultimate_Tic_Tac_Toe.LocalGrid();
            this.LBoard9 = new Ultimate_Tic_Tac_Toe.LocalGrid();
            this.panel1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.PlayerDisplayLabel);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(484, 100);
            this.panel1.TabIndex = 0;
            // 
            // PlayerDisplayLabel
            // 
            this.PlayerDisplayLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.PlayerDisplayLabel.AutoSize = true;
            this.PlayerDisplayLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.PlayerDisplayLabel.Location = new System.Drawing.Point(199, 9);
            this.PlayerDisplayLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.PlayerDisplayLabel.Name = "PlayerDisplayLabel";
            this.PlayerDisplayLabel.Size = new System.Drawing.Size(50, 73);
            this.PlayerDisplayLabel.TabIndex = 0;
            this.PlayerDisplayLabel.Text = "/";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.Controls.Add(this.LBoard1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.LBoard2, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.LBoard3, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.LBoard4, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.LBoard5, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.LBoard6, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.LBoard7, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.LBoard8, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.LBoard9, 2, 2);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 100);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(484, 381);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // LBoard1
            // 
            this.LBoard1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.LBoard1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LBoard1.Location = new System.Drawing.Point(5, 6);
            this.LBoard1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.LBoard1.Name = "LBoard1";
            this.LBoard1.Size = new System.Drawing.Size(152, 115);
            this.LBoard1.TabIndex = 1;
            this.LBoard1.Winner = null;
            this.LBoard1.Slotclicked += new System.EventHandler(this.LBoard_Slotclicked);
            this.LBoard1.GridWon += new System.EventHandler(this.LBoard_Won);
            // 
            // LBoard2
            // 
            this.LBoard2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.LBoard2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LBoard2.Location = new System.Drawing.Point(166, 6);
            this.LBoard2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.LBoard2.Name = "LBoard2";
            this.LBoard2.Size = new System.Drawing.Size(152, 115);
            this.LBoard2.TabIndex = 2;
            this.LBoard2.Winner = null;
            this.LBoard2.Slotclicked += new System.EventHandler(this.LBoard_Slotclicked);
            this.LBoard2.GridWon += new System.EventHandler(this.LBoard_Won);
            // 
            // LBoard3
            // 
            this.LBoard3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.LBoard3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LBoard3.Location = new System.Drawing.Point(327, 6);
            this.LBoard3.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.LBoard3.Name = "LBoard3";
            this.LBoard3.Size = new System.Drawing.Size(152, 115);
            this.LBoard3.TabIndex = 3;
            this.LBoard3.Winner = null;
            this.LBoard3.Slotclicked += new System.EventHandler(this.LBoard_Slotclicked);
            this.LBoard3.GridWon += new System.EventHandler(this.LBoard_Won);
            // 
            // LBoard4
            // 
            this.LBoard4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.LBoard4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LBoard4.Location = new System.Drawing.Point(5, 132);
            this.LBoard4.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.LBoard4.Name = "LBoard4";
            this.LBoard4.Size = new System.Drawing.Size(152, 115);
            this.LBoard4.TabIndex = 4;
            this.LBoard4.Winner = null;
            this.LBoard4.Slotclicked += new System.EventHandler(this.LBoard_Slotclicked);
            this.LBoard4.GridWon += new System.EventHandler(this.LBoard_Won);
            // 
            // LBoard5
            // 
            this.LBoard5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.LBoard5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LBoard5.Location = new System.Drawing.Point(166, 132);
            this.LBoard5.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.LBoard5.Name = "LBoard5";
            this.LBoard5.Size = new System.Drawing.Size(152, 115);
            this.LBoard5.TabIndex = 5;
            this.LBoard5.Winner = null;
            this.LBoard5.Slotclicked += new System.EventHandler(this.LBoard_Slotclicked);
            this.LBoard5.GridWon += new System.EventHandler(this.LBoard_Won);
            // 
            // LBoard6
            // 
            this.LBoard6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.LBoard6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LBoard6.Location = new System.Drawing.Point(327, 132);
            this.LBoard6.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.LBoard6.Name = "LBoard6";
            this.LBoard6.Size = new System.Drawing.Size(152, 115);
            this.LBoard6.TabIndex = 6;
            this.LBoard6.Winner = null;
            this.LBoard6.Slotclicked += new System.EventHandler(this.LBoard_Slotclicked);
            this.LBoard6.GridWon += new System.EventHandler(this.LBoard_Won);
            // 
            // LBoard7
            // 
            this.LBoard7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.LBoard7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LBoard7.Location = new System.Drawing.Point(5, 258);
            this.LBoard7.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.LBoard7.Name = "LBoard7";
            this.LBoard7.Size = new System.Drawing.Size(152, 117);
            this.LBoard7.TabIndex = 7;
            this.LBoard7.Winner = null;
            this.LBoard7.Slotclicked += new System.EventHandler(this.LBoard_Slotclicked);
            this.LBoard7.GridWon += new System.EventHandler(this.LBoard_Won);
            // 
            // LBoard8
            // 
            this.LBoard8.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.LBoard8.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LBoard8.Location = new System.Drawing.Point(166, 258);
            this.LBoard8.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.LBoard8.Name = "LBoard8";
            this.LBoard8.Size = new System.Drawing.Size(152, 117);
            this.LBoard8.TabIndex = 8;
            this.LBoard8.Winner = null;
            this.LBoard8.Slotclicked += new System.EventHandler(this.LBoard_Slotclicked);
            this.LBoard8.GridWon += new System.EventHandler(this.LBoard_Won);
            // 
            // LBoard9
            // 
            this.LBoard9.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.LBoard9.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LBoard9.Location = new System.Drawing.Point(327, 258);
            this.LBoard9.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.LBoard9.Name = "LBoard9";
            this.LBoard9.Size = new System.Drawing.Size(152, 117);
            this.LBoard9.TabIndex = 9;
            this.LBoard9.Winner = null;
            this.LBoard9.Slotclicked += new System.EventHandler(this.LBoard_Slotclicked);
            this.LBoard9.GridWon += new System.EventHandler(this.LBoard_Won);
            // 
            // UTTTForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 481);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MinimumSize = new System.Drawing.Size(500, 520);
            this.Name = "UTTTForm";
            this.Text = "UTTTForm";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label PlayerDisplayLabel;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private LocalGrid LBoard2;
        private LocalGrid LBoard3;
        private LocalGrid LBoard4;
        private LocalGrid LBoard5;
        private LocalGrid LBoard6;
        private LocalGrid LBoard7;
        private LocalGrid LBoard8;
        private LocalGrid LBoard9;
        private LocalGrid LBoard1;
    }
}