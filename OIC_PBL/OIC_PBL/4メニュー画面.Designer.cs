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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // 一般教員用
            // 
            this.一般教員用.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.一般教員用.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.一般教員用.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.一般教員用.FlatAppearance.BorderSize = 0;
            this.一般教員用.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.一般教員用.Font = new System.Drawing.Font("MS UI Gothic", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.一般教員用.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.一般教員用.Location = new System.Drawing.Point(112, 144);
            this.一般教員用.Margin = new System.Windows.Forms.Padding(2);
            this.一般教員用.Name = "一般教員用";
            this.一般教員用.Size = new System.Drawing.Size(256, 171);
            this.一般教員用.TabIndex = 0;
            this.一般教員用.Text = "一般教員用\r\n\r\n";
            this.一般教員用.UseVisualStyleBackColor = false;
            this.一般教員用.Click += new System.EventHandler(this.一般教員用_Click);
            // 
            // 上長用
            // 
            this.上長用.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.上長用.FlatAppearance.BorderSize = 0;
            this.上長用.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.上長用.Font = new System.Drawing.Font("MS UI Gothic", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.上長用.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.上長用.Location = new System.Drawing.Point(399, 144);
            this.上長用.Margin = new System.Windows.Forms.Padding(2);
            this.上長用.Name = "上長用";
            this.上長用.Size = new System.Drawing.Size(275, 171);
            this.上長用.TabIndex = 1;
            this.上長用.Text = "上長用\r\n\r\n";
            this.上長用.UseVisualStyleBackColor = false;
            this.上長用.Click += new System.EventHandler(this.上長用_Click);
            // 
            // TOP
            // 
            this.TOP.AutoSize = true;
            this.TOP.LinkColor = System.Drawing.Color.DeepSkyBlue;
            this.TOP.Location = new System.Drawing.Point(75, 384);
            this.TOP.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.TOP.Name = "TOP";
            this.TOP.Size = new System.Drawing.Size(43, 18);
            this.TOP.TabIndex = 3;
            this.TOP.TabStop = true;
            this.TOP.Text = "TOP";
            this.TOP.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.TOP_LinkClicked_1);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.SystemColors.MenuBar;
            this.label1.Location = new System.Drawing.Point(88, 107);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(614, 244);
            this.label1.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.label2.Font = new System.Drawing.Font("MS UI Gothic", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label2.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.label2.Location = new System.Drawing.Point(150, 270);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(192, 16);
            this.label2.TabIndex = 5;
            this.label2.Text = "検索・閲覧・編集・評価入力";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.label3.Font = new System.Drawing.Font("MS UI Gothic", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label3.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.label3.Location = new System.Drawing.Point(499, 270);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 16);
            this.label3.TabIndex = 6;
            this.label3.Text = "合否承認";
            // 
            // メニュー画面
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
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
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}