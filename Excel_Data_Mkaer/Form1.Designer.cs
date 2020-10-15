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
            this.chooseDocxBtn = new System.Windows.Forms.Button();
            this.filePathTxt = new System.Windows.Forms.TextBox();
            this.dataGridDocx = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridDocx)).BeginInit();
            this.SuspendLayout();
            // 
            // chooseDocxBtn
            // 
            this.chooseDocxBtn.Location = new System.Drawing.Point(499, 69);
            this.chooseDocxBtn.Name = "chooseDocxBtn";
            this.chooseDocxBtn.Size = new System.Drawing.Size(75, 23);
            this.chooseDocxBtn.TabIndex = 0;
            this.chooseDocxBtn.Text = "...";
            this.chooseDocxBtn.UseVisualStyleBackColor = true;
            this.chooseDocxBtn.Click += new System.EventHandler(this.chooseDocxBtn_Click);
            // 
            // filePathTxt
            // 
            this.filePathTxt.Location = new System.Drawing.Point(78, 69);
            this.filePathTxt.Name = "filePathTxt";
            this.filePathTxt.Size = new System.Drawing.Size(394, 20);
            this.filePathTxt.TabIndex = 1;
            // 
            // dataGridDocx
            // 
            this.dataGridDocx.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridDocx.Location = new System.Drawing.Point(12, 110);
            this.dataGridDocx.Name = "dataGridDocx";
            this.dataGridDocx.Size = new System.Drawing.Size(633, 291);
            this.dataGridDocx.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(675, 450);
            this.Controls.Add(this.dataGridDocx);
            this.Controls.Add(this.filePathTxt);
            this.Controls.Add(this.chooseDocxBtn);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridDocx)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button chooseDocxBtn;
        private System.Windows.Forms.TextBox filePathTxt;
        private System.Windows.Forms.DataGridView dataGridDocx;
    }
}

