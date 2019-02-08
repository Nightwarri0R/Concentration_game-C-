namespace Concentration
{
    partial class GameForm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GameForm));
            this.menuStripOptions = new System.Windows.Forms.MenuStrip();
            this.stripItemRules = new System.Windows.Forms.ToolStripMenuItem();
            this.stripItemPause = new System.Windows.Forms.ToolStripMenuItem();
            this.stripItemResume = new System.Windows.Forms.ToolStripMenuItem();
            this.stripItemExit = new System.Windows.Forms.ToolStripMenuItem();
            this.fLPCards = new System.Windows.Forms.FlowLayoutPanel();
            this.pBarTimeLeft = new System.Windows.Forms.ProgressBar();
            this.timerTurn = new System.Windows.Forms.Timer(this.components);
            this.iL1 = new System.Windows.Forms.ImageList(this.components);
            this.iL2 = new System.Windows.Forms.ImageList(this.components);
            this.iL3 = new System.Windows.Forms.ImageList(this.components);
            this.iL4 = new System.Windows.Forms.ImageList(this.components);
            this.iL5 = new System.Windows.Forms.ImageList(this.components);
            this.iL6 = new System.Windows.Forms.ImageList(this.components);
            this.iL7 = new System.Windows.Forms.ImageList(this.components);
            this.iL8 = new System.Windows.Forms.ImageList(this.components);
            this.iL9 = new System.Windows.Forms.ImageList(this.components);
            this.iL10 = new System.Windows.Forms.ImageList(this.components);
            this.iL11 = new System.Windows.Forms.ImageList(this.components);
            this.iL12 = new System.Windows.Forms.ImageList(this.components);
            this.iL13 = new System.Windows.Forms.ImageList(this.components);
            this.iL14 = new System.Windows.Forms.ImageList(this.components);
            this.iL15 = new System.Windows.Forms.ImageList(this.components);
            this.iL16 = new System.Windows.Forms.ImageList(this.components);
            this.iL17 = new System.Windows.Forms.ImageList(this.components);
            this.iL18 = new System.Windows.Forms.ImageList(this.components);
            this.tLPPlayerDetails = new System.Windows.Forms.TableLayoutPanel();
            this.lPlayer1 = new System.Windows.Forms.Label();
            this.lPlayer2 = new System.Windows.Forms.Label();
            this.lS2 = new System.Windows.Forms.Label();
            this.lS1 = new System.Windows.Forms.Label();
            this.lScore1 = new System.Windows.Forms.Label();
            this.lScore2 = new System.Windows.Forms.Label();
            this.lUsername1 = new System.Windows.Forms.Label();
            this.lUsername2 = new System.Windows.Forms.Label();
            this.menuStripOptions.SuspendLayout();
            this.tLPPlayerDetails.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStripOptions
            // 
            this.menuStripOptions.BackColor = System.Drawing.Color.DodgerBlue;
            this.menuStripOptions.Font = new System.Drawing.Font("Pristina", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStripOptions.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.stripItemRules,
            this.stripItemPause,
            this.stripItemResume,
            this.stripItemExit});
            this.menuStripOptions.Location = new System.Drawing.Point(0, 0);
            this.menuStripOptions.Name = "menuStripOptions";
            this.menuStripOptions.Size = new System.Drawing.Size(441, 37);
            this.menuStripOptions.TabIndex = 0;
            this.menuStripOptions.Text = "Options";
            // 
            // stripItemRules
            // 
            this.stripItemRules.Name = "stripItemRules";
            this.stripItemRules.Size = new System.Drawing.Size(106, 33);
            this.stripItemRules.Text = "Show Rules";
            this.stripItemRules.Click += new System.EventHandler(this.stripItemRules_Click);
            // 
            // stripItemPause
            // 
            this.stripItemPause.Name = "stripItemPause";
            this.stripItemPause.Size = new System.Drawing.Size(64, 33);
            this.stripItemPause.Text = "Pause";
            this.stripItemPause.Click += new System.EventHandler(this.stripItemPause_Click);
            // 
            // stripItemResume
            // 
            this.stripItemResume.Name = "stripItemResume";
            this.stripItemResume.Size = new System.Drawing.Size(78, 33);
            this.stripItemResume.Text = "Resume";
            this.stripItemResume.Click += new System.EventHandler(this.stripItemResume_Click);
            // 
            // stripItemExit
            // 
            this.stripItemExit.Name = "stripItemExit";
            this.stripItemExit.Size = new System.Drawing.Size(98, 33);
            this.stripItemExit.Text = "Exit Game";
            this.stripItemExit.Click += new System.EventHandler(this.stripItemExit_Click);
            // 
            // fLPCards
            // 
            this.fLPCards.AutoSize = true;
            this.fLPCards.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.fLPCards.BackColor = System.Drawing.Color.Transparent;
            this.fLPCards.Location = new System.Drawing.Point(22, 54);
            this.fLPCards.Name = "fLPCards";
            this.fLPCards.Size = new System.Drawing.Size(0, 0);
            this.fLPCards.TabIndex = 1;
            // 
            // pBarTimeLeft
            // 
            this.pBarTimeLeft.BackColor = System.Drawing.Color.Gray;
            this.pBarTimeLeft.ForeColor = System.Drawing.Color.SpringGreen;
            this.pBarTimeLeft.Location = new System.Drawing.Point(12, 267);
            this.pBarTimeLeft.Name = "pBarTimeLeft";
            this.pBarTimeLeft.Size = new System.Drawing.Size(417, 23);
            this.pBarTimeLeft.TabIndex = 2;
            // 
            // timerTurn
            // 
            this.timerTurn.Tick += new System.EventHandler(this.timerTurn_Tick);
            // 
            // iL1
            // 
            this.iL1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("iL1.ImageStream")));
            this.iL1.TransparentColor = System.Drawing.Color.Transparent;
            this.iL1.Images.SetKeyName(0, "card.jpg");
            this.iL1.Images.SetKeyName(1, "Bear.jpg");
            // 
            // iL2
            // 
            this.iL2.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("iL2.ImageStream")));
            this.iL2.TransparentColor = System.Drawing.Color.Transparent;
            this.iL2.Images.SetKeyName(0, "card.jpg");
            this.iL2.Images.SetKeyName(1, "Bird.jpg");
            // 
            // iL3
            // 
            this.iL3.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("iL3.ImageStream")));
            this.iL3.TransparentColor = System.Drawing.Color.Transparent;
            this.iL3.Images.SetKeyName(0, "card.jpg");
            this.iL3.Images.SetKeyName(1, "Bunny.jpg");
            // 
            // iL4
            // 
            this.iL4.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("iL4.ImageStream")));
            this.iL4.TransparentColor = System.Drawing.Color.Transparent;
            this.iL4.Images.SetKeyName(0, "card.jpg");
            this.iL4.Images.SetKeyName(1, "Crocodile.jpg");
            // 
            // iL5
            // 
            this.iL5.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("iL5.ImageStream")));
            this.iL5.TransparentColor = System.Drawing.Color.Transparent;
            this.iL5.Images.SetKeyName(0, "card.jpg");
            this.iL5.Images.SetKeyName(1, "Dinosaur.jpg");
            // 
            // iL6
            // 
            this.iL6.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("iL6.ImageStream")));
            this.iL6.TransparentColor = System.Drawing.Color.Transparent;
            this.iL6.Images.SetKeyName(0, "card.jpg");
            this.iL6.Images.SetKeyName(1, "Dog.jpg");
            // 
            // iL7
            // 
            this.iL7.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("iL7.ImageStream")));
            this.iL7.TransparentColor = System.Drawing.Color.Transparent;
            this.iL7.Images.SetKeyName(0, "card.jpg");
            this.iL7.Images.SetKeyName(1, "Dragon.jpg");
            // 
            // iL8
            // 
            this.iL8.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("iL8.ImageStream")));
            this.iL8.TransparentColor = System.Drawing.Color.Transparent;
            this.iL8.Images.SetKeyName(0, "card.jpg");
            this.iL8.Images.SetKeyName(1, "Elephant.jpg");
            // 
            // iL9
            // 
            this.iL9.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("iL9.ImageStream")));
            this.iL9.TransparentColor = System.Drawing.Color.Transparent;
            this.iL9.Images.SetKeyName(0, "card.jpg");
            this.iL9.Images.SetKeyName(1, "fish.jpg");
            // 
            // iL10
            // 
            this.iL10.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("iL10.ImageStream")));
            this.iL10.TransparentColor = System.Drawing.Color.Transparent;
            this.iL10.Images.SetKeyName(0, "card.jpg");
            this.iL10.Images.SetKeyName(1, "Horse.jpg");
            // 
            // iL11
            // 
            this.iL11.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("iL11.ImageStream")));
            this.iL11.TransparentColor = System.Drawing.Color.Transparent;
            this.iL11.Images.SetKeyName(0, "card.jpg");
            this.iL11.Images.SetKeyName(1, "Kitty.jpg");
            // 
            // iL12
            // 
            this.iL12.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("iL12.ImageStream")));
            this.iL12.TransparentColor = System.Drawing.Color.Transparent;
            this.iL12.Images.SetKeyName(0, "card.jpg");
            this.iL12.Images.SetKeyName(1, "Moose.jpg");
            // 
            // iL13
            // 
            this.iL13.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("iL13.ImageStream")));
            this.iL13.TransparentColor = System.Drawing.Color.Transparent;
            this.iL13.Images.SetKeyName(0, "card.jpg");
            this.iL13.Images.SetKeyName(1, "Pig.jpg");
            // 
            // iL14
            // 
            this.iL14.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("iL14.ImageStream")));
            this.iL14.TransparentColor = System.Drawing.Color.Transparent;
            this.iL14.Images.SetKeyName(0, "card.jpg");
            this.iL14.Images.SetKeyName(1, "Sheep.jpg");
            // 
            // iL15
            // 
            this.iL15.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("iL15.ImageStream")));
            this.iL15.TransparentColor = System.Drawing.Color.Transparent;
            this.iL15.Images.SetKeyName(0, "card.jpg");
            this.iL15.Images.SetKeyName(1, "Snake.jpg");
            // 
            // iL16
            // 
            this.iL16.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("iL16.ImageStream")));
            this.iL16.TransparentColor = System.Drawing.Color.Transparent;
            this.iL16.Images.SetKeyName(0, "card.jpg");
            this.iL16.Images.SetKeyName(1, "Spider.jpg");
            // 
            // iL17
            // 
            this.iL17.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("iL17.ImageStream")));
            this.iL17.TransparentColor = System.Drawing.Color.Transparent;
            this.iL17.Images.SetKeyName(0, "card.jpg");
            this.iL17.Images.SetKeyName(1, "Tiger.jpg");
            // 
            // iL18
            // 
            this.iL18.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("iL18.ImageStream")));
            this.iL18.TransparentColor = System.Drawing.Color.Transparent;
            this.iL18.Images.SetKeyName(0, "card.jpg");
            this.iL18.Images.SetKeyName(1, "Zebra.jpg");
            // 
            // tLPPlayerDetails
            // 
            this.tLPPlayerDetails.BackColor = System.Drawing.Color.Transparent;
            this.tLPPlayerDetails.ColumnCount = 5;
            this.tLPPlayerDetails.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tLPPlayerDetails.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tLPPlayerDetails.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tLPPlayerDetails.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tLPPlayerDetails.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tLPPlayerDetails.Controls.Add(this.lScore1, 1, 1);
            this.tLPPlayerDetails.Controls.Add(this.lS1, 0, 1);
            this.tLPPlayerDetails.Controls.Add(this.lPlayer1, 0, 0);
            this.tLPPlayerDetails.Controls.Add(this.lScore2, 4, 1);
            this.tLPPlayerDetails.Controls.Add(this.lPlayer2, 3, 0);
            this.tLPPlayerDetails.Controls.Add(this.lS2, 3, 1);
            this.tLPPlayerDetails.Controls.Add(this.lUsername1, 1, 0);
            this.tLPPlayerDetails.Controls.Add(this.lUsername2, 4, 0);
            this.tLPPlayerDetails.Location = new System.Drawing.Point(12, 310);
            this.tLPPlayerDetails.Name = "tLPPlayerDetails";
            this.tLPPlayerDetails.RowCount = 2;
            this.tLPPlayerDetails.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tLPPlayerDetails.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tLPPlayerDetails.Size = new System.Drawing.Size(417, 104);
            this.tLPPlayerDetails.TabIndex = 3;
            // 
            // lPlayer1
            // 
            this.lPlayer1.AutoSize = true;
            this.lPlayer1.Font = new System.Drawing.Font("Pristina", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lPlayer1.ForeColor = System.Drawing.Color.White;
            this.lPlayer1.Location = new System.Drawing.Point(3, 0);
            this.lPlayer1.Name = "lPlayer1";
            this.lPlayer1.Size = new System.Drawing.Size(72, 27);
            this.lPlayer1.TabIndex = 0;
            this.lPlayer1.Text = "Player 1:";
            // 
            // lPlayer2
            // 
            this.lPlayer2.AutoSize = true;
            this.lPlayer2.Font = new System.Drawing.Font("Pristina", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lPlayer2.ForeColor = System.Drawing.Color.White;
            this.lPlayer2.Location = new System.Drawing.Point(252, 0);
            this.lPlayer2.Name = "lPlayer2";
            this.lPlayer2.Size = new System.Drawing.Size(76, 27);
            this.lPlayer2.TabIndex = 2;
            this.lPlayer2.Text = "Player 2:";
            // 
            // lS2
            // 
            this.lS2.AutoSize = true;
            this.lS2.Font = new System.Drawing.Font("Pristina", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lS2.ForeColor = System.Drawing.Color.White;
            this.lS2.Location = new System.Drawing.Point(252, 52);
            this.lS2.Name = "lS2";
            this.lS2.Size = new System.Drawing.Size(54, 27);
            this.lS2.TabIndex = 3;
            this.lS2.Text = "Score:";
            // 
            // lS1
            // 
            this.lS1.AutoSize = true;
            this.lS1.Font = new System.Drawing.Font("Pristina", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lS1.ForeColor = System.Drawing.Color.White;
            this.lS1.Location = new System.Drawing.Point(3, 52);
            this.lS1.Name = "lS1";
            this.lS1.Size = new System.Drawing.Size(54, 27);
            this.lS1.TabIndex = 5;
            this.lS1.Text = "Score:";
            // 
            // lScore1
            // 
            this.lScore1.AutoSize = true;
            this.lScore1.Font = new System.Drawing.Font("Pristina", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lScore1.ForeColor = System.Drawing.Color.White;
            this.lScore1.Location = new System.Drawing.Point(86, 52);
            this.lScore1.Name = "lScore1";
            this.lScore1.Size = new System.Drawing.Size(21, 27);
            this.lScore1.TabIndex = 6;
            this.lScore1.Text = "0";
            // 
            // lScore2
            // 
            this.lScore2.AutoSize = true;
            this.lScore2.Font = new System.Drawing.Font("Pristina", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lScore2.ForeColor = System.Drawing.Color.White;
            this.lScore2.Location = new System.Drawing.Point(335, 52);
            this.lScore2.Name = "lScore2";
            this.lScore2.Size = new System.Drawing.Size(21, 27);
            this.lScore2.TabIndex = 7;
            this.lScore2.Text = "0";
            // 
            // lUsername1
            // 
            this.lUsername1.AutoSize = true;
            this.lUsername1.Font = new System.Drawing.Font("Pristina", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lUsername1.ForeColor = System.Drawing.Color.White;
            this.lUsername1.Location = new System.Drawing.Point(86, 0);
            this.lUsername1.Name = "lUsername1";
            this.lUsername1.Size = new System.Drawing.Size(0, 27);
            this.lUsername1.TabIndex = 8;
            // 
            // lUsername2
            // 
            this.lUsername2.AutoSize = true;
            this.lUsername2.Font = new System.Drawing.Font("Pristina", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lUsername2.ForeColor = System.Drawing.Color.White;
            this.lUsername2.Location = new System.Drawing.Point(335, 0);
            this.lUsername2.Name = "lUsername2";
            this.lUsername2.Size = new System.Drawing.Size(0, 27);
            this.lUsername2.TabIndex = 9;
            // 
            // GameForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(441, 426);
            this.Controls.Add(this.tLPPlayerDetails);
            this.Controls.Add(this.pBarTimeLeft);
            this.Controls.Add(this.fLPCards);
            this.Controls.Add(this.menuStripOptions);
            this.MainMenuStrip = this.menuStripOptions;
            this.Name = "GameForm";
            this.Text = "Concentration";
            this.menuStripOptions.ResumeLayout(false);
            this.menuStripOptions.PerformLayout();
            this.tLPPlayerDetails.ResumeLayout(false);
            this.tLPPlayerDetails.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStripOptions;
        private System.Windows.Forms.ToolStripMenuItem stripItemRules;
        private System.Windows.Forms.ToolStripMenuItem stripItemPause;
        private System.Windows.Forms.ToolStripMenuItem stripItemExit;
        private System.Windows.Forms.FlowLayoutPanel fLPCards;
        private System.Windows.Forms.ProgressBar pBarTimeLeft;
        private System.Windows.Forms.Timer timerTurn;
        private System.Windows.Forms.ToolStripMenuItem stripItemResume;
        private System.Windows.Forms.ImageList iL1;
        private System.Windows.Forms.ImageList iL2;
        private System.Windows.Forms.ImageList iL3;
        private System.Windows.Forms.ImageList iL4;
        private System.Windows.Forms.ImageList iL5;
        private System.Windows.Forms.ImageList iL6;
        private System.Windows.Forms.ImageList iL7;
        private System.Windows.Forms.ImageList iL8;
        private System.Windows.Forms.ImageList iL9;
        private System.Windows.Forms.ImageList iL10;
        private System.Windows.Forms.ImageList iL11;
        private System.Windows.Forms.ImageList iL12;
        private System.Windows.Forms.ImageList iL13;
        private System.Windows.Forms.ImageList iL14;
        private System.Windows.Forms.ImageList iL15;
        private System.Windows.Forms.ImageList iL16;
        private System.Windows.Forms.ImageList iL17;
        private System.Windows.Forms.ImageList iL18;
        private System.Windows.Forms.TableLayoutPanel tLPPlayerDetails;
        private System.Windows.Forms.Label lScore1;
        private System.Windows.Forms.Label lS1;
        private System.Windows.Forms.Label lPlayer1;
        private System.Windows.Forms.Label lScore2;
        private System.Windows.Forms.Label lPlayer2;
        private System.Windows.Forms.Label lS2;
        private System.Windows.Forms.Label lUsername1;
        private System.Windows.Forms.Label lUsername2;
    }
}