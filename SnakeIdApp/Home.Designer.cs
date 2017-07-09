namespace SnakeIdApp
{
    partial class Home
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
            this.label1 = new System.Windows.Forms.Label();
            this.btnGPS = new System.Windows.Forms.Button();
            this.btnHead = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.btnTeeth = new System.Windows.Forms.Button();
            this.btnAppear = new System.Windows.Forms.Button();
            this.HomePanel = new System.Windows.Forms.SplitContainer();
            ((System.ComponentModel.ISupportInitialize)(this.HomePanel)).BeginInit();
            this.HomePanel.Panel1.SuspendLayout();
            this.HomePanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Garamond", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(127, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Find snake using";
            // 
            // btnGPS
            // 
            this.btnGPS.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnGPS.Location = new System.Drawing.Point(12, 66);
            this.btnGPS.Name = "btnGPS";
            this.btnGPS.Size = new System.Drawing.Size(164, 35);
            this.btnGPS.TabIndex = 1;
            this.btnGPS.Text = "GPS Location";
            this.btnGPS.UseVisualStyleBackColor = false;
            // 
            // btnHead
            // 
            this.btnHead.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnHead.Location = new System.Drawing.Point(12, 118);
            this.btnHead.Name = "btnHead";
            this.btnHead.Size = new System.Drawing.Size(164, 35);
            this.btnHead.TabIndex = 1;
            this.btnHead.Text = "Snake Head";
            this.btnHead.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.button1.Location = new System.Drawing.Point(12, 172);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(164, 35);
            this.button1.TabIndex = 1;
            this.button1.Text = "Snake Tale";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // btnTeeth
            // 
            this.btnTeeth.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnTeeth.Location = new System.Drawing.Point(12, 224);
            this.btnTeeth.Name = "btnTeeth";
            this.btnTeeth.Size = new System.Drawing.Size(164, 35);
            this.btnTeeth.TabIndex = 1;
            this.btnTeeth.Text = "Snake Teeth";
            this.btnTeeth.UseVisualStyleBackColor = false;
            // 
            // btnAppear
            // 
            this.btnAppear.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnAppear.Location = new System.Drawing.Point(12, 278);
            this.btnAppear.Name = "btnAppear";
            this.btnAppear.Size = new System.Drawing.Size(164, 35);
            this.btnAppear.TabIndex = 1;
            this.btnAppear.Text = "Physical Appearance";
            this.btnAppear.UseVisualStyleBackColor = false;
            this.btnAppear.Click += new System.EventHandler(this.btnAppear_Click);
            // 
            // HomePanel
            // 
            this.HomePanel.BackColor = System.Drawing.Color.DarkBlue;
            this.HomePanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.HomePanel.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.HomePanel.IsSplitterFixed = true;
            this.HomePanel.Location = new System.Drawing.Point(0, 0);
            this.HomePanel.Name = "HomePanel";
            // 
            // HomePanel.Panel1
            // 
            this.HomePanel.Panel1.BackColor = System.Drawing.SystemColors.HotTrack;
            this.HomePanel.Panel1.Controls.Add(this.btnAppear);
            this.HomePanel.Panel1.Controls.Add(this.label1);
            this.HomePanel.Panel1.Controls.Add(this.button1);
            this.HomePanel.Panel1.Controls.Add(this.btnHead);
            this.HomePanel.Panel1.Controls.Add(this.btnTeeth);
            this.HomePanel.Panel1.Controls.Add(this.btnGPS);
            // 
            // HomePanel.Panel2
            // 
            this.HomePanel.Panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(190)))), ((int)(((byte)(239)))));
            this.HomePanel.Size = new System.Drawing.Size(768, 498);
            this.HomePanel.SplitterDistance = 187;
            this.HomePanel.TabIndex = 2;
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(768, 498);
            this.Controls.Add(this.HomePanel);
            this.Name = "Home";
            this.Text = "Home";
            this.HomePanel.Panel1.ResumeLayout(false);
            this.HomePanel.Panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.HomePanel)).EndInit();
            this.HomePanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnGPS;
        private System.Windows.Forms.Button btnHead;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnTeeth;
        private System.Windows.Forms.Button btnAppear;
        private System.Windows.Forms.SplitContainer HomePanel;
    }
}

