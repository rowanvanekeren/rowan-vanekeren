namespace lemonade
{
    partial class Market
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
            this.pnlMarket = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // pnlMarket
            // 
            this.pnlMarket.Location = new System.Drawing.Point(12, 12);
            this.pnlMarket.Name = "pnlMarket";
            this.pnlMarket.Size = new System.Drawing.Size(416, 419);
            this.pnlMarket.TabIndex = 0;
            this.pnlMarket.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlMarket_Paint);
            // 
            // Market
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(440, 443);
            this.Controls.Add(this.pnlMarket);
            this.Name = "Market";
            this.Text = "Market";
            this.Load += new System.EventHandler(this.Market_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlMarket;

    }
}