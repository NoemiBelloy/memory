namespace memory
{
    partial class kaartView
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
            this.memoryKaart = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // memoryKaart
            // 
            this.memoryKaart.AutoSize = true;
            this.memoryKaart.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.memoryKaart.Location = new System.Drawing.Point(43, 46);
            this.memoryKaart.MaximumSize = new System.Drawing.Size(2000, 2000);
            this.memoryKaart.Name = "memoryKaart";
            this.memoryKaart.Padding = new System.Windows.Forms.Padding(10);
            this.memoryKaart.Size = new System.Drawing.Size(58, 39);
            this.memoryKaart.TabIndex = 0;
            this.memoryKaart.Text = "afb1";
            this.memoryKaart.Click += new System.EventHandler(this.label1_Click);
            // 
            // kaartView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.memoryKaart);
            this.Name = "kaartView";
            this.Size = new System.Drawing.Size(194, 181);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label memoryKaart;
    }
}
