
namespace Ex05.Bool_Pgia
{
    partial class FormColorSelection
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
            this.ButtonColorPurple = new System.Windows.Forms.Button();
            this.ButtonColorRed = new System.Windows.Forms.Button();
            this.ButtonColorGreen = new System.Windows.Forms.Button();
            this.ButtonColorAqua = new System.Windows.Forms.Button();
            this.ButtonColorWhite = new System.Windows.Forms.Button();
            this.ButtonColorBrown = new System.Windows.Forms.Button();
            this.ButtonColorYellow = new System.Windows.Forms.Button();
            this.ButtonColorBlue = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ButtonColorPurple
            // 
            this.ButtonColorPurple.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.ButtonColorPurple.Location = new System.Drawing.Point(12, 12);
            this.ButtonColorPurple.Name = "ButtonColorPurple";
            this.ButtonColorPurple.Size = new System.Drawing.Size(40, 40);
            this.ButtonColorPurple.TabIndex = 1;
            this.ButtonColorPurple.UseVisualStyleBackColor = false;
            this.ButtonColorPurple.Click += new System.EventHandler(this.ButtonColor_Click);
            // 
            // ButtonColorRed
            // 
            this.ButtonColorRed.BackColor = System.Drawing.Color.Red;
            this.ButtonColorRed.Location = new System.Drawing.Point(58, 12);
            this.ButtonColorRed.Name = "ButtonColorRed";
            this.ButtonColorRed.Size = new System.Drawing.Size(40, 40);
            this.ButtonColorRed.TabIndex = 2;
            this.ButtonColorRed.UseVisualStyleBackColor = false;
            this.ButtonColorRed.Click += new System.EventHandler(this.ButtonColor_Click);
            // 
            // ButtonColorGreen
            // 
            this.ButtonColorGreen.BackColor = System.Drawing.Color.Lime;
            this.ButtonColorGreen.Location = new System.Drawing.Point(104, 12);
            this.ButtonColorGreen.Name = "ButtonColorGreen";
            this.ButtonColorGreen.Size = new System.Drawing.Size(40, 40);
            this.ButtonColorGreen.TabIndex = 3;
            this.ButtonColorGreen.UseVisualStyleBackColor = false;
            this.ButtonColorGreen.Click += new System.EventHandler(this.ButtonColor_Click);
            // 
            // ButtonColorAqua
            // 
            this.ButtonColorAqua.BackColor = System.Drawing.Color.Aqua;
            this.ButtonColorAqua.Location = new System.Drawing.Point(150, 12);
            this.ButtonColorAqua.Name = "ButtonColorAqua";
            this.ButtonColorAqua.Size = new System.Drawing.Size(40, 40);
            this.ButtonColorAqua.TabIndex = 4;
            this.ButtonColorAqua.UseVisualStyleBackColor = false;
            this.ButtonColorAqua.Click += new System.EventHandler(this.ButtonColor_Click);
            // 
            // ButtonColorWhite
            // 
            this.ButtonColorWhite.BackColor = System.Drawing.Color.White;
            this.ButtonColorWhite.Location = new System.Drawing.Point(150, 56);
            this.ButtonColorWhite.Name = "ButtonColorWhite";
            this.ButtonColorWhite.Size = new System.Drawing.Size(40, 40);
            this.ButtonColorWhite.TabIndex = 8;
            this.ButtonColorWhite.UseVisualStyleBackColor = false;
            this.ButtonColorWhite.Click += new System.EventHandler(this.ButtonColor_Click);
            // 
            // ButtonColorBrown
            // 
            this.ButtonColorBrown.BackColor = System.Drawing.Color.Maroon;
            this.ButtonColorBrown.Location = new System.Drawing.Point(104, 56);
            this.ButtonColorBrown.Name = "ButtonColorBrown";
            this.ButtonColorBrown.Size = new System.Drawing.Size(40, 40);
            this.ButtonColorBrown.TabIndex = 7;
            this.ButtonColorBrown.UseVisualStyleBackColor = false;
            this.ButtonColorBrown.Click += new System.EventHandler(this.ButtonColor_Click);
            // 
            // ButtonColorYellow
            // 
            this.ButtonColorYellow.BackColor = System.Drawing.Color.Yellow;
            this.ButtonColorYellow.Location = new System.Drawing.Point(58, 56);
            this.ButtonColorYellow.Name = "ButtonColorYellow";
            this.ButtonColorYellow.Size = new System.Drawing.Size(40, 40);
            this.ButtonColorYellow.TabIndex = 6;
            this.ButtonColorYellow.UseVisualStyleBackColor = false;
            this.ButtonColorYellow.Click += new System.EventHandler(this.ButtonColor_Click);
            // 
            // ButtonColorBlue
            // 
            this.ButtonColorBlue.BackColor = System.Drawing.Color.Blue;
            this.ButtonColorBlue.Location = new System.Drawing.Point(12, 56);
            this.ButtonColorBlue.Name = "ButtonColorBlue";
            this.ButtonColorBlue.Size = new System.Drawing.Size(40, 40);
            this.ButtonColorBlue.TabIndex = 5;
            this.ButtonColorBlue.UseVisualStyleBackColor = false;
            this.ButtonColorBlue.Click += new System.EventHandler(this.ButtonColor_Click);
            // 
            // FormColorSelection
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(201, 107);
            this.Controls.Add(this.ButtonColorWhite);
            this.Controls.Add(this.ButtonColorBrown);
            this.Controls.Add(this.ButtonColorYellow);
            this.Controls.Add(this.ButtonColorBlue);
            this.Controls.Add(this.ButtonColorAqua);
            this.Controls.Add(this.ButtonColorGreen);
            this.Controls.Add(this.ButtonColorRed);
            this.Controls.Add(this.ButtonColorPurple);
            this.Name = "FormColorSelection";
            this.Text = "Color Selection";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button ButtonColorPurple;
        private System.Windows.Forms.Button ButtonColorRed;
        private System.Windows.Forms.Button ButtonColorGreen;
        private System.Windows.Forms.Button ButtonColorAqua;
        private System.Windows.Forms.Button ButtonColorWhite;
        private System.Windows.Forms.Button ButtonColorBrown;
        private System.Windows.Forms.Button ButtonColorYellow;
        private System.Windows.Forms.Button ButtonColorBlue;
    }
}