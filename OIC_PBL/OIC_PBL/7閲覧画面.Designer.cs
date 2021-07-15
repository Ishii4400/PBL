namespace OIC_PBL
{
    partial class _7閲覧画面
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
            this.エクスポート = new System.Windows.Forms.Button();
            this.編集 = new System.Windows.Forms.Button();
            this.詳細閲覧 = new System.Windows.Forms.Button();
            this.評価入力 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.参加者number = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.名前 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.フリガナ = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.所属 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.学校名 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.入試対象年度 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.入試免除 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // TOP
            // 
            this.TOP.AutoSize = true;
            this.TOP.LinkColor = System.Drawing.Color.DeepSkyBlue;
            this.TOP.Location = new System.Drawing.Point(51, 290);
            this.TOP.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.TOP.Name = "TOP";
            this.TOP.Size = new System.Drawing.Size(27, 12);
            this.TOP.TabIndex = 0;
            this.TOP.TabStop = true;
            this.TOP.Text = "TOP";
            this.TOP.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.TOP_LinkClicked);
            // 
            // メニュー
            // 
            this.メニュー.AutoSize = true;
            this.メニュー.LinkColor = System.Drawing.Color.DeepSkyBlue;
            this.メニュー.Location = new System.Drawing.Point(119, 290);
            this.メニュー.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.メニュー.Name = "メニュー";
            this.メニュー.Size = new System.Drawing.Size(40, 12);
            this.メニュー.TabIndex = 1;
            this.メニュー.TabStop = true;
            this.メニュー.Text = "メニュー";
            this.メニュー.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.メニュー_LinkClicked);
            // 
            // エクスポート
            // 
            this.エクスポート.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.エクスポート.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.エクスポート.Font = new System.Drawing.Font("MS UI Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.エクスポート.ForeColor = System.Drawing.SystemColors.Window;
            this.エクスポート.Location = new System.Drawing.Point(205, 269);
            this.エクスポート.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.エクスポート.Name = "エクスポート";
            this.エクスポート.Size = new System.Drawing.Size(80, 30);
            this.エクスポート.TabIndex = 2;
            this.エクスポート.Text = "CSVエクスポート";
            this.エクスポート.UseVisualStyleBackColor = false;
            this.エクスポート.Click += new System.EventHandler(this.エクスポート_Click);
            // 
            // 編集
            // 
            this.編集.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.編集.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.編集.ForeColor = System.Drawing.SystemColors.Window;
            this.編集.Location = new System.Drawing.Point(302, 269);
            this.編集.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.編集.Name = "編集";
            this.編集.Size = new System.Drawing.Size(80, 30);
            this.編集.TabIndex = 3;
            this.編集.Text = "編集";
            this.編集.UseVisualStyleBackColor = false;
            this.編集.Click += new System.EventHandler(this.編集_Click);
            // 
            // 詳細閲覧
            // 
            this.詳細閲覧.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.詳細閲覧.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.詳細閲覧.ForeColor = System.Drawing.SystemColors.Window;
            this.詳細閲覧.Location = new System.Drawing.Point(400, 269);
            this.詳細閲覧.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.詳細閲覧.Name = "詳細閲覧";
            this.詳細閲覧.Size = new System.Drawing.Size(80, 30);
            this.詳細閲覧.TabIndex = 4;
            this.詳細閲覧.Text = "詳細閲覧";
            this.詳細閲覧.UseVisualStyleBackColor = false;
            this.詳細閲覧.Click += new System.EventHandler(this.詳細閲覧_Click);
            // 
            // 評価入力
            // 
            this.評価入力.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.評価入力.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.評価入力.ForeColor = System.Drawing.SystemColors.Window;
            this.評価入力.Location = new System.Drawing.Point(497, 269);
            this.評価入力.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.評価入力.Name = "評価入力";
            this.評価入力.Size = new System.Drawing.Size(80, 30);
            this.評価入力.TabIndex = 5;
            this.評価入力.Text = "評価入力";
            this.評価入力.UseVisualStyleBackColor = false;
            this.評価入力.Click += new System.EventHandler(this.評価入力_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.MenuBar;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.参加者number,
            this.名前,
            this.フリガナ,
            this.所属,
            this.学校名,
            this.入試対象年度,
            this.入試免除});
            this.dataGridView1.Location = new System.Drawing.Point(9, 48);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(582, 206);
            this.dataGridView1.TabIndex = 7;
            // 
            // 参加者number
            // 
            this.参加者number.HeaderText = "参加者№";
            this.参加者number.MinimumWidth = 6;
            this.参加者number.Name = "参加者number";
            this.参加者number.Width = 120;
            // 
            // 名前
            // 
            this.名前.HeaderText = "名前";
            this.名前.MinimumWidth = 6;
            this.名前.Name = "名前";
            this.名前.Width = 120;
            // 
            // フリガナ
            // 
            this.フリガナ.HeaderText = "フリガナ";
            this.フリガナ.MinimumWidth = 6;
            this.フリガナ.Name = "フリガナ";
            this.フリガナ.Width = 120;
            // 
            // 所属
            // 
            this.所属.HeaderText = "所属";
            this.所属.MinimumWidth = 6;
            this.所属.Name = "所属";
            this.所属.Width = 75;
            // 
            // 学校名
            // 
            this.学校名.HeaderText = "学校名";
            this.学校名.MinimumWidth = 6;
            this.学校名.Name = "学校名";
            this.学校名.Width = 150;
            // 
            // 入試対象年度
            // 
            this.入試対象年度.HeaderText = "入試対象年度";
            this.入試対象年度.MinimumWidth = 6;
            this.入試対象年度.Name = "入試対象年度";
            this.入試対象年度.Width = 90;
            // 
            // 入試免除
            // 
            this.入試免除.HeaderText = "入試免除";
            this.入試免除.MinimumWidth = 6;
            this.入試免除.Name = "入試免除";
            this.入試免除.Width = 50;
            // 
            // _7閲覧画面
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(1904, 1041);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.評価入力);
            this.Controls.Add(this.詳細閲覧);
            this.Controls.Add(this.編集);
            this.Controls.Add(this.エクスポート);
            this.Controls.Add(this.メニュー);
            this.Controls.Add(this.TOP);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "_7閲覧画面";
            this.Text = "_7閲覧画面";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.LinkLabel TOP;
        private System.Windows.Forms.LinkLabel メニュー;
        private System.Windows.Forms.Button エクスポート;
        private System.Windows.Forms.Button 編集;
        private System.Windows.Forms.Button 詳細閲覧;
        private System.Windows.Forms.Button 評価入力;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn 参加者number;
        private System.Windows.Forms.DataGridViewTextBoxColumn 名前;
        private System.Windows.Forms.DataGridViewTextBoxColumn フリガナ;
        private System.Windows.Forms.DataGridViewTextBoxColumn 所属;
        private System.Windows.Forms.DataGridViewTextBoxColumn 学校名;
        private System.Windows.Forms.DataGridViewTextBoxColumn 入試対象年度;
        private System.Windows.Forms.DataGridViewTextBoxColumn 入試免除;
    }
}