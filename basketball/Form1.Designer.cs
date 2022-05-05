namespace basketball
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
            this.westselect = new System.Windows.Forms.ComboBox();
            this.westteamselect = new System.Windows.Forms.Label();
            this.eastselect = new System.Windows.Forms.ComboBox();
            this.eastteamselect = new System.Windows.Forms.Label();
            this.lblvaluewest = new System.Windows.Forms.Label();
            this.lblvalueeast = new System.Windows.Forms.Label();
            this.westoutputlable = new System.Windows.Forms.Label();
            this.eastoutputlable = new System.Windows.Forms.Label();
            this.title = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.scorewest = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.scorefinal = new System.Windows.Forms.Label();
            this.scoreeast = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // westselect combox options (with score win/loss and seed)
            // 
            this.westselect.FormattingEnabled = true;
            this.westselect.Items.AddRange(new object[] {
            "Suns                                       Score:    115      Win/Loss:    78%   " +
                "   Seed:    1",
            "Grizzlies                                 Score:    115      Win/Loss:    68%    " +
                "  Seed:    2",
            "Warriors                                Score:    111      Win/Loss:    64%      " +
                "Seed:    3",
            "Mavericks                             Score:    108      Win/Loss:    63%      Se" +
                "ed:    4",
            "Jazz                                        Score:    112      Win/Loss:    59%  " +
                "    Seed:    5",
            "Denver                                  Score:    112      Win/Loss:    58%      " +
                "Seed:    6",
            "Timberwolves                      Score:    115      Win/Loss:    56%      Seed: " +
                "   7",
            "Pelicans                                Score:    109      Win/Loss:    43%      " +
                "Seed:    8"});
            this.westselect.Location = new System.Drawing.Point(44, 60);
            this.westselect.Margin = new System.Windows.Forms.Padding(2);
            this.westselect.Name = "westselect";
            this.westselect.Size = new System.Drawing.Size(92, 21);
            this.westselect.TabIndex = 0;
            this.westselect.SelectedIndexChanged += new System.EventHandler(this.cboState_SelectedIndexChanged);
            // 
            // westteamselect (west combobox)
            // 
            this.westteamselect.AutoSize = true;
            this.westteamselect.Location = new System.Drawing.Point(41, 45);
            this.westteamselect.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.westteamselect.Name = "westteamselect";
            this.westteamselect.Size = new System.Drawing.Size(95, 13);
            this.westteamselect.TabIndex = 1;
            this.westteamselect.Text = "West Team Select";
            // 
            // eastselect combox options (with score win/loss and seed)
            // 
            this.eastselect.DropDownWidth = 92;
            this.eastselect.FormattingEnabled = true;
            this.eastselect.Items.AddRange(new object[] {
            "Heat                                      Score:    113      Win/Loss:    64%    " +
                "  Seed:    1",
            "Celtics                                   Score:    112      Win/Loss:    62%    " +
                "  Seed:    2",
            "Bucks                                    Score:    115      Win/Loss:    62%     " +
                " Seed:    3",
            "76ers                                     Score:    113      Win/Loss:    62%    " +
                "  Seed:    4",
            "Raptors                                 Score:    113      Win/Loss:    58%      " +
                "Seed:    5",
            "Bulls                                      Score:    113      Win/Loss:    56%   " +
                "   Seed:    6",
            "Nets                                      Score:    113      Win/Loss:    53%    " +
                "  Seed:    7",
            "Hawks                                   Score:    113      Win/Loss:    52%      " +
                "Seed:    8"});
            this.eastselect.Location = new System.Drawing.Point(455, 60);
            this.eastselect.Name = "eastselect";
            this.eastselect.Size = new System.Drawing.Size(92, 21);
            this.eastselect.TabIndex = 2;
            this.eastselect.SelectedIndexChanged += new System.EventHandler(this.cboState_SelectedIndexChanged);
            // 
            // eastteamselect (east combo box)
            // 
            this.eastteamselect.AutoSize = true;
            this.eastteamselect.Location = new System.Drawing.Point(456, 45);
            this.eastteamselect.Name = "eastteamselect";
            this.eastteamselect.Size = new System.Drawing.Size(91, 13);
            this.eastteamselect.TabIndex = 3;
            this.eastteamselect.Text = "East Team Select";
            // 
            // west output values
            // 
            this.lblvaluewest.AutoSize = true;
            this.lblvaluewest.Location = new System.Drawing.Point(147, 166);
            this.lblvaluewest.Name = "lblvaluewest";
            this.lblvaluewest.Size = new System.Drawing.Size(0, 13);
            this.lblvaluewest.TabIndex = 4;
            this.lblvaluewest.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // east output values
            // 
            this.lblvalueeast.AutoSize = true;
            this.lblvalueeast.Location = new System.Drawing.Point(147, 235);
            this.lblvalueeast.Name = "lblvalueeast";
            this.lblvalueeast.Size = new System.Drawing.Size(0, 13);
            this.lblvalueeast.TabIndex = 6;
            this.lblvalueeast.TextAlign = System.Drawing.ContentAlignment.TopCenter;
         
            // 
            // westoutputlable west team
            // 
            this.westoutputlable.AutoSize = true;
            this.westoutputlable.Location = new System.Drawing.Point(229, 134);
            this.westoutputlable.Name = "westoutputlable";
            this.westoutputlable.Size = new System.Drawing.Size(135, 13);
            this.westoutputlable.TabIndex = 7;
            this.westoutputlable.Text = "Western Conference Team";
            // 
            // eastoutputlable east team
            // 
            this.eastoutputlable.AutoSize = true;
            this.eastoutputlable.Location = new System.Drawing.Point(229, 199);
            this.eastoutputlable.Name = "eastoutputlable";
            this.eastoutputlable.Size = new System.Drawing.Size(131, 13);
            this.eastoutputlable.TabIndex = 8;
            this.eastoutputlable.Text = "Eastern Conference Team";
            // 
            // title card
            // 
            this.title.AutoSize = true;
            this.title.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.title.Location = new System.Drawing.Point(93, 9);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(405, 31);
            this.title.TabIndex = 9;
            this.title.Text = "NBA Finals Matchup Predictor";
            // 
            // nba logo
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(272, 45);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(53, 86);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            // 
            // final west score
            // 
            this.scorewest.AutoSize = true;
            this.scorewest.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.scorewest.Location = new System.Drawing.Point(-236, 316);
            this.scorewest.Name = "scorewest";
            this.scorewest.Size = new System.Drawing.Size(456, 25);
            this.scorewest.TabIndex = 11;
            this.scorewest.Text = "                                                            ---";
            this.scorewest.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
           
            // 
            // final score card (west    -     east) 
            // 
            this.scorefinal.AutoSize = true;
            this.scorefinal.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.scorefinal.Location = new System.Drawing.Point(155, 265);
            this.scorefinal.Name = "scorefinal";
            this.scorefinal.Size = new System.Drawing.Size(273, 37);
            this.scorefinal.TabIndex = 14;
            this.scorefinal.Text = "West     -     East";
           
            // 
            // final east score
            // 
            this.scoreeast.AutoSize = true;
            this.scoreeast.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.scoreeast.Location = new System.Drawing.Point(-279, 11);
            this.scoreeast.Name = "scoreeast";
            this.scoreeast.Size = new System.Drawing.Size(491, 25);
            this.scoreeast.TabIndex = 15;
            this.scoreeast.Text = "                                                           ---      ";
            this.scoreeast.TextAlign = System.Drawing.ContentAlignment.TopCenter;


            //coverup panels for the final score so it can be displayed nicely
            // panel1
            // 
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.scoreeast);
            this.panel1.Location = new System.Drawing.Point(232, 305);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(421, 49);
            this.panel1.TabIndex = 12;
            // 
            // panel2
            // 
            this.panel2.Location = new System.Drawing.Point(65, 309);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(101, 32);
            this.panel2.TabIndex = 13;// 
            // panel3 
            // 
            this.panel3.Location = new System.Drawing.Point(31, 5);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(92, 43);
            this.panel3.TabIndex = 16;
            // 
            // panel4
            // 
            this.panel4.Location = new System.Drawing.Point(205, 6);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(194, 42);
            this.panel4.TabIndex = 17;
            // 
            // all gui controls
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 366);
            this.Controls.Add(this.scorefinal);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.scorewest);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.title);
            this.Controls.Add(this.eastoutputlable);
            this.Controls.Add(this.westoutputlable);
            this.Controls.Add(this.lblvalueeast);
            this.Controls.Add(this.lblvaluewest);
            this.Controls.Add(this.eastteamselect);
            this.Controls.Add(this.eastselect);
            this.Controls.Add(this.westteamselect);
            this.Controls.Add(this.westselect);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox westselect;
        private System.Windows.Forms.Label westteamselect;
        private System.Windows.Forms.ComboBox eastselect;
        private System.Windows.Forms.Label eastteamselect;
        private System.Windows.Forms.Label lblvaluewest;
        private System.Windows.Forms.Label lblvalueeast;
        private System.Windows.Forms.Label westoutputlable;
        private System.Windows.Forms.Label eastoutputlable;
        private System.Windows.Forms.Label title;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label scorewest;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label scorefinal;
        private System.Windows.Forms.Label scoreeast;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel3;
    }
}

