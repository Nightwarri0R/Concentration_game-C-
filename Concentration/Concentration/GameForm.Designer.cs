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
            this.menuStripOptions.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitConPlayers)).BeginInit();
            this.splitConPlayers.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStripOptions
            // 
            this.menuStripOptions.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStripOptions.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.stripItemRules,
            this.stripItemPause,
            this.stripItemResume,
            this.stripItemExit});
            this.menuStripOptions.Location = new System.Drawing.Point(0, 0);
            this.menuStripOptions.Name = "menuStripOptions";
            this.menuStripOptions.Padding = new System.Windows.Forms.Padding(8, 2, 0, 2);
            this.menuStripOptions.Size = new System.Drawing.Size(715, 28);
            this.menuStripOptions.TabIndex = 0;
            this.menuStripOptions.Text = "Options";
            // 
            // stripItemRules
            // 
            this.stripItemRules.Name = "stripItemRules";
            this.stripItemRules.Size = new System.Drawing.Size(96, 24);
            this.stripItemRules.Text = "Show Rules";
            this.stripItemRules.Click += new System.EventHandler(this.stripItemRules_Click);
            // 
            // stripItemPause
            // 
            this.stripItemPause.Name = "stripItemPause";
            this.stripItemPause.Size = new System.Drawing.Size(58, 24);
            this.stripItemPause.Text = "Pause";
            this.stripItemPause.Click += new System.EventHandler(this.stripItemPause_Click);
            // 
            // stripItemResume
            // 
            this.stripItemResume.Name = "stripItemResume";
            this.stripItemResume.Size = new System.Drawing.Size(73, 24);
            this.stripItemResume.Text = "Resume";
            this.stripItemResume.Click += new System.EventHandler(this.stripItemResume_Click);
            // 
            // stripItemExit
            // 
            this.stripItemExit.Name = "stripItemExit";
            this.stripItemExit.Size = new System.Drawing.Size(88, 24);
            this.stripItemExit.Text = "Exit Game";
            this.stripItemExit.Click += new System.EventHandler(this.stripItemExit_Click);
            // 
            // fLPCards
            // 
            this.fLPCards.Location = new System.Drawing.Point(68, 58);
            this.fLPCards.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.fLPCards.Name = "fLPCards";
            this.fLPCards.Size = new System.Drawing.Size(567, 231);
            this.fLPCards.TabIndex = 1;
            // 
            // pBarTimeLeft
            // 
            this.pBarTimeLeft.Location = new System.Drawing.Point(68, 316);
            this.pBarTimeLeft.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pBarTimeLeft.Name = "pBarTimeLeft";
            this.pBarTimeLeft.Size = new System.Drawing.Size(567, 28);
            this.pBarTimeLeft.TabIndex = 2;
            // 
            // timerTurn
            // 
            this.timerTurn.Tick += new System.EventHandler(this.timerTurn_Tick);
            // 
            // splitConPlayers
            // 
            this.splitConPlayers.Location = new System.Drawing.Point(68, 377);
            this.splitConPlayers.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.splitConPlayers.Name = "splitConPlayers";
            // 
            // splitConPlayers.Panel1
            // 
            this.splitConPlayers.Panel1.Font = new System.Drawing.Font("MS Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // splitConPlayers.Panel2
            // 
            this.splitConPlayers.Panel2.Font = new System.Drawing.Font("MS Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.splitConPlayers.Size = new System.Drawing.Size(567, 133);
            this.splitConPlayers.SplitterDistance = 278;
            this.splitConPlayers.SplitterWidth = 5;
            this.splitConPlayers.TabIndex = 3;
            // 
            // GameForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(715, 524);
            this.Controls.Add(this.splitConPlayers);
            this.Controls.Add(this.pBarTimeLeft);
            this.Controls.Add(this.fLPCards);
            this.Controls.Add(this.menuStripOptions);
            this.MainMenuStrip = this.menuStripOptions;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
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