namespace SnakeIdApp
{
    partial class SnakeInfo
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
            this.snakePicture = new System.Windows.Forms.PictureBox();
            this.lblSnake = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.snakePicture)).BeginInit();
            this.SuspendLayout();
            // 
            // snakePicture
            // 
            this.snakePicture.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.snakePicture.Location = new System.Drawing.Point(12, 35);
            this.snakePicture.Name = "snakePicture";
            this.snakePicture.Size = new System.Drawing.Size(460, 185);
            this.snakePicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.snakePicture.TabIndex = 0;
            this.snakePicture.TabStop = false;
            // 
            // lblSnake
            // 
            this.lblSnake.AutoSize = true;
            this.lblSnake.Location = new System.Drawing.Point(12, 9);
            this.lblSnake.Name = "lblSnake";
            this.lblSnake.Size = new System.Drawing.Size(35, 13);
            this.lblSnake.TabIndex = 1;
            this.lblSnake.Text = "label1";
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 232);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Description";
            // 
            // textBox1
            // 
            this.textBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox1.Location = new System.Drawing.Point(12, 248);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(460, 66);
            this.textBox1.TabIndex = 3;
            // 
            // SnakeInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 323);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblSnake);
            this.Controls.Add(this.snakePicture);
            this.Name = "SnakeInfo";
            this.Text = "SnakeInfo";
            ((System.ComponentModel.ISupportInitialize)(this.snakePicture)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox snakePicture;
        private System.Windows.Forms.Label lblSnake;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
    }
}