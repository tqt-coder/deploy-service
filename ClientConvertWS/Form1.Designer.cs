﻿namespace ClientConvertWS
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
            this.txtFi = new System.Windows.Forms.TextBox();
            this.txtLa = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtFi
            // 
            this.txtFi.Location = new System.Drawing.Point(328, 81);
            this.txtFi.Name = "txtFi";
            this.txtFi.Size = new System.Drawing.Size(176, 27);
            this.txtFi.TabIndex = 0;
            // 
            // txtLa
            // 
            this.txtLa.Location = new System.Drawing.Point(381, 261);
            this.txtLa.Name = "txtLa";
            this.txtLa.Size = new System.Drawing.Size(267, 27);
            this.txtLa.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(431, 173);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(94, 29);
            this.button1.TabIndex = 2;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtLa);
            this.Controls.Add(this.txtFi);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox txtFi;
        private TextBox txtLa;
        private Button button1;
    }
}