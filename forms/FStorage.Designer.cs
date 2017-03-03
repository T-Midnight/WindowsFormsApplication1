namespace WindowsFormsApplication1.forms
{
    partial class FStorage
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
            this.btnConnect = new System.Windows.Forms.Button();
            this.tbLog = new System.Windows.Forms.TextBox();
            this.tbDateReceipt = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnCreateTable = new System.Windows.Forms.Button();
            this.btnInsert = new System.Windows.Forms.Button();
            this.btnClean = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnAllData = new System.Windows.Forms.Button();
            this.nudQuantity = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudQuantity)).BeginInit();
            this.SuspendLayout();
            // 
            // btnConnect
            // 
            this.btnConnect.Location = new System.Drawing.Point(496, 352);
            this.btnConnect.Name = "btnConnect";
            this.btnConnect.Size = new System.Drawing.Size(88, 23);
            this.btnConnect.TabIndex = 0;
            this.btnConnect.Text = "Connect";
            this.btnConnect.UseVisualStyleBackColor = true;
            this.btnConnect.Click += new System.EventHandler(this.btnConnect_Click);
            // 
            // tbLog
            // 
            this.tbLog.Location = new System.Drawing.Point(12, 352);
            this.tbLog.Multiline = true;
            this.tbLog.Name = "tbLog";
            this.tbLog.Size = new System.Drawing.Size(478, 96);
            this.tbLog.TabIndex = 1;
            // 
            // tbDateReceipt
            // 
            this.tbDateReceipt.Location = new System.Drawing.Point(286, 471);
            this.tbDateReceipt.Name = "tbDateReceipt";
            this.tbDateReceipt.Size = new System.Drawing.Size(100, 20);
            this.tbDateReceipt.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(283, 451);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "date receipt";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(389, 451);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "quantity";
            // 
            // btnCreateTable
            // 
            this.btnCreateTable.Location = new System.Drawing.Point(496, 381);
            this.btnCreateTable.Name = "btnCreateTable";
            this.btnCreateTable.Size = new System.Drawing.Size(88, 23);
            this.btnCreateTable.TabIndex = 6;
            this.btnCreateTable.Text = "Create Table";
            this.btnCreateTable.UseVisualStyleBackColor = true;
            this.btnCreateTable.Click += new System.EventHandler(this.btnCreateTable_Click);
            // 
            // btnInsert
            // 
            this.btnInsert.Location = new System.Drawing.Point(496, 468);
            this.btnInsert.Name = "btnInsert";
            this.btnInsert.Size = new System.Drawing.Size(88, 23);
            this.btnInsert.TabIndex = 7;
            this.btnInsert.Text = "Insert";
            this.btnInsert.UseVisualStyleBackColor = true;
            this.btnInsert.Click += new System.EventHandler(this.btnInsert_Click);
            // 
            // btnClean
            // 
            this.btnClean.Location = new System.Drawing.Point(496, 410);
            this.btnClean.Name = "btnClean";
            this.btnClean.Size = new System.Drawing.Size(88, 23);
            this.btnClean.TabIndex = 8;
            this.btnClean.Text = "Clean Table";
            this.btnClean.UseVisualStyleBackColor = true;
            this.btnClean.Click += new System.EventHandler(this.btnClean_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(572, 334);
            this.dataGridView1.TabIndex = 9;
            // 
            // btnAllData
            // 
            this.btnAllData.Location = new System.Drawing.Point(496, 439);
            this.btnAllData.Name = "btnAllData";
            this.btnAllData.Size = new System.Drawing.Size(88, 23);
            this.btnAllData.TabIndex = 10;
            this.btnAllData.Text = "All Data";
            this.btnAllData.UseVisualStyleBackColor = true;
            this.btnAllData.Click += new System.EventHandler(this.btnAllData_Click);
            // 
            // nudQuantity
            // 
            this.nudQuantity.Location = new System.Drawing.Point(392, 471);
            this.nudQuantity.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.nudQuantity.Name = "nudQuantity";
            this.nudQuantity.Size = new System.Drawing.Size(98, 20);
            this.nudQuantity.TabIndex = 11;
            // 
            // FStorage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(596, 501);
            this.Controls.Add(this.nudQuantity);
            this.Controls.Add(this.btnAllData);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnClean);
            this.Controls.Add(this.btnInsert);
            this.Controls.Add(this.btnCreateTable);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbDateReceipt);
            this.Controls.Add(this.tbLog);
            this.Controls.Add(this.btnConnect);
            this.Name = "FStorage";
            this.Text = "FStorage";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudQuantity)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnConnect;
        private System.Windows.Forms.TextBox tbLog;
        private System.Windows.Forms.TextBox tbDateReceipt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnCreateTable;
        private System.Windows.Forms.Button btnInsert;
        private System.Windows.Forms.Button btnClean;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnAllData;
        private System.Windows.Forms.NumericUpDown nudQuantity;
    }
}