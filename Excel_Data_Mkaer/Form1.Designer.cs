namespace Excel_Data_Mkaer
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
            if(disposing && (components != null))
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
            this.filePathTxt = new System.Windows.Forms.TextBox();
            this.dataGridDocx = new System.Windows.Forms.DataGridView();
            this.classicBtn = new System.Windows.Forms.Button();
            this.removeFileNameBtn = new System.Windows.Forms.Button();
            this.saleInvoiceBtn = new System.Windows.Forms.Button();
            this.ReceiptBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridDocx)).BeginInit();
            this.SuspendLayout();
            // 
            // filePathTxt
            // 
            this.filePathTxt.Location = new System.Drawing.Point(82, 24);
            this.filePathTxt.Name = "filePathTxt";
            this.filePathTxt.ReadOnly = true;
            this.filePathTxt.Size = new System.Drawing.Size(454, 20);
            this.filePathTxt.TabIndex = 1;
            // 
            // dataGridDocx
            // 
            this.dataGridDocx.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridDocx.Location = new System.Drawing.Point(12, 147);
            this.dataGridDocx.Name = "dataGridDocx";
            this.dataGridDocx.Size = new System.Drawing.Size(633, 291);
            this.dataGridDocx.TabIndex = 2;
            // 
            // classicBtn
            // 
            this.classicBtn.Location = new System.Drawing.Point(542, 21);
            this.classicBtn.Name = "classicBtn";
            this.classicBtn.Size = new System.Drawing.Size(103, 23);
            this.classicBtn.TabIndex = 3;
            this.classicBtn.Text = "Load document";
            this.classicBtn.UseVisualStyleBackColor = true;
            this.classicBtn.Click += new System.EventHandler(this.classicBtn_Click);
            // 
            // removeFileNameBtn
            // 
            this.removeFileNameBtn.Location = new System.Drawing.Point(7, 24);
            this.removeFileNameBtn.Name = "removeFileNameBtn";
            this.removeFileNameBtn.Size = new System.Drawing.Size(66, 23);
            this.removeFileNameBtn.TabIndex = 4;
            this.removeFileNameBtn.Text = "Remove";
            this.removeFileNameBtn.UseVisualStyleBackColor = true;
            this.removeFileNameBtn.Click += new System.EventHandler(this.removeFileNameBtn_Click);
            // 
            // saleInvoiceBtn
            // 
            this.saleInvoiceBtn.Location = new System.Drawing.Point(542, 50);
            this.saleInvoiceBtn.Name = "saleInvoiceBtn";
            this.saleInvoiceBtn.Size = new System.Drawing.Size(103, 34);
            this.saleInvoiceBtn.TabIndex = 5;
            this.saleInvoiceBtn.Text = "Create sale invoice";
            this.saleInvoiceBtn.UseVisualStyleBackColor = true;
            this.saleInvoiceBtn.Click += new System.EventHandler(this.saleInvoiceBtn_Click);
            // 
            // ReceiptBtn
            // 
            this.ReceiptBtn.Location = new System.Drawing.Point(542, 90);
            this.ReceiptBtn.Name = "ReceiptBtn";
            this.ReceiptBtn.Size = new System.Drawing.Size(103, 34);
            this.ReceiptBtn.TabIndex = 6;
            this.ReceiptBtn.Text = "Create Receipt";
            this.ReceiptBtn.UseVisualStyleBackColor = true;
            this.ReceiptBtn.Click += new System.EventHandler(this.ReceiptBtn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(675, 450);
            this.Controls.Add(this.ReceiptBtn);
            this.Controls.Add(this.saleInvoiceBtn);
            this.Controls.Add(this.removeFileNameBtn);
            this.Controls.Add(this.classicBtn);
            this.Controls.Add(this.dataGridDocx);
            this.Controls.Add(this.filePathTxt);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridDocx)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox filePathTxt;
        private System.Windows.Forms.DataGridView dataGridDocx;
        private System.Windows.Forms.Button classicBtn;
        private System.Windows.Forms.Button removeFileNameBtn;
        private System.Windows.Forms.Button saleInvoiceBtn;
        private System.Windows.Forms.Button ReceiptBtn;
    }
}

