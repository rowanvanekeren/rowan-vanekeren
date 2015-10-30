namespace YatzeeTeerling
{
    partial class ScoreBoardView
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.score1 = new System.Windows.Forms.Label();
            this.score2 = new System.Windows.Forms.Label();
            this.score3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.score4 = new System.Windows.Forms.Label();
            this.currenttextonly = new System.Windows.Forms.Label();
            this.CurrentScore = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // score1
            // 
            this.score1.AutoSize = true;
            this.score1.Location = new System.Drawing.Point(71, 35);
            this.score1.Name = "score1";
            this.score1.Size = new System.Drawing.Size(51, 17);
            this.score1.TabIndex = 1;
            this.score1.Text = "score1";
            // 
            // score2
            // 
            this.score2.AutoSize = true;
            this.score2.Location = new System.Drawing.Point(71, 52);
            this.score2.Name = "score2";
            this.score2.Size = new System.Drawing.Size(51, 17);
            this.score2.TabIndex = 2;
            this.score2.Text = "score2";
            // 
            // score3
            // 
            this.score3.AutoSize = true;
            this.score3.Location = new System.Drawing.Point(71, 69);
            this.score3.Name = "score3";
            this.score3.Size = new System.Drawing.Size(51, 17);
            this.score3.TabIndex = 3;
            this.score3.Text = "score3";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(130, 14);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(85, 17);
            this.label4.TabIndex = 4;
            this.label4.Text = "High Scores";
            // 
            // score4
            // 
            this.score4.AutoSize = true;
            this.score4.Location = new System.Drawing.Point(71, 86);
            this.score4.Name = "score4";
            this.score4.Size = new System.Drawing.Size(51, 17);
            this.score4.TabIndex = 5;
            this.score4.Text = "score4";
            // 
            // currenttextonly
            // 
            this.currenttextonly.AutoSize = true;
            this.currenttextonly.Location = new System.Drawing.Point(133, 136);
            this.currenttextonly.Name = "currenttextonly";
            this.currenttextonly.Size = new System.Drawing.Size(100, 17);
            this.currenttextonly.TabIndex = 6;
            this.currenttextonly.Text = "Current Score:";
            // 
            // CurrentScore
            // 
            this.CurrentScore.AutoSize = true;
            this.CurrentScore.Location = new System.Drawing.Point(239, 136);
            this.CurrentScore.Name = "CurrentScore";
            this.CurrentScore.Size = new System.Drawing.Size(45, 17);
            this.CurrentScore.TabIndex = 7;
            this.CurrentScore.Text = "Score";
            // 
            // ScoreBoardView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.CurrentScore);
            this.Controls.Add(this.currenttextonly);
            this.Controls.Add(this.score4);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.score3);
            this.Controls.Add(this.score2);
            this.Controls.Add(this.score1);
            this.Name = "ScoreBoardView";
            this.Size = new System.Drawing.Size(402, 275);
            this.Load += new System.EventHandler(this.ScoreBoardView_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label score1;
        private System.Windows.Forms.Label score2;
        private System.Windows.Forms.Label score3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label score4;
        private System.Windows.Forms.Label currenttextonly;
        private System.Windows.Forms.Label CurrentScore;
    }
}
