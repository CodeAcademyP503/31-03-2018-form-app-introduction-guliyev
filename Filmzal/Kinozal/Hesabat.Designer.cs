namespace Kinozal
{
    partial class Hesabat
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
            this.NameLabel = new System.Windows.Forms.Label();
            this.SurnameLabel = new System.Windows.Forms.Label();
            this.NameBox = new System.Windows.Forms.TextBox();
            this.SurnameBox = new System.Windows.Forms.TextBox();
            this.NeticeBtn = new System.Windows.Forms.Button();
            this.netice = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Yersecimi = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // NameLabel
            // 
            this.NameLabel.AutoSize = true;
            this.NameLabel.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.NameLabel.Location = new System.Drawing.Point(33, 57);
            this.NameLabel.Name = "NameLabel";
            this.NameLabel.Size = new System.Drawing.Size(35, 13);
            this.NameLabel.TabIndex = 0;
            this.NameLabel.Text = "Name";
            // 
            // SurnameLabel
            // 
            this.SurnameLabel.AutoSize = true;
            this.SurnameLabel.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.SurnameLabel.Location = new System.Drawing.Point(33, 86);
            this.SurnameLabel.Name = "SurnameLabel";
            this.SurnameLabel.Size = new System.Drawing.Size(49, 13);
            this.SurnameLabel.TabIndex = 0;
            this.SurnameLabel.Text = "Surname";
            // 
            // NameBox
            // 
            this.NameBox.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.NameBox.Location = new System.Drawing.Point(112, 57);
            this.NameBox.Name = "NameBox";
            this.NameBox.Size = new System.Drawing.Size(145, 20);
            this.NameBox.TabIndex = 1;
            // 
            // SurnameBox
            // 
            this.SurnameBox.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.SurnameBox.Location = new System.Drawing.Point(112, 86);
            this.SurnameBox.Name = "SurnameBox";
            this.SurnameBox.Size = new System.Drawing.Size(145, 20);
            this.SurnameBox.TabIndex = 1;
            // 
            // NeticeBtn
            // 
            this.NeticeBtn.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.NeticeBtn.Location = new System.Drawing.Point(182, 112);
            this.NeticeBtn.Name = "NeticeBtn";
            this.NeticeBtn.Size = new System.Drawing.Size(75, 23);
            this.NeticeBtn.TabIndex = 2;
            this.NeticeBtn.Text = "Netice";
            this.NeticeBtn.UseVisualStyleBackColor = true;
            this.NeticeBtn.Click += new System.EventHandler(this.NeticeBtn_Click);
            // 
            // netice
            // 
            this.netice.AutoSize = true;
            this.netice.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.netice.Location = new System.Drawing.Point(21, 166);
            this.netice.Name = "netice";
            this.netice.Size = new System.Drawing.Size(44, 13);
            this.netice.TabIndex = 3;
            this.netice.Text = "Netice :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.Location = new System.Drawing.Point(71, 166);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 13);
            this.label2.TabIndex = 3;
            // 
            // Yersecimi
            // 
            this.Yersecimi.AutoSize = true;
            this.Yersecimi.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Yersecimi.Location = new System.Drawing.Point(29, 16);
            this.Yersecimi.Name = "Yersecimi";
            this.Yersecimi.Size = new System.Drawing.Size(72, 13);
            this.Yersecimi.TabIndex = 4;
            this.Yersecimi.Text = "Secilen Yerler";
            // 
            // Hesabat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(403, 345);
            this.Controls.Add(this.Yersecimi);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.netice);
            this.Controls.Add(this.NeticeBtn);
            this.Controls.Add(this.SurnameBox);
            this.Controls.Add(this.NameBox);
            this.Controls.Add(this.SurnameLabel);
            this.Controls.Add(this.NameLabel);
            this.Name = "Hesabat";
            this.Text = "Hesabat";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label NameLabel;
        private System.Windows.Forms.Label SurnameLabel;
        private System.Windows.Forms.TextBox NameBox;
        private System.Windows.Forms.TextBox SurnameBox;
        private System.Windows.Forms.Button NeticeBtn;
        private System.Windows.Forms.Label netice;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label Yersecimi;
    }
}