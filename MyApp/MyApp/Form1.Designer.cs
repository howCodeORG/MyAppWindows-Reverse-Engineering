namespace MyApp
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
            this.statusLabel = new System.Windows.Forms.Label();
            this.unlockBox = new System.Windows.Forms.TextBox();
            this.unlockButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // statusLabel
            // 
            this.statusLabel.AutoSize = true;
            this.statusLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.statusLabel.Location = new System.Drawing.Point(327, 111);
            this.statusLabel.Name = "statusLabel";
            this.statusLabel.Size = new System.Drawing.Size(61, 20);
            this.statusLabel.TabIndex = 0;
            this.statusLabel.Text = "Locked";
            // 
            // unlockBox
            // 
            this.unlockBox.Location = new System.Drawing.Point(180, 150);
            this.unlockBox.Name = "unlockBox";
            this.unlockBox.Size = new System.Drawing.Size(352, 20);
            this.unlockBox.TabIndex = 1;
            // 
            // unlockButton
            // 
            this.unlockButton.Location = new System.Drawing.Point(311, 188);
            this.unlockButton.Name = "unlockButton";
            this.unlockButton.Size = new System.Drawing.Size(88, 23);
            this.unlockButton.TabIndex = 2;
            this.unlockButton.Text = "Unlock";
            this.unlockButton.UseVisualStyleBackColor = true;
            this.unlockButton.Click += new System.EventHandler(this.unlockButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(728, 353);
            this.Controls.Add(this.unlockButton);
            this.Controls.Add(this.unlockBox);
            this.Controls.Add(this.statusLabel);
            this.Name = "Form1";
            this.Text = "My App";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label statusLabel;
        private System.Windows.Forms.TextBox unlockBox;
        private System.Windows.Forms.Button unlockButton;
    }
}

