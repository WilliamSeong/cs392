namespace JokeAndPunchLine
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
            this.setupButton = new System.Windows.Forms.Button();
            this.punchLineButton = new System.Windows.Forms.Button();
            this.setupLabel = new System.Windows.Forms.Label();
            this.punchLineLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // setupButton
            // 
            this.setupButton.Location = new System.Drawing.Point(315, 113);
            this.setupButton.Name = "setupButton";
            this.setupButton.Size = new System.Drawing.Size(75, 23);
            this.setupButton.TabIndex = 0;
            this.setupButton.Text = "Setup";
            this.setupButton.UseVisualStyleBackColor = true;
            this.setupButton.Click += new System.EventHandler(this.setupButton_Click);
            // 
            // punchLineButton
            // 
            this.punchLineButton.Location = new System.Drawing.Point(396, 113);
            this.punchLineButton.Name = "punchLineButton";
            this.punchLineButton.Size = new System.Drawing.Size(75, 23);
            this.punchLineButton.TabIndex = 1;
            this.punchLineButton.Text = "Punch line";
            this.punchLineButton.UseVisualStyleBackColor = true;
            this.punchLineButton.Click += new System.EventHandler(this.punchLineButton_Click);
            // 
            // setupLabel
            // 
            this.setupLabel.AutoSize = true;
            this.setupLabel.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.setupLabel.Location = new System.Drawing.Point(178, 155);
            this.setupLabel.Name = "setupLabel";
            this.setupLabel.Size = new System.Drawing.Size(0, 19);
            this.setupLabel.TabIndex = 2;
            // 
            // punchLineLabel
            // 
            this.punchLineLabel.AutoSize = true;
            this.punchLineLabel.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.punchLineLabel.Location = new System.Drawing.Point(221, 219);
            this.punchLineLabel.Name = "punchLineLabel";
            this.punchLineLabel.Size = new System.Drawing.Size(0, 23);
            this.punchLineLabel.TabIndex = 3;
            this.punchLineLabel.Click += new System.EventHandler(this.punchLineLabel_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(789, 363);
            this.Controls.Add(this.punchLineLabel);
            this.Controls.Add(this.setupLabel);
            this.Controls.Add(this.punchLineButton);
            this.Controls.Add(this.setupButton);
            this.Name = "Form1";
            this.Text = "Joke";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button setupButton;
        private System.Windows.Forms.Button punchLineButton;
        private System.Windows.Forms.Label setupLabel;
        private System.Windows.Forms.Label punchLineLabel;
    }
}

