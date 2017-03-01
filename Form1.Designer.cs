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
            this.btnOpenFProduct = new System.Windows.Forms.Button();
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
            // btnOpenFProduct
            // 
            this.btnOpenFProduct.Location = new System.Drawing.Point(12, 41);
            this.btnOpenFProduct.Name = "btnOpenFProduct";
            this.btnOpenFProduct.Size = new System.Drawing.Size(133, 23);
            this.btnOpenFProduct.TabIndex = 1;
            this.btnOpenFProduct.Text = "Open Product Form";
            this.btnOpenFProduct.UseVisualStyleBackColor = true;
            this.btnOpenFProduct.Click += new System.EventHandler(this.btnOpenFProduct_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(386, 132);
            this.Controls.Add(this.btnOpenFProduct);
            this.Controls.Add(this.btnOpenFStorage);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnOpenFStorage;
        private System.Windows.Forms.Button btnOpenFProduct;
    }
}

