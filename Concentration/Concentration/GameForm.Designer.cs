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
            this.iL10 = new System.Windows.Forms.ImageList(this.components);
            this.tLPPlayerDetails = new System.Windows.Forms.TableLayoutPanel();
            this.lScore1 = new System.Windows.Forms.Label();
            this.lS1 = new System.Windows.Forms.Label();
            this.lPlayer1 = new System.Windows.Forms.Label();
            this.lScore2 = new System.Windows.Forms.Label();
            this.lPlayer2 = new System.Windows.Forms.Label();
            this.lS2 = new System.Windows.Forms.Label();
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
            this.fLPCards.BackColor = System.Drawing.Color.Transparent;
            this.fLPCards.Location = new System.Drawing.Point(12, 51);
            this.fLPCards.MinimumSize = new System.Drawing.Size(50, 50);
            this.fLPCards.Name = "fLPCards";
            this.fLPCards.Size = new System.Drawing.Size(417, 201);
            this.fLPCards.TabIndex = 1;
            // 
            // pBarTimeLeft
            // 
            this.pBarTimeLeft.BackColor = System.Drawing.SystemColors.Control;
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
            // iL10
            // 
            this.iL10.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("iL10.ImageStream")));
            this.iL10.TransparentColor = System.Drawing.Color.Transparent;
            this.iL10.Images.SetKeyName(0, "card.jpg");
            this.iL10.Images.SetKeyName(1, "Horse.jpg");
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
        private System.Windows.Forms.ImageList iL10;
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