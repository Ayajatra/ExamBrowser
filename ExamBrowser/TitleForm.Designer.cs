namespace ExamBrowser
{
    partial class TitleForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.btnMulai = new System.Windows.Forms.Button();
            this.btnInformasi = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(125, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(224, 37);
            this.label1.TabIndex = 0;
            this.label1.Text = "Exam Browser";
            // 
            // btnMulai
            // 
            this.btnMulai.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMulai.Location = new System.Drawing.Point(67, 173);
            this.btnMulai.Name = "btnMulai";
            this.btnMulai.Size = new System.Drawing.Size(338, 58);
            this.btnMulai.TabIndex = 1;
            this.btnMulai.Text = "Mulai";
            this.btnMulai.UseVisualStyleBackColor = true;
            this.btnMulai.Click += new System.EventHandler(this.BtnMulai_Click);
            // 
            // btnInformasi
            // 
            this.btnInformasi.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInformasi.Location = new System.Drawing.Point(67, 237);
            this.btnInformasi.Name = "btnInformasi";
            this.btnInformasi.Size = new System.Drawing.Size(338, 58);
            this.btnInformasi.TabIndex = 1;
            this.btnInformasi.Text = "Informasi";
            this.btnInformasi.UseVisualStyleBackColor = true;
            this.btnInformasi.Click += new System.EventHandler(this.BtnInformasi_Click);
            // 
            // TitleForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(479, 342);
            this.Controls.Add(this.btnInformasi);
            this.Controls.Add(this.btnMulai);
            this.Controls.Add(this.label1);
            this.Name = "TitleForm";
            this.Text = "TitleForm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.TitleForm_FormClosing);
            this.Load += new System.EventHandler(this.TitleForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnMulai;
        private System.Windows.Forms.Button btnInformasi;
    }
}