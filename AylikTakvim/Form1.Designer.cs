﻿namespace AylikTakvim
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
            this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
            this.btnGoster = new System.Windows.Forms.Button();
            this.btnListele = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // monthCalendar1
            // 
            this.monthCalendar1.Location = new System.Drawing.Point(4, 3);
            this.monthCalendar1.MaxSelectionCount = 31;
            this.monthCalendar1.Name = "monthCalendar1";
            this.monthCalendar1.TabIndex = 0;
            // 
            // btnGoster
            // 
            this.btnGoster.Location = new System.Drawing.Point(4, 177);
            this.btnGoster.Name = "btnGoster";
            this.btnGoster.Size = new System.Drawing.Size(105, 28);
            this.btnGoster.TabIndex = 1;
            this.btnGoster.Text = "Seçili Tarih Sayısı";
            this.btnGoster.UseVisualStyleBackColor = true;
            this.btnGoster.Click += new System.EventHandler(this.BtnGoster_Click);
            // 
            // btnListele
            // 
            this.btnListele.Location = new System.Drawing.Point(125, 177);
            this.btnListele.Name = "btnListele";
            this.btnListele.Size = new System.Drawing.Size(113, 28);
            this.btnListele.TabIndex = 2;
            this.btnListele.Text = "Seçili Tarihleri Listele";
            this.btnListele.UseVisualStyleBackColor = true;
            this.btnListele.Click += new System.EventHandler(this.BtnListele_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(243, 214);
            this.Controls.Add(this.btnListele);
            this.Controls.Add(this.btnGoster);
            this.Controls.Add(this.monthCalendar1);
            this.Name = "Form1";
            this.Text = "Aylık Takvim";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.MonthCalendar monthCalendar1;
        private System.Windows.Forms.Button btnGoster;
        private System.Windows.Forms.Button btnListele;
    }
}

