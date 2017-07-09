namespace SnakeIdApp
{
    partial class SearchByApp
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
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.colorPickerEye = new SnakeIdApp.ColorPicker();
            this.colorPickerTougue = new SnakeIdApp.ColorPicker();
            this.colorPickerWound = new SnakeIdApp.ColorPicker();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtSwell = new System.Windows.Forms.TextBox();
            this.btnPredict = new System.Windows.Forms.Button();
            this.txtSymp = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 13);
            this.label1.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 67);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Tongue Color?";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 17);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "Eye Color?";
            // 
            // colorPickerEye
            // 
            this.colorPickerEye.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.colorPickerEye.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.colorPickerEye.FormattingEnabled = true;
            this.colorPickerEye.Location = new System.Drawing.Point(12, 33);
            this.colorPickerEye.Name = "colorPickerEye";
            this.colorPickerEye.SelectedItem = null;
            this.colorPickerEye.SelectedValue = System.Drawing.Color.White;
            this.colorPickerEye.Size = new System.Drawing.Size(266, 21);
            this.colorPickerEye.TabIndex = 3;
            // 
            // colorPickerTougue
            // 
            this.colorPickerTougue.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.colorPickerTougue.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.colorPickerTougue.FormattingEnabled = true;
            this.colorPickerTougue.Location = new System.Drawing.Point(12, 83);
            this.colorPickerTougue.Name = "colorPickerTougue";
            this.colorPickerTougue.SelectedItem = null;
            this.colorPickerTougue.SelectedValue = System.Drawing.Color.White;
            this.colorPickerTougue.Size = new System.Drawing.Size(266, 21);
            this.colorPickerTougue.TabIndex = 4;
            // 
            // colorPickerWound
            // 
            this.colorPickerWound.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.colorPickerWound.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.colorPickerWound.FormattingEnabled = true;
            this.colorPickerWound.Location = new System.Drawing.Point(12, 136);
            this.colorPickerWound.Name = "colorPickerWound";
            this.colorPickerWound.SelectedItem = null;
            this.colorPickerWound.SelectedValue = System.Drawing.Color.White;
            this.colorPickerWound.Size = new System.Drawing.Size(266, 21);
            this.colorPickerWound.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 171);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nature of Swell";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(9, 120);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(126, 13);
            this.label5.TabIndex = 1;
            this.label5.Text = "Color around the wound?";
            // 
            // txtSwell
            // 
            this.txtSwell.Location = new System.Drawing.Point(12, 196);
            this.txtSwell.Multiline = true;
            this.txtSwell.Name = "txtSwell";
            this.txtSwell.Size = new System.Drawing.Size(267, 65);
            this.txtSwell.TabIndex = 4;
            // 
            // btnPredict
            // 
            this.btnPredict.Location = new System.Drawing.Point(156, 362);
            this.btnPredict.Name = "btnPredict";
            this.btnPredict.Size = new System.Drawing.Size(123, 23);
            this.btnPredict.TabIndex = 3;
            this.btnPredict.Text = "Predict the snake";
            this.btnPredict.UseVisualStyleBackColor = true;
            this.btnPredict.Click += new System.EventHandler(this.btnPredict_Click);
            // 
            // txtSymp
            // 
            this.txtSymp.Location = new System.Drawing.Point(12, 291);
            this.txtSymp.Multiline = true;
            this.txtSymp.Name = "txtSymp";
            this.txtSymp.Size = new System.Drawing.Size(267, 65);
            this.txtSymp.TabIndex = 4;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 275);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(55, 13);
            this.label6.TabIndex = 1;
            this.label6.Text = "Symptoms";
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.colorPickerEye);
            this.splitContainer1.Panel1.Controls.Add(this.colorPickerTougue);
            this.splitContainer1.Panel1.Controls.Add(this.label1);
            this.splitContainer1.Panel1.Controls.Add(this.txtSymp);
            this.splitContainer1.Panel1.Controls.Add(this.label5);
            this.splitContainer1.Panel1.Controls.Add(this.txtSwell);
            this.splitContainer1.Panel1.Controls.Add(this.label2);
            this.splitContainer1.Panel1.Controls.Add(this.label6);
            this.splitContainer1.Panel1.Controls.Add(this.btnPredict);
            this.splitContainer1.Panel1.Controls.Add(this.label4);
            this.splitContainer1.Panel1.Controls.Add(this.label3);
            this.splitContainer1.Panel1.Controls.Add(this.colorPickerWound);
            this.splitContainer1.Size = new System.Drawing.Size(784, 440);
            this.splitContainer1.SplitterDistance = 290;
            this.splitContainer1.TabIndex = 5;
            // 
            // SearchByApp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 440);
            this.Controls.Add(this.splitContainer1);
            this.Name = "SearchByApp";
            this.Text = "Find By Physcal Appearance";
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private ColorPicker colorPickerEye;
        private ColorPicker colorPickerTougue;
        private System.Windows.Forms.TextBox txtSwell;
        private ColorPicker colorPickerWound;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnPredict;
        private System.Windows.Forms.TextBox txtSymp;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.SplitContainer splitContainer1;
    }
}