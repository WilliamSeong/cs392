namespace LatinTranslator
{
    partial class form1
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
            this.upButton = new System.Windows.Forms.Button();
            this.downButton = new System.Windows.Forms.Button();
            this.centerButton = new System.Windows.Forms.Button();
            this.latinLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // upButton
            // 
            this.upButton.Location = new System.Drawing.Point(174, 104);
            this.upButton.Name = "upButton";
            this.upButton.Size = new System.Drawing.Size(75, 32);
            this.upButton.TabIndex = 0;
            this.upButton.Text = "autem";
            this.upButton.UseVisualStyleBackColor = true;
            this.upButton.Click += new System.EventHandler(this.upButton_Click);
            // 
            // downButton
            // 
            this.downButton.Location = new System.Drawing.Point(255, 104);
            this.downButton.Name = "downButton";
            this.downButton.Size = new System.Drawing.Size(75, 32);
            this.downButton.TabIndex = 1;
            this.downButton.Text = "descendit";
            this.downButton.UseVisualStyleBackColor = true;
            this.downButton.Click += new System.EventHandler(this.downButton_Click);
            // 
            // centerButton
            // 
            this.centerButton.Location = new System.Drawing.Point(336, 104);
            this.centerButton.Name = "centerButton";
            this.centerButton.Size = new System.Drawing.Size(75, 32);
            this.centerButton.TabIndex = 2;
            this.centerButton.Text = "medium";
            this.centerButton.UseVisualStyleBackColor = true;
            this.centerButton.Click += new System.EventHandler(this.centerButton_Click);
            // 
            // latinLabel
            // 
            this.latinLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.latinLabel.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.latinLabel.Location = new System.Drawing.Point(171, 148);
            this.latinLabel.Name = "latinLabel";
            this.latinLabel.Size = new System.Drawing.Size(240, 55);
            this.latinLabel.TabIndex = 3;
            this.latinLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(191, 74);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(205, 17);
            this.label1.TabIndex = 4;
            this.label1.Text = "What are these words in English?";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 261);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.latinLabel);
            this.Controls.Add(this.centerButton);
            this.Controls.Add(this.downButton);
            this.Controls.Add(this.upButton);
            this.Name = "form1";
            this.Text = "Latin Translator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button upButton;
        private System.Windows.Forms.Button downButton;
        private System.Windows.Forms.Button centerButton;
        private System.Windows.Forms.Label latinLabel;
        private System.Windows.Forms.Label label1;
    }
}

