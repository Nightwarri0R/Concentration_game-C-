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
            this.splitConPlayers = new System.Windows.Forms.SplitContainer();
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
            this.menuStripOptions.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitConPlayers)).BeginInit();
            this.splitConPlayers.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStripOptions
            // 
            this.menuStripOptions.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.stripItemRules,
            this.stripItemPause,
            this.stripItemResume,
            this.stripItemExit});
            this.menuStripOptions.Location = new System.Drawing.Point(0, 0);
            this.menuStripOptions.Name = "menuStripOptions";
            this.menuStripOptions.Size = new System.Drawing.Size(536, 24);
            this.menuStripOptions.TabIndex = 0;
            this.menuStripOptions.Text = "Options";
            // 
            // stripItemRules
            // 
            this.stripItemRules.Name = "stripItemRules";
            this.stripItemRules.Size = new System.Drawing.Size(79, 20);
            this.stripItemRules.Text = "Show Rules";
            this.stripItemRules.Click += new System.EventHandler(this.stripItemRules_Click);
            // 
            // stripItemPause
            // 
            this.stripItemPause.Name = "stripItemPause";
            this.stripItemPause.Size = new System.Drawing.Size(50, 20);
            this.stripItemPause.Text = "Pause";
            this.stripItemPause.Click += new System.EventHandler(this.stripItemPause_Click);
            // 
            // stripItemResume
            // 
            this.stripItemResume.Name = "stripItemResume";
            this.stripItemResume.Size = new System.Drawing.Size(61, 20);
            this.stripItemResume.Text = "Resume";
            this.stripItemResume.Click += new System.EventHandler(this.stripItemResume_Click);
            // 
            // stripItemExit
            // 
            this.stripItemExit.Name = "stripItemExit";
            this.stripItemExit.Size = new System.Drawing.Size(71, 20);
            this.stripItemExit.Text = "Exit Game";
            this.stripItemExit.Click += new System.EventHandler(this.stripItemExit_Click);
            // 
            // fLPCards
            // 
            this.fLPCards.Location = new System.Drawing.Point(51, 47);
            this.fLPCards.Name = "fLPCards";
            this.fLPCards.Size = new System.Drawing.Size(425, 188);
            this.fLPCards.TabIndex = 1;
            // 
            // pBarTimeLeft
            // 
            this.pBarTimeLeft.Location = new System.Drawing.Point(51, 257);
            this.pBarTimeLeft.Name = "pBarTimeLeft";
            this.pBarTimeLeft.Size = new System.Drawing.Size(425, 23);
            this.pBarTimeLeft.TabIndex = 2;
            // 
            // timerTurn
            // 
            this.timerTurn.Tick += new System.EventHandler(this.timerTurn_Tick);
            // 
            // splitConPlayers
            // 
            this.splitConPlayers.BackColor = System.Drawing.Color.Transparent;
            this.splitConPlayers.Location = new System.Drawing.Point(51, 306);
            this.splitConPlayers.Name = "splitConPlayers";
            this.splitConPlayers.Size = new System.Drawing.Size(425, 108);
            this.splitConPlayers.SplitterDistance = 209;
            this.splitConPlayers.TabIndex = 3;
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
            // GameForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(536, 426);
            this.Controls.Add(this.splitConPlayers);
            this.Controls.Add(this.pBarTimeLeft);
            this.Controls.Add(this.fLPCards);
            this.Controls.Add(this.menuStripOptions);
            this.MainMenuStrip = this.menuStripOptions;
            this.Name = "GameForm";
            this.Text = "Concentration";
            this.menuStripOptions.ResumeLayout(false);
            this.menuStripOptions.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitConPlayers)).EndInit();
            this.splitConPlayers.ResumeLayout(false);
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
        private System.Windows.Forms.SplitContainer splitConPlayers;
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
    }
}