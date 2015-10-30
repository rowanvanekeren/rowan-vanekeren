namespace YatzeeTeerling
{
    partial class TeerlingVieuw
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
            this.teerlingLabel = new System.Windows.Forms.Label();
            this.werpButton = new System.Windows.Forms.Button();
            this.Vastzetten = new System.Windows.Forms.Button();
            this.Reset = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // teerlingLabel
            // 
            this.teerlingLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.teerlingLabel.Location = new System.Drawing.Point(19, 16);
            this.teerlingLabel.Name = "teerlingLabel";
            this.teerlingLabel.Size = new System.Drawing.Size(105, 105);
            this.teerlingLabel.TabIndex = 0;
            this.teerlingLabel.Text = "label1";
            this.teerlingLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.teerlingLabel.Click += new System.EventHandler(this.teerlingLabel_Click);
            // 
            // werpButton
            // 
            this.werpButton.Location = new System.Drawing.Point(34, 124);
            this.werpButton.Name = "werpButton";
            this.werpButton.Size = new System.Drawing.Size(75, 23);
            this.werpButton.TabIndex = 1;
            this.werpButton.Text = "Werp";
            this.werpButton.UseVisualStyleBackColor = true;
            this.werpButton.Click += new System.EventHandler(this.werpButton_Click);
            // 
            // Vastzetten
            // 
            this.Vastzetten.Location = new System.Drawing.Point(19, 167);
            this.Vastzetten.Name = "Vastzetten";
            this.Vastzetten.Size = new System.Drawing.Size(105, 23);
            this.Vastzetten.TabIndex = 2;
            this.Vastzetten.Text = "Vastzetten";
            this.Vastzetten.UseVisualStyleBackColor = true;
            this.Vastzetten.Click += new System.EventHandler(this.Vastzetten_Click);
            // 
            // Reset
            // 
            this.Reset.Location = new System.Drawing.Point(34, 196);
            this.Reset.Name = "Reset";
            this.Reset.Size = new System.Drawing.Size(75, 23);
            this.Reset.TabIndex = 3;
            this.Reset.Text = "Reset";
            this.Reset.UseVisualStyleBackColor = true;
            this.Reset.Visible = false;
            this.Reset.Click += new System.EventHandler(this.Reset_Click);
            // 
            // TeerlingVieuw
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.Reset);
            this.Controls.Add(this.Vastzetten);
            this.Controls.Add(this.werpButton);
            this.Controls.Add(this.teerlingLabel);
            this.Name = "TeerlingVieuw";
            this.Size = new System.Drawing.Size(150, 241);
            this.Load += new System.EventHandler(this.TeerlingVieuw_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label teerlingLabel;
        private System.Windows.Forms.Button werpButton;
        private System.Windows.Forms.Button Vastzetten;
        private System.Windows.Forms.Button Reset;
    }
}
