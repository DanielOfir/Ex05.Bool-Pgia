﻿
namespace Ex05.Bool_Pgia
{
    partial class FormEntry
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
            this.ButtonNumOfChances = new System.Windows.Forms.Button();
            this.ButtonStart = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ButtonNumOfChances
            // 
            this.ButtonNumOfChances.Location = new System.Drawing.Point(12, 12);
            this.ButtonNumOfChances.Name = "ButtonNumOfChances";
            this.ButtonNumOfChances.Size = new System.Drawing.Size(249, 22);
            this.ButtonNumOfChances.TabIndex = 0;
            this.ButtonNumOfChances.Text = "Number of chances: 4";
            this.ButtonNumOfChances.UseVisualStyleBackColor = true;
            this.ButtonNumOfChances.Click += new System.EventHandler(this.ButtonNumOfChances_Click);
            // 
            // ButtonStart
            // 
            this.ButtonStart.Location = new System.Drawing.Point(186, 63);
            this.ButtonStart.Name = "ButtonStart";
            this.ButtonStart.Size = new System.Drawing.Size(75, 23);
            this.ButtonStart.TabIndex = 1;
            this.ButtonStart.Text = "Start";
            this.ButtonStart.UseVisualStyleBackColor = true;
            this.ButtonStart.Click += new System.EventHandler(this.ButtonStart_Click);
            // FormEntry
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(270, 98);
            this.CenterToScreen();
            this.Controls.Add(this.ButtonStart);
            this.Controls.Add(this.ButtonNumOfChances);
            this.Name = "FormEntry";
            this.Text = "Bool Pgia";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button ButtonNumOfChances;
        private System.Windows.Forms.Button ButtonStart;
    }
}