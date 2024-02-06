namespace HeadOrTail
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
            this.headsButton = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.tailsImage = new System.Windows.Forms.PictureBox();
            this.headsImage = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.tailsImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.headsImage)).BeginInit();
            this.SuspendLayout();
            // 
            // headsButton
            // 
            this.headsButton.Location = new System.Drawing.Point(6, 145);
            this.headsButton.Name = "headsButton";
            this.headsButton.Size = new System.Drawing.Size(81, 37);
            this.headsButton.TabIndex = 0;
            this.headsButton.Text = "Show Heads";
            this.headsButton.UseVisualStyleBackColor = true;
            this.headsButton.Click += new System.EventHandler(this.headsButton_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(93, 145);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(81, 37);
            this.button2.TabIndex = 1;
            this.button2.Text = "Show Tails";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(180, 145);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(81, 37);
            this.exitButton.TabIndex = 2;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // tailsImage
            // 
            this.tailsImage.Image = global::HeadOrTail.Properties.Resources.Tails1;
            this.tailsImage.Location = new System.Drawing.Point(161, 12);
            this.tailsImage.Name = "tailsImage";
            this.tailsImage.Size = new System.Drawing.Size(100, 100);
            this.tailsImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.tailsImage.TabIndex = 4;
            this.tailsImage.TabStop = false;
            this.tailsImage.Visible = false;
            // 
            // headsImage
            // 
            this.headsImage.Image = global::HeadOrTail.Properties.Resources.Heads1;
            this.headsImage.Location = new System.Drawing.Point(6, 12);
            this.headsImage.Name = "headsImage";
            this.headsImage.Size = new System.Drawing.Size(100, 100);
            this.headsImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.headsImage.TabIndex = 3;
            this.headsImage.TabStop = false;
            this.headsImage.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(270, 199);
            this.Controls.Add(this.tailsImage);
            this.Controls.Add(this.headsImage);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.headsButton);
            this.Name = "Form1";
            this.Text = "Heads or Tails";
            ((System.ComponentModel.ISupportInitialize)(this.tailsImage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.headsImage)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button headsButton;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.PictureBox headsImage;
        private System.Windows.Forms.PictureBox tailsImage;
    }
}

