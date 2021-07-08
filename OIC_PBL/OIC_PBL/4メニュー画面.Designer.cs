namespace OIC_PBL
{
    partial class メニュー画面
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
            this.一般教員用 = new System.Windows.Forms.Button();
            this.上長用 = new System.Windows.Forms.Button();
            this.TOP = new System.Windows.Forms.LinkLabel();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // 一般教員用
            // 
            this.一般教員用.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.一般教員用.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.一般教員用.FlatAppearance.BorderSize = 0;
            this.一般教員用.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.一般教員用.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.一般教員用.Location = new System.Drawing.Point(92, 153);
            this.一般教員用.Margin = new System.Windows.Forms.Padding(2);
            this.一般教員用.Name = "一般教員用";
            this.一般教員用.Size = new System.Drawing.Size(197, 85);
            this.一般教員用.TabIndex = 0;
            this.一般教員用.Text = "一般教員用\r\n\r\n検索・閲覧・編集・評価入力";
            this.一般教員用.UseVisualStyleBackColor = false;
            this.一般教員用.Click += new System.EventHandler(this.一般教員用_Click);
            // 
            // 上長用
            // 
            this.上長用.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.上長用.FlatAppearance.BorderSize = 0;
            this.上長用.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.上長用.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.上長用.Location = new System.Drawing.Point(347, 153);
            this.上長用.Margin = new System.Windows.Forms.Padding(2);
            this.上長用.Name = "上長用";
            this.上長用.Size = new System.Drawing.Size(197, 85);
            this.上長用.TabIndex = 1;
            this.上長用.Text = "上長用\r\n\r\n合否承認";
            this.上長用.UseVisualStyleBackColor = false;
            this.上長用.Click += new System.EventHandler(this.上長用_Click);
            // 
            // TOP
            // 
            this.TOP.AutoSize = true;
            this.TOP.LinkColor = System.Drawing.Color.DeepSkyBlue;
            this.TOP.Location = new System.Drawing.Point(60, 320);
            this.TOP.Name = "TOP";
            this.TOP.Size = new System.Drawing.Size(36, 15);
            this.TOP.TabIndex = 3;
            this.TOP.TabStop = true;
            this.TOP.Text = "TOP";
            this.TOP.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.TOP_LinkClicked_1);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.SystemColors.MenuBar;
            this.label1.Location = new System.Drawing.Point(77, 89);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(491, 203);
            this.label1.TabIndex = 4;
            // 
            // メニュー画面
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(640, 375);
            this.Controls.Add(this.TOP);
            this.Controls.Add(this.上長用);
            this.Controls.Add(this.一般教員用);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "メニュー画面";
            this.Text = "メニュー画面";
            this.Load += new System.EventHandler(this.メニュー画面_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button 一般教員用;
        private System.Windows.Forms.Button 上長用;
        private System.Windows.Forms.LinkLabel TOP;
        private System.Windows.Forms.Label label1;
    }
}