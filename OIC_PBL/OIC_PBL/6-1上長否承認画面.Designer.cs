namespace OIC_PBL
{
    partial class _6_1上長承認画面
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
            this.TOP = new System.Windows.Forms.LinkLabel();
            this.メニュー = new System.Windows.Forms.LinkLabel();
            this.詳細閲覧 = new System.Windows.Forms.Button();
            this.否認 = new System.Windows.Forms.Button();
            this.承認 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // TOP
            // 
            this.TOP.AutoSize = true;
            this.TOP.LinkColor = System.Drawing.Color.DeepSkyBlue;
            this.TOP.Location = new System.Drawing.Point(146, 434);
            this.TOP.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.TOP.Name = "TOP";
            this.TOP.Size = new System.Drawing.Size(43, 18);
            this.TOP.TabIndex = 0;
            this.TOP.TabStop = true;
            this.TOP.Text = "TOP";
            this.TOP.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.TOP_LinkClicked);
            // 
            // メニュー
            // 
            this.メニュー.AutoSize = true;
            this.メニュー.LinkColor = System.Drawing.Color.DeepSkyBlue;
            this.メニュー.Location = new System.Drawing.Point(249, 434);
            this.メニュー.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.メニュー.Name = "メニュー";
            this.メニュー.Size = new System.Drawing.Size(60, 18);
            this.メニュー.TabIndex = 1;
            this.メニュー.TabStop = true;
            this.メニュー.Text = "メニュー";
            this.メニュー.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.メニュー_LinkClicked);
            // 
            // 詳細閲覧
            // 
            this.詳細閲覧.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.詳細閲覧.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.詳細閲覧.ForeColor = System.Drawing.SystemColors.Window;
            this.詳細閲覧.Location = new System.Drawing.Point(501, 407);
            this.詳細閲覧.Margin = new System.Windows.Forms.Padding(4);
            this.詳細閲覧.Name = "詳細閲覧";
            this.詳細閲覧.Size = new System.Drawing.Size(134, 46);
            this.詳細閲覧.TabIndex = 2;
            this.詳細閲覧.Text = "詳細閲覧";
            this.詳細閲覧.UseVisualStyleBackColor = false;
            this.詳細閲覧.Click += new System.EventHandler(this.詳細閲覧_Click);
            // 
            // 否認
            // 
            this.否認.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.否認.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.否認.ForeColor = System.Drawing.SystemColors.Window;
            this.否認.Location = new System.Drawing.Point(664, 407);
            this.否認.Margin = new System.Windows.Forms.Padding(4);
            this.否認.Name = "否認";
            this.否認.Size = new System.Drawing.Size(134, 46);
            this.否認.TabIndex = 3;
            this.否認.Text = "否認";
            this.否認.UseVisualStyleBackColor = false;
            this.否認.Click += new System.EventHandler(this.否認_Click);
            // 
            // 承認
            // 
            this.承認.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.承認.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.承認.ForeColor = System.Drawing.SystemColors.Window;
            this.承認.Location = new System.Drawing.Point(824, 407);
            this.承認.Margin = new System.Windows.Forms.Padding(4);
            this.承認.Name = "承認";
            this.承認.Size = new System.Drawing.Size(134, 46);
            this.承認.TabIndex = 4;
            this.承認.Text = "承認";
            this.承認.UseVisualStyleBackColor = false;
            this.承認.Click += new System.EventHandler(this.承認_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.MenuBar;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(71, 35);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(886, 353);
            this.dataGridView1.TabIndex = 5;
            // 
            // _6_1上長承認画面
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(1000, 540);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.承認);
            this.Controls.Add(this.否認);
            this.Controls.Add(this.詳細閲覧);
            this.Controls.Add(this.メニュー);
            this.Controls.Add(this.TOP);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "_6_1上長承認画面";
            this.Text = "_6_1上長承認画面";
            this.Load += new System.EventHandler(this._6_1上長承認画面_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.LinkLabel TOP;
        private System.Windows.Forms.LinkLabel メニュー;
        private System.Windows.Forms.Button 詳細閲覧;
        private System.Windows.Forms.Button 否認;
        private System.Windows.Forms.Button 承認;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}