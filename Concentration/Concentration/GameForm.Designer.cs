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
            this.stripItemExit = new System.Windows.Forms.ToolStripMenuItem();
            this.fLPCards = new System.Windows.Forms.FlowLayoutPanel();
            this.pBarTimeLeft = new System.Windows.Forms.ProgressBar();
            this.timerTurn = new System.Windows.Forms.Timer(this.components);
            this.splitConPlayers = new System.Windows.Forms.SplitContainer();
            this.stripItemResume = new System.Windows.Forms.ToolStripMenuItem();
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
            // splitConPlayers
            // 
            this.splitConPlayers.Location = new System.Drawing.Point(51, 306);
            this.splitConPlayers.Name = "splitConPlayers";
            this.splitConPlayers.Size = new System.Drawing.Size(425, 108);
            this.splitConPlayers.SplitterDistance = 209;
            this.splitConPlayers.TabIndex = 3;
            // 
            // stripItemResume
            // 
            this.stripItemResume.Name = "stripItemResume";
            this.stripItemResume.Size = new System.Drawing.Size(61, 20);
            this.stripItemResume.Text = "Resume";
            this.stripItemResume.Click += new System.EventHandler(this.stripItemResume_Click);
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
    }
}