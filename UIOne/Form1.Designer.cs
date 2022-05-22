namespace UIOne
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dtl_DataListesi = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // dtl_DataListesi
            // 
            this.dtl_DataListesi.FormattingEnabled = true;
            this.dtl_DataListesi.ItemHeight = 25;
            this.dtl_DataListesi.Location = new System.Drawing.Point(12, 18);
            this.dtl_DataListesi.Name = "dtl_DataListesi";
            this.dtl_DataListesi.Size = new System.Drawing.Size(632, 579);
            this.dtl_DataListesi.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(657, 610);
            this.Controls.Add(this.dtl_DataListesi);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private ListBox dtl_DataListesi;
    }
}