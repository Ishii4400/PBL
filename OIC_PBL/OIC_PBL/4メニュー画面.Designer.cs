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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.TOP = new System.Windows.Forms.LinkLabel();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // 一般教員用
            // 
            this.一般教員用.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.一般教員用.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.一般教員用.ForeColor = System.Drawing.SystemColors.Window;
            this.一般教員用.Location = new System.Drawing.Point(111, 148);
            this.一般教員用.Margin = new System.Windows.Forms.Padding(2);
            this.一般教員用.Name = "一般教員用";
            this.一般教員用.Size = new System.Drawing.Size(246, 102);
            this.一般教員用.TabIndex = 0;
            this.一般教員用.Text = "一般教員用\r\n\r\n検索・閲覧・編集・評価入力";
            this.一般教員用.UseVisualStyleBackColor = false;
            // 
            // 上長用
            // 
            this.上長用.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.上長用.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.上長用.ForeColor = System.Drawing.SystemColors.Window;
            this.上長用.Location = new System.Drawing.Point(419, 148);
            this.上長用.Margin = new System.Windows.Forms.Padding(2);
            this.上長用.Name = "上長用";
            this.上長用.Size = new System.Drawing.Size(246, 102);
            this.上長用.TabIndex = 1;
            this.上長用.Text = "上長用\r\n\r\n合否承認";
            this.上長用.UseVisualStyleBackColor = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.pictureBox1.Location = new System.Drawing.Point(111, 93);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(554, 240);
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
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
            // 
            // メニュー画面
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.TOP);
            this.Controls.Add(this.上長用);
            this.Controls.Add(this.一般教員用);
            this.Controls.Add(this.pictureBox1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "メニュー画面";
            this.Text = "メニュー画面";
            this.Load += new System.EventHandler(this.メニュー画面_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button 一般教員用;
        private System.Windows.Forms.Button 上長用;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.LinkLabel TOP;
    }
}