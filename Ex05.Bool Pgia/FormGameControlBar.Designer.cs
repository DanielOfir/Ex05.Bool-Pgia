
using System.Windows.Forms;

namespace Ex05.Bool_Pgia
{
    partial class FormGameControlBar
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
            this.ButtonUserGuess1 = new System.Windows.Forms.Button();
            this.ButtonUserGuess2 = new System.Windows.Forms.Button();
            this.ButtonUserGuess3 = new System.Windows.Forms.Button();
            this.ButtonUserGuess4 = new System.Windows.Forms.Button();
            this.ButtonFinishUserGuess = new System.Windows.Forms.Button();
            this.ButtonUserResult1 = new System.Windows.Forms.Button();
            this.ButtonUserResult2 = new System.Windows.Forms.Button();
            this.ButtonUserResult3 = new System.Windows.Forms.Button();
            this.ButtonUserResult4 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ButtonUserGuess1
            // 
            this.ButtonUserGuess1.Location = new System.Drawing.Point(1, 1);
            this.ButtonUserGuess1.Name = "ButtonUserGuess1";
            this.ButtonUserGuess1.Size = new System.Drawing.Size(40, 40);
            this.ButtonUserGuess1.TabIndex = 0;
            this.ButtonUserGuess1.UseVisualStyleBackColor = true;
            this.ButtonUserGuess1.BackColorChanged += new System.EventHandler(this.ButtonUserGuess_OnBackColorChanged);
            this.ButtonUserGuess1.Click += new System.EventHandler(this.ButtonUserGuess_Click);
            // 
            // ButtonUserGuess2
            // 
            this.ButtonUserGuess2.Location = new System.Drawing.Point(47, 1);
            this.ButtonUserGuess2.Name = "ButtonUserGuess2";
            this.ButtonUserGuess2.Size = new System.Drawing.Size(40, 40);
            this.ButtonUserGuess2.TabIndex = 1;
            this.ButtonUserGuess2.UseVisualStyleBackColor = true;
            this.ButtonUserGuess2.BackColorChanged += new System.EventHandler(this.ButtonUserGuess_OnBackColorChanged);
            this.ButtonUserGuess2.Click += new System.EventHandler(this.ButtonUserGuess_Click);
            // 
            // ButtonUserGuess3
            // 
            this.ButtonUserGuess3.Location = new System.Drawing.Point(93, 1);
            this.ButtonUserGuess3.Name = "ButtonUserGuess3";
            this.ButtonUserGuess3.Size = new System.Drawing.Size(40, 40);
            this.ButtonUserGuess3.TabIndex = 2;
            this.ButtonUserGuess3.UseVisualStyleBackColor = true;
            this.ButtonUserGuess3.BackColorChanged += new System.EventHandler(this.ButtonUserGuess_OnBackColorChanged);
            this.ButtonUserGuess3.Click += new System.EventHandler(this.ButtonUserGuess_Click);
            // 
            // ButtonUserGuess4
            // 
            this.ButtonUserGuess4.Location = new System.Drawing.Point(139, 1);
            this.ButtonUserGuess4.Name = "ButtonUserGuess4";
            this.ButtonUserGuess4.Size = new System.Drawing.Size(40, 40);
            this.ButtonUserGuess4.TabIndex = 3;
            this.ButtonUserGuess4.UseVisualStyleBackColor = true;
            this.ButtonUserGuess4.BackColorChanged += new System.EventHandler(this.ButtonUserGuess_OnBackColorChanged);
            this.ButtonUserGuess4.Click += new System.EventHandler(this.ButtonUserGuess_Click);
            // 
            // ButtonFinishUserGuess
            // 
            this.ButtonFinishUserGuess.Enabled = false;
            this.ButtonFinishUserGuess.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonFinishUserGuess.Location = new System.Drawing.Point(185, 12);
            this.ButtonFinishUserGuess.Name = "ButtonFinishUserGuess";
            this.ButtonFinishUserGuess.Size = new System.Drawing.Size(40, 22);
            this.ButtonFinishUserGuess.TabIndex = 4;
            this.ButtonFinishUserGuess.Text = "-->>";
            this.ButtonFinishUserGuess.UseVisualStyleBackColor = true;
            this.ButtonFinishUserGuess.Click += new System.EventHandler(this.ButtonFinishUserGuess_Click);
            // 
            // ButtonUserResult1
            // 
            this.ButtonUserResult1.Enabled = false;
            this.ButtonUserResult1.Location = new System.Drawing.Point(231, 2);
            this.ButtonUserResult1.Name = "ButtonUserResult1";
            this.ButtonUserResult1.Size = new System.Drawing.Size(17, 17);
            this.ButtonUserResult1.TabIndex = 5;
            this.ButtonUserResult1.UseVisualStyleBackColor = true;
            // 
            // ButtonUserResult2
            // 
            this.ButtonUserResult2.Enabled = false;
            this.ButtonUserResult2.Location = new System.Drawing.Point(251, 2);
            this.ButtonUserResult2.Name = "ButtonUserResult2";
            this.ButtonUserResult2.Size = new System.Drawing.Size(17, 17);
            this.ButtonUserResult2.TabIndex = 6;
            this.ButtonUserResult2.UseVisualStyleBackColor = true;
            // 
            // ButtonUserResult3
            // 
            this.ButtonUserResult3.Enabled = false;
            this.ButtonUserResult3.Location = new System.Drawing.Point(231, 22);
            this.ButtonUserResult3.Name = "ButtonUserResult3";
            this.ButtonUserResult3.Size = new System.Drawing.Size(17, 17);
            this.ButtonUserResult3.TabIndex = 7;
            this.ButtonUserResult3.UseVisualStyleBackColor = true;
            // 
            // ButtonUserResult4
            // 
            this.ButtonUserResult4.Enabled = false;
            this.ButtonUserResult4.Location = new System.Drawing.Point(251, 22);
            this.ButtonUserResult4.Name = "ButtonUserResult4";
            this.ButtonUserResult4.Size = new System.Drawing.Size(17, 17);
            this.ButtonUserResult4.TabIndex = 8;
            this.ButtonUserResult4.UseVisualStyleBackColor = true;
            // 
            // FormGameControlBar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(270, 42);
            this.ControlBox = false;
            this.Controls.Add(this.ButtonUserResult4);
            this.Controls.Add(this.ButtonUserResult3);
            this.Controls.Add(this.ButtonUserResult2);
            this.Controls.Add(this.ButtonUserResult1);
            this.Controls.Add(this.ButtonFinishUserGuess);
            this.Controls.Add(this.ButtonUserGuess4);
            this.Controls.Add(this.ButtonUserGuess3);
            this.Controls.Add(this.ButtonUserGuess2);
            this.Controls.Add(this.ButtonUserGuess1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormGameControlBar";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button ButtonUserGuess1;
        private System.Windows.Forms.Button ButtonUserGuess2;
        private System.Windows.Forms.Button ButtonUserGuess3;
        private System.Windows.Forms.Button ButtonUserGuess4;
        private System.Windows.Forms.Button ButtonFinishUserGuess;
        private System.Windows.Forms.Button ButtonUserResult1;
        private System.Windows.Forms.Button ButtonUserResult2;
        private System.Windows.Forms.Button ButtonUserResult3;
        private System.Windows.Forms.Button ButtonUserResult4;
    }
}