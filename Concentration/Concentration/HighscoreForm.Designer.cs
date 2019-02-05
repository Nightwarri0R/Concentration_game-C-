namespace Concentration
{
    partial class HighscoreForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HighscoreForm));
            this.btnMenu = new System.Windows.Forms.Button();
            this.lHighscores = new System.Windows.Forms.Label();
            this.tLPScores = new System.Windows.Forms.TableLayoutPanel();
            this.btnEasy = new System.Windows.Forms.Button();
            this.btnHard = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnMenu
            // 
            this.btnMenu.Font = new System.Drawing.Font("MS Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMenu.Location = new System.Drawing.Point(511, 432);
            this.btnMenu.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnMenu.Name = "btnMenu";
            this.btnMenu.Size = new System.Drawing.Size(136, 42);
            this.btnMenu.TabIndex = 0;
            this.btnMenu.Text = "Back to Menu";
            this.btnMenu.UseVisualStyleBackColor = true;
            this.btnMenu.Click += new System.EventHandler(this.btnMenu_Click);
            // 
            // lHighscores
            // 
            this.lHighscores.AutoSize = true;
            this.lHighscores.BackColor = System.Drawing.Color.Transparent;
            this.lHighscores.Font = new System.Drawing.Font("MS Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lHighscores.ForeColor = System.Drawing.Color.YellowGreen;
            this.lHighscores.Location = new System.Drawing.Point(293, 85);
            this.lHighscores.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lHighscores.Name = "lHighscores";
            this.lHighscores.Size = new System.Drawing.Size(140, 24);
            this.lHighscores.TabIndex = 1;
            this.lHighscores.Text = "Highscores";
            // 
            // tLPScores
            // 
            this.tLPScores.ColumnCount = 3;
            this.tLPScores.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 23.72881F));
            this.tLPScores.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 76.27119F));
            this.tLPScores.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 224F));
            this.tLPScores.Location = new System.Drawing.Point(32, 129);
            this.tLPScores.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tLPScores.Name = "tLPScores";
            this.tLPScores.RowCount = 2;
            this.tLPScores.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tLPScores.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tLPScores.Size = new System.Drawing.Size(615, 266);
            this.tLPScores.TabIndex = 2;
            // 
            // btnEasy
            // 
            this.btnEasy.Font = new System.Drawing.Font("MS Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEasy.Location = new System.Drawing.Point(65, 37);
            this.btnEasy.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnEasy.Name = "btnEasy";
            this.btnEasy.Size = new System.Drawing.Size(100, 28);
            this.btnEasy.TabIndex = 3;
            this.btnEasy.Text = "Easy Mode";
            this.btnEasy.UseVisualStyleBackColor = true;
            this.btnEasy.Click += new System.EventHandler(this.btnEasy_Click);
            // 
            // btnHard
            // 
            this.btnHard.Font = new System.Drawing.Font("MS Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHard.Location = new System.Drawing.Point(445, 39);
            this.btnHard.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnHard.Name = "btnHard";
            this.btnHard.Size = new System.Drawing.Size(100, 28);
            this.btnHard.TabIndex = 4;
            this.btnHard.Text = "Hard Mode";
            this.btnHard.UseVisualStyleBackColor = true;
            this.btnHard.Click += new System.EventHandler(this.btnHard_Click);
            // 
            // HighscoreForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(675, 489);
            this.Controls.Add(this.btnHard);
            this.Controls.Add(this.btnEasy);
            this.Controls.Add(this.tLPScores);
            this.Controls.Add(this.lHighscores);
            this.Controls.Add(this.btnMenu);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "HighscoreForm";
            this.Text = "Concentration";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnMenu;
        private System.Windows.Forms.Label lHighscores;
        private System.Windows.Forms.TableLayoutPanel tLPScores;
        private System.Windows.Forms.Button btnEasy;
        private System.Windows.Forms.Button btnHard;
    }
}