namespace OIC_PBL
{
    partial class _5_2参加人数集計表
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
            this.戻る = new System.Windows.Forms.LinkLabel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.日付 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.年月日 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.三年生の入試対象年度 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.年度 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.学科 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.合計 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.三年以上 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.二年 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.一年 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // 戻る
            // 
            this.戻る.AutoSize = true;
            this.戻る.LinkColor = System.Drawing.Color.DeepSkyBlue;
            this.戻る.Location = new System.Drawing.Point(116, 361);
            this.戻る.Name = "戻る";
            this.戻る.Size = new System.Drawing.Size(33, 15);
            this.戻る.TabIndex = 0;
            this.戻る.TabStop = true;
            this.戻る.Text = "戻る";
            this.戻る.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.戻る_LinkClicked);
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.日付,
            this.年月日,
            this.三年生の入試対象年度,
            this.年度});
            this.dataGridView1.GridColor = System.Drawing.SystemColors.Window;
<<<<<<< HEAD
            this.dataGridView1.Location = new System.Drawing.Point(119, 50);
=======
            this.dataGridView1.Location = new System.Drawing.Point(149, 60);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4);
>>>>>>> 071cba11a20cadf0aef243ec0d079c97244a1841
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(578, 25);
            this.dataGridView1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(130, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(226, 15);
            this.label1.TabIndex = 2;
            this.label1.Text = "説明会参加者・参加学科集計リスト";
            // 
            // dataGridView2
            // 
            this.dataGridView2.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.学科,
            this.合計,
            this.三年以上,
            this.二年,
            this.一年});
            this.dataGridView2.GridColor = System.Drawing.SystemColors.Window;
            this.dataGridView2.Location = new System.Drawing.Point(119, 81);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowHeadersWidth = 51;
            this.dataGridView2.RowTemplate.Height = 24;
            this.dataGridView2.Size = new System.Drawing.Size(578, 277);
            this.dataGridView2.TabIndex = 3;
            // 
            // 日付
            // 
            this.日付.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.日付.HeaderText = "日付";
            this.日付.MinimumWidth = 6;
            this.日付.Name = "日付";
            this.日付.Width = 90;
            // 
            // 年月日
            // 
            this.年月日.HeaderText = "";
            this.年月日.MinimumWidth = 6;
            this.年月日.Name = "年月日";
            this.年月日.Width = 125;
            // 
            // 三年生の入試対象年度
            // 
            this.三年生の入試対象年度.HeaderText = "3年生の入試対象年度";
            this.三年生の入試対象年度.MinimumWidth = 6;
            this.三年生の入試対象年度.Name = "三年生の入試対象年度";
            this.三年生の入試対象年度.Width = 190;
            // 
            // 年度
            // 
            this.年度.HeaderText = "";
            this.年度.MinimumWidth = 6;
            this.年度.Name = "年度";
            this.年度.Width = 125;
            // 
            // 学科
            // 
            this.学科.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.学科.HeaderText = "学科";
            this.学科.MinimumWidth = 6;
            this.学科.Name = "学科";
            this.学科.Width = 205;
            // 
            // 合計
            // 
            this.合計.HeaderText = "合計";
            this.合計.MinimumWidth = 6;
            this.合計.Name = "合計";
            this.合計.Width = 70;
            // 
            // 三年以上
            // 
            this.三年以上.HeaderText = "３年以上";
            this.三年以上.MinimumWidth = 6;
            this.三年以上.Name = "三年以上";
            this.三年以上.Width = 90;
            // 
            // 二年
            // 
            this.二年.HeaderText = "２年";
            this.二年.MinimumWidth = 6;
            this.二年.Name = "二年";
            this.二年.Width = 80;
            // 
            // 一年
            // 
            this.一年.HeaderText = "１年";
            this.一年.MinimumWidth = 6;
            this.一年.Name = "一年";
            this.一年.Width = 80;
            // 
            // _5_2参加人数集計表
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.戻る);
<<<<<<< HEAD
=======
            this.Margin = new System.Windows.Forms.Padding(4);
>>>>>>> 071cba11a20cadf0aef243ec0d079c97244a1841
            this.Name = "_5_2参加人数集計表";
            this.Text = "_5_2参加人数集計表";
            this.Load += new System.EventHandler(this._5_2参加人数集計表_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.LinkLabel 戻る;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn 日付;
        private System.Windows.Forms.DataGridViewTextBoxColumn 年月日;
        private System.Windows.Forms.DataGridViewTextBoxColumn 三年生の入試対象年度;
        private System.Windows.Forms.DataGridViewTextBoxColumn 年度;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.DataGridViewTextBoxColumn 学科;
        private System.Windows.Forms.DataGridViewTextBoxColumn 合計;
        private System.Windows.Forms.DataGridViewTextBoxColumn 三年以上;
        private System.Windows.Forms.DataGridViewTextBoxColumn 二年;
        private System.Windows.Forms.DataGridViewTextBoxColumn 一年;
    }
}