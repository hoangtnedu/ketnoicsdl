﻿namespace ketnoicsdl
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
            this.lblThongbao = new System.Windows.Forms.Label();
            this.btnConnectbyWindows = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblThongbao
            // 
            this.lblThongbao.AutoSize = true;
            this.lblThongbao.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblThongbao.Location = new System.Drawing.Point(292, 119);
            this.lblThongbao.Name = "lblThongbao";
            this.lblThongbao.Size = new System.Drawing.Size(159, 36);
            this.lblThongbao.TabIndex = 0;
            this.lblThongbao.Text = "Thong bao";
            // 
            // btnConnectbyWindows
            // 
            this.btnConnectbyWindows.Location = new System.Drawing.Point(308, 227);
            this.btnConnectbyWindows.Name = "btnConnectbyWindows";
            this.btnConnectbyWindows.Size = new System.Drawing.Size(154, 60);
            this.btnConnectbyWindows.TabIndex = 1;
            this.btnConnectbyWindows.Text = "Ket noi bang windows";
            this.btnConnectbyWindows.UseVisualStyleBackColor = true;
            this.btnConnectbyWindows.Click += new System.EventHandler(this.btnConnectbyWindows_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnConnectbyWindows);
            this.Controls.Add(this.lblThongbao);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblThongbao;
        private System.Windows.Forms.Button btnConnectbyWindows;
    }
}
