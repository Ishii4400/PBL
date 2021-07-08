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
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // TOP
            // 
            this.TOP.AutoSize = true;
            this.TOP.LinkColor = System.Drawing.Color.DeepSkyBlue;
            this.TOP.Location = new System.Drawing.Point(68, 363);
            this.TOP.Name = "TOP";
            this.TOP.Size = new System.Drawing.Size(36, 15);
            this.TOP.TabIndex = 0;
            this.TOP.TabStop = true;
            this.TOP.Text = "TOP";
            // 
            // メニュー
            // 
            this.メニュー.AutoSize = true;
            this.メニュー.LinkColor = System.Drawing.Color.DeepSkyBlue;
            this.メニュー.Location = new System.Drawing.Point(159, 363);
            this.メニュー.Name = "メニュー";
            this.メニュー.Size = new System.Drawing.Size(50, 15);
            this.メニュー.TabIndex = 1;
            this.メニュー.TabStop = true;
            this.メニュー.Text = "メニュー";
            // 
            // エクスポート
            // 
            this.エクスポート.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.エクスポート.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.エクスポート.ForeColor = System.Drawing.SystemColors.Window;
            this.エクスポート.Location = new System.Drawing.Point(273, 336);
            this.エクスポート.Name = "エクスポート";
            this.エクスポート.Size = new System.Drawing.Size(114, 51);
            this.エクスポート.TabIndex = 2;
            this.エクスポート.Text = "CSVエクスポート";
            this.エクスポート.UseVisualStyleBackColor = false;
            // 
            // 編集
            // 
            this.編集.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.編集.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.編集.ForeColor = System.Drawing.SystemColors.Window;
            this.編集.Location = new System.Drawing.Point(403, 336);
            this.編集.Name = "編集";
            this.編集.Size = new System.Drawing.Size(114, 51);
            this.編集.TabIndex = 3;
            this.編集.Text = "編集";
            this.編集.UseVisualStyleBackColor = false;
            // 
            // 詳細閲覧
            // 
            this.詳細閲覧.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.詳細閲覧.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.詳細閲覧.ForeColor = System.Drawing.SystemColors.Window;
            this.詳細閲覧.Location = new System.Drawing.Point(533, 336);
            this.詳細閲覧.Name = "詳細閲覧";
            this.詳細閲覧.Size = new System.Drawing.Size(114, 51);
            this.詳細閲覧.TabIndex = 4;
            this.詳細閲覧.Text = "詳細閲覧";
            this.詳細閲覧.UseVisualStyleBackColor = false;
            // 
            // 評価入力
            // 
            this.評価入力.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.評価入力.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.評価入力.ForeColor = System.Drawing.SystemColors.Window;
            this.評価入力.Location = new System.Drawing.Point(663, 336);
            this.評価入力.Name = "評価入力";
            this.評価入力.Size = new System.Drawing.Size(114, 51);
            this.評価入力.TabIndex = 5;
            this.評価入力.Text = "評価入力";
            this.評価入力.UseVisualStyleBackColor = false;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(76, 34);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.Size = new System.Drawing.Size(700, 282);
            this.dataGridView1.TabIndex = 6;
            // 
            // _7閲覧画面
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.評価入力);
            this.Controls.Add(this.詳細閲覧);
            this.Controls.Add(this.編集);
            this.Controls.Add(this.エクスポート);
            this.Controls.Add(this.メニュー);
            this.Controls.Add(this.TOP);
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
    }
}