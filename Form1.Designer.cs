namespace WindowsFormsApplication1
{
    partial class Form1
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
            this.btnOpenFStorage = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnOpenFStorage
            // 
            this.btnOpenFStorage.Location = new System.Drawing.Point(12, 12);
            this.btnOpenFStorage.Name = "btnOpenFStorage";
            this.btnOpenFStorage.Size = new System.Drawing.Size(133, 23);
            this.btnOpenFStorage.TabIndex = 0;
            this.btnOpenFStorage.Text = "Open Storage Form";
            this.btnOpenFStorage.UseVisualStyleBackColor = true;
            this.btnOpenFStorage.Click += new System.EventHandler(this.btnOpenFStorage_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(386, 132);
            this.Controls.Add(this.btnOpenFStorage);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnOpenFStorage;
    }
}

