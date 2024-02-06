namespace BMICalculator
{
    partial class bmiCalculator
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
            this.heightLabel = new System.Windows.Forms.Label();
            this.weightLabel = new System.Windows.Forms.Label();
            this.feetLabel = new System.Windows.Forms.Label();
            this.inchesLabel = new System.Windows.Forms.Label();
            this.feetText = new System.Windows.Forms.TextBox();
            this.inchesText = new System.Windows.Forms.TextBox();
            this.poundsLabel = new System.Windows.Forms.Label();
            this.poundsText = new System.Windows.Forms.TextBox();
            this.calculateButton = new System.Windows.Forms.Button();
            this.englishLabel = new System.Windows.Forms.Label();
            this.metricLabel = new System.Windows.Forms.Label();
            this.formattingLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.titleLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // heightLabel
            // 
            this.heightLabel.AutoSize = true;
            this.heightLabel.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.heightLabel.Location = new System.Drawing.Point(10, 82);
            this.heightLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.heightLabel.Name = "heightLabel";
            this.heightLabel.Size = new System.Drawing.Size(58, 15);
            this.heightLabel.TabIndex = 0;
            this.heightLabel.Text = "1. Height:";
            // 
            // weightLabel
            // 
            this.weightLabel.AutoSize = true;
            this.weightLabel.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.weightLabel.Location = new System.Drawing.Point(10, 161);
            this.weightLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.weightLabel.Name = "weightLabel";
            this.weightLabel.Size = new System.Drawing.Size(61, 15);
            this.weightLabel.TabIndex = 1;
            this.weightLabel.Text = "2. Weight:";
            // 
            // feetLabel
            // 
            this.feetLabel.AutoSize = true;
            this.feetLabel.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.feetLabel.Location = new System.Drawing.Point(52, 103);
            this.feetLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.feetLabel.Name = "feetLabel";
            this.feetLabel.Size = new System.Drawing.Size(30, 15);
            this.feetLabel.TabIndex = 2;
            this.feetLabel.Text = "Feet";
            // 
            // inchesLabel
            // 
            this.inchesLabel.AutoSize = true;
            this.inchesLabel.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inchesLabel.Location = new System.Drawing.Point(138, 103);
            this.inchesLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.inchesLabel.Name = "inchesLabel";
            this.inchesLabel.Size = new System.Drawing.Size(43, 15);
            this.inchesLabel.TabIndex = 3;
            this.inchesLabel.Text = "Inches";
            // 
            // feetText
            // 
            this.feetText.Location = new System.Drawing.Point(56, 121);
            this.feetText.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.feetText.Name = "feetText";
            this.feetText.Size = new System.Drawing.Size(79, 22);
            this.feetText.TabIndex = 4;
            // 
            // inchesText
            // 
            this.inchesText.Location = new System.Drawing.Point(142, 121);
            this.inchesText.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.inchesText.Name = "inchesText";
            this.inchesText.Size = new System.Drawing.Size(79, 22);
            this.inchesText.TabIndex = 5;
            // 
            // poundsLabel
            // 
            this.poundsLabel.AutoSize = true;
            this.poundsLabel.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.poundsLabel.Location = new System.Drawing.Point(52, 188);
            this.poundsLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.poundsLabel.Name = "poundsLabel";
            this.poundsLabel.Size = new System.Drawing.Size(48, 15);
            this.poundsLabel.TabIndex = 6;
            this.poundsLabel.Text = "Pounds";
            // 
            // poundsText
            // 
            this.poundsText.Location = new System.Drawing.Point(56, 207);
            this.poundsText.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.poundsText.Name = "poundsText";
            this.poundsText.Size = new System.Drawing.Size(79, 22);
            this.poundsText.TabIndex = 7;
            // 
            // calculateButton
            // 
            this.calculateButton.BackColor = System.Drawing.Color.RoyalBlue;
            this.calculateButton.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.calculateButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.calculateButton.Location = new System.Drawing.Point(56, 256);
            this.calculateButton.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.calculateButton.Name = "calculateButton";
            this.calculateButton.Size = new System.Drawing.Size(92, 42);
            this.calculateButton.TabIndex = 8;
            this.calculateButton.Text = "Calculate";
            this.calculateButton.UseVisualStyleBackColor = false;
            this.calculateButton.Click += new System.EventHandler(this.calculateButton_Click);
            // 
            // englishLabel
            // 
            this.englishLabel.AutoSize = true;
            this.englishLabel.ForeColor = System.Drawing.Color.Blue;
            this.englishLabel.Location = new System.Drawing.Point(406, 44);
            this.englishLabel.Name = "englishLabel";
            this.englishLabel.Size = new System.Drawing.Size(47, 15);
            this.englishLabel.TabIndex = 9;
            this.englishLabel.Text = "English";
            this.englishLabel.Click += new System.EventHandler(this.englishLabel_Click);
            // 
            // metricLabel
            // 
            this.metricLabel.AutoSize = true;
            this.metricLabel.Location = new System.Drawing.Point(460, 44);
            this.metricLabel.Name = "metricLabel";
            this.metricLabel.Size = new System.Drawing.Size(42, 15);
            this.metricLabel.TabIndex = 10;
            this.metricLabel.Text = "Metric";
            this.metricLabel.Click += new System.EventHandler(this.metricLabel_Click);
            // 
            // formattingLabel
            // 
            this.formattingLabel.AutoSize = true;
            this.formattingLabel.Location = new System.Drawing.Point(453, 44);
            this.formattingLabel.Name = "formattingLabel";
            this.formattingLabel.Size = new System.Drawing.Size(9, 15);
            this.formattingLabel.TabIndex = 11;
            this.formattingLabel.Text = "|";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(399, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(11, 15);
            this.label1.TabIndex = 12;
            this.label1.Text = "(";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(499, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(11, 15);
            this.label2.TabIndex = 13;
            this.label2.Text = ")";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // titleLabel
            // 
            this.titleLabel.BackColor = System.Drawing.Color.RoyalBlue;
            this.titleLabel.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleLabel.ForeColor = System.Drawing.Color.White;
            this.titleLabel.Location = new System.Drawing.Point(0, 0);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(510, 37);
            this.titleLabel.TabIndex = 14;
            this.titleLabel.Text = "Adult BMI Calculator";
            this.titleLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.titleLabel.Click += new System.EventHandler(this.titleLabel_Click);
            // 
            // bmiCalculator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(518, 310);
            this.Controls.Add(this.titleLabel);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.formattingLabel);
            this.Controls.Add(this.metricLabel);
            this.Controls.Add(this.englishLabel);
            this.Controls.Add(this.calculateButton);
            this.Controls.Add(this.poundsText);
            this.Controls.Add(this.poundsLabel);
            this.Controls.Add(this.inchesText);
            this.Controls.Add(this.feetText);
            this.Controls.Add(this.inchesLabel);
            this.Controls.Add(this.feetLabel);
            this.Controls.Add(this.weightLabel);
            this.Controls.Add(this.heightLabel);
            this.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "bmiCalculator";
            this.Text = "Adult BMI Calculator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label heightLabel;
        private System.Windows.Forms.Label weightLabel;
        private System.Windows.Forms.Label feetLabel;
        private System.Windows.Forms.Label inchesLabel;
        private System.Windows.Forms.TextBox feetText;
        private System.Windows.Forms.TextBox inchesText;
        private System.Windows.Forms.Label poundsLabel;
        private System.Windows.Forms.TextBox poundsText;
        private System.Windows.Forms.Button calculateButton;
        private System.Windows.Forms.Label englishLabel;
        private System.Windows.Forms.Label metricLabel;
        private System.Windows.Forms.Label formattingLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label titleLabel;
    }
}

