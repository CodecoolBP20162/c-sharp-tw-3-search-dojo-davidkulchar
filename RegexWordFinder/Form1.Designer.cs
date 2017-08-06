namespace RegexWordFinder
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
            this.tbText = new System.Windows.Forms.TextBox();
            this.tbFind = new System.Windows.Forms.TextBox();
            this.tBSearch = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.lbText = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // tbText
            // 
            this.tbText.Location = new System.Drawing.Point(126, 13);
            this.tbText.Name = "tbText";
            this.tbText.Size = new System.Drawing.Size(639, 22);
            this.tbText.TabIndex = 0;
            // 
            // tbFind
            // 
            this.tbFind.Location = new System.Drawing.Point(849, 12);
            this.tbFind.Name = "tbFind";
            this.tbFind.Size = new System.Drawing.Size(357, 22);
            this.tbFind.TabIndex = 1;
            // 
            // tBSearch
            // 
            this.tBSearch.Location = new System.Drawing.Point(126, 41);
            this.tBSearch.Name = "tBSearch";
            this.tBSearch.Size = new System.Drawing.Size(638, 22);
            this.tBSearch.TabIndex = 2;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(849, 41);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(357, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "Search";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // lbText
            // 
            this.lbText.AutoSize = true;
            this.lbText.Location = new System.Drawing.Point(13, 17);
            this.lbText.Name = "lbText";
            this.lbText.Size = new System.Drawing.Size(35, 17);
            this.lbText.TabIndex = 4;
            this.lbText.Text = "Text";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 17);
            this.label2.TabIndex = 5;
            this.label2.Text = "Search for";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(782, 15);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 17);
            this.label3.TabIndex = 6;
            this.label3.Text = "Findings";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1218, 82);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lbText);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.tBSearch);
            this.Controls.Add(this.tbFind);
            this.Controls.Add(this.tbText);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbText;
        private System.Windows.Forms.TextBox tbFind;
        private System.Windows.Forms.TextBox tBSearch;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label lbText;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}

