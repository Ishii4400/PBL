namespace OIC_PBL
{
    partial class _6_2承認確認画面
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            this.この内容で登録してよろしいですか = new System.Windows.Forms.Label();
            this.編集 = new System.Windows.Forms.Button();
            this.確定 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.日付 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.名前 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.参加学科 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.不合格理由 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.点数 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.合否 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.否承認 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // この内容で登録してよろしいですか
            // 
            this.この内容で登録してよろしいですか.AutoSize = true;
            this.この内容で登録してよろしいですか.Font = new System.Drawing.Font("MS UI Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.この内容で登録してよろしいですか.Location = new System.Drawing.Point(53, 40);
            this.この内容で登録してよろしいですか.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.この内容で登録してよろしいですか.Name = "この内容で登録してよろしいですか";
            this.この内容で登録してよろしいですか.Size = new System.Drawing.Size(195, 12);
            this.この内容で登録してよろしいですか.TabIndex = 0;
            this.この内容で登録してよろしいですか.Text = "この内容で登録してよろしいですか？";
            // 
            // 編集
            // 
            this.編集.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.編集.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.編集.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.編集.ForeColor = System.Drawing.SystemColors.Window;
            this.編集.Location = new System.Drawing.Point(1371, 844);
            this.編集.Margin = new System.Windows.Forms.Padding(2);
            this.編集.Name = "編集";
            this.編集.Size = new System.Drawing.Size(150, 50);
            this.編集.TabIndex = 1;
            this.編集.Text = "編集";
            this.編集.UseVisualStyleBackColor = false;
            this.編集.Click += new System.EventHandler(this.編集_Click);
            // 
            // 確定
            // 
            this.確定.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.確定.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.確定.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.確定.ForeColor = System.Drawing.SystemColors.Window;
            this.確定.Location = new System.Drawing.Point(1658, 844);
            this.確定.Margin = new System.Windows.Forms.Padding(2);
            this.確定.Name = "確定";
            this.確定.Size = new System.Drawing.Size(150, 50);
            this.確定.TabIndex = 2;
            this.確定.Text = "確定";
            this.確定.UseVisualStyleBackColor = false;
            this.確定.Click += new System.EventHandler(this.確定_Click);
            // 
            // dataGridView1
            // 
            dataGridViewCellStyle1.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.dataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.MenuBar;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.日付,
            this.名前,
            this.参加学科,
            this.不合格理由,
            this.点数,
            this.合否,
            this.否承認});
            this.dataGridView1.Location = new System.Drawing.Point(135, 135);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1673, 624);
            this.dataGridView1.TabIndex = 8;
            // 
            // 日付
            // 
            this.日付.Frozen = true;
            this.日付.HeaderText = "日付";
            this.日付.MinimumWidth = 6;
            this.日付.Name = "日付";
            this.日付.Width = 200;
            // 
            // 名前
            // 
            this.名前.Frozen = true;
            this.名前.HeaderText = "名前";
            this.名前.MinimumWidth = 6;
            this.名前.Name = "名前";
            this.名前.Width = 250;
            // 
            // 参加学科
            // 
            this.参加学科.Frozen = true;
            this.参加学科.HeaderText = "参加学科";
            this.参加学科.MinimumWidth = 6;
            this.参加学科.Name = "参加学科";
            this.参加学科.Width = 300;
            // 
            // 不合格理由
            // 
            this.不合格理由.Frozen = true;
            this.不合格理由.HeaderText = "不合格理由";
            this.不合格理由.MinimumWidth = 6;
            this.不合格理由.Name = "不合格理由";
            this.不合格理由.Width = 550;
            // 
            // 点数
            // 
            dataGridViewCellStyle3.Font = new System.Drawing.Font("MS UI Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.点数.DefaultCellStyle = dataGridViewCellStyle3;
            this.点数.HeaderText = "点数";
            this.点数.MinimumWidth = 6;
            this.点数.Name = "点数";
            // 
            // 合否
            // 
            dataGridViewCellStyle4.Font = new System.Drawing.Font("MS UI Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.合否.DefaultCellStyle = dataGridViewCellStyle4;
            this.合否.HeaderText = "合否";
            this.合否.MinimumWidth = 6;
            this.合否.Name = "合否";
            // 
            // 否承認
            // 
            dataGridViewCellStyle5.Font = new System.Drawing.Font("MS UI Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.否承認.DefaultCellStyle = dataGridViewCellStyle5;
            this.否承認.HeaderText = "否承認";
            this.否承認.MinimumWidth = 6;
            this.否承認.Name = "否承認";
            this.否承認.Width = 120;
            // 
            // _6_2承認確認画面
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(1904, 1041);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.確定);
            this.Controls.Add(this.編集);
            this.Controls.Add(this.この内容で登録してよろしいですか);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "_6_2承認確認画面";
            this.Text = "_6_2承認確認画面";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label この内容で登録してよろしいですか;
        private System.Windows.Forms.Button 編集;
        private System.Windows.Forms.Button 確定;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn 日付;
        private System.Windows.Forms.DataGridViewTextBoxColumn 名前;
        private System.Windows.Forms.DataGridViewTextBoxColumn 参加学科;
        private System.Windows.Forms.DataGridViewTextBoxColumn 不合格理由;
        private System.Windows.Forms.DataGridViewTextBoxColumn 点数;
        private System.Windows.Forms.DataGridViewTextBoxColumn 合否;
        private System.Windows.Forms.DataGridViewTextBoxColumn 否承認;
    }
}