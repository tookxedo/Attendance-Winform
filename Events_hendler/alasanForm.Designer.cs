namespace Events_hendler
{
    partial class alasanForm
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
            this.alasanText = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.kirimBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // alasanText
            // 
            this.alasanText.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.alasanText.Location = new System.Drawing.Point(49, 98);
            this.alasanText.Multiline = true;
            this.alasanText.Name = "alasanText";
            this.alasanText.Size = new System.Drawing.Size(505, 279);
            this.alasanText.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(43, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 35);
            this.label1.TabIndex = 1;
            this.label1.Text = "Alasan";
            // 
            // kirimBtn
            // 
            this.kirimBtn.Location = new System.Drawing.Point(359, 399);
            this.kirimBtn.Name = "kirimBtn";
            this.kirimBtn.Size = new System.Drawing.Size(195, 41);
            this.kirimBtn.TabIndex = 2;
            this.kirimBtn.Text = "Kirim";
            this.kirimBtn.UseVisualStyleBackColor = true;
            this.kirimBtn.Click += new System.EventHandler(this.kirimBtn_Click);
            // 
            // alasanForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(609, 452);
            this.Controls.Add(this.kirimBtn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.alasanText);
            this.Name = "alasanForm";
            this.Text = "alasanForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox alasanText;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button kirimBtn;
    }
}