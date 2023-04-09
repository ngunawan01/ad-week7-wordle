namespace ad_sem2_week7_tha_winsform
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
            this.labelWordle = new System.Windows.Forms.Label();
            this.textBoxGuess = new System.Windows.Forms.TextBox();
            this.buttonPlay = new System.Windows.Forms.Button();
            this.labelSet = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelWordle
            // 
            this.labelWordle.AutoSize = true;
            this.labelWordle.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelWordle.Location = new System.Drawing.Point(194, 66);
            this.labelWordle.Name = "labelWordle";
            this.labelWordle.Size = new System.Drawing.Size(396, 91);
            this.labelWordle.TabIndex = 0;
            this.labelWordle.Text = "WORDLE";
            // 
            // textBoxGuess
            // 
            this.textBoxGuess.Location = new System.Drawing.Point(228, 215);
            this.textBoxGuess.Name = "textBoxGuess";
            this.textBoxGuess.Size = new System.Drawing.Size(309, 22);
            this.textBoxGuess.TabIndex = 1;
            this.textBoxGuess.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_keyPress);
            // 
            // buttonPlay
            // 
            this.buttonPlay.Location = new System.Drawing.Point(228, 258);
            this.buttonPlay.Name = "buttonPlay";
            this.buttonPlay.Size = new System.Drawing.Size(309, 95);
            this.buttonPlay.TabIndex = 2;
            this.buttonPlay.Text = "PLAY!";
            this.buttonPlay.UseVisualStyleBackColor = true;
            this.buttonPlay.Click += new System.EventHandler(this.buttonPlay_Click);
            // 
            // labelSet
            // 
            this.labelSet.AutoSize = true;
            this.labelSet.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSet.Location = new System.Drawing.Point(132, 157);
            this.labelSet.Name = "labelSet";
            this.labelSet.Size = new System.Drawing.Size(542, 36);
            this.labelSet.TabIndex = 3;
            this.labelSet.Text = "SET HOW MUCH YOU CAN GUESS!";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.labelSet);
            this.Controls.Add(this.buttonPlay);
            this.Controls.Add(this.textBoxGuess);
            this.Controls.Add(this.labelWordle);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelWordle;
        private System.Windows.Forms.TextBox textBoxGuess;
        private System.Windows.Forms.Button buttonPlay;
        private System.Windows.Forms.Label labelSet;
    }
}

