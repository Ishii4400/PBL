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
            this.components = new System.ComponentModel.Container();
            this.TOP = new System.Windows.Forms.LinkLabel();
            this.メニュー = new System.Windows.Forms.LinkLabel();
            this.エクスポート = new System.Windows.Forms.Button();
            this.編集 = new System.Windows.Forms.Button();
            this.詳細閲覧 = new System.Windows.Forms.Button();
            this.評価入力 = new System.Windows.Forms.Button();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.historymasterBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.pBLDBDataSet = new OIC_PBL.PBLDBDataSet();
            this.historymasterBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.history_masterTableAdapter = new OIC_PBL.PBLDBDataSetTableAdapters.history_masterTableAdapter();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewCheckBoxColumn1 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.dataGridViewTextBoxColumn12 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.historymasterBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBLDBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.historymasterBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // TOP
            // 
            this.TOP.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.TOP.AutoSize = true;
            this.TOP.Font = new System.Drawing.Font("MS UI Gothic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.TOP.LinkColor = System.Drawing.Color.DeepSkyBlue;
            this.TOP.Location = new System.Drawing.Point(145, 903);
            this.TOP.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.TOP.Name = "TOP";
            this.TOP.Size = new System.Drawing.Size(64, 27);
            this.TOP.TabIndex = 0;
            this.TOP.TabStop = true;
            this.TOP.Text = "TOP";
            this.TOP.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.TOP_LinkClicked);
            // 
            // メニュー
            // 
            this.メニュー.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.メニュー.AutoSize = true;
            this.メニュー.Font = new System.Drawing.Font("MS UI Gothic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.メニュー.LinkColor = System.Drawing.Color.DeepSkyBlue;
            this.メニュー.Location = new System.Drawing.Point(276, 903);
            this.メニュー.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.メニュー.Name = "メニュー";
            this.メニュー.Size = new System.Drawing.Size(91, 27);
            this.メニュー.TabIndex = 1;
            this.メニュー.TabStop = true;
            this.メニュー.Text = "メニュー";
            this.メニュー.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.メニュー_LinkClicked);
            // 
            // エクスポート
            // 
            this.エクスポート.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.エクスポート.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.エクスポート.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.エクスポート.Font = new System.Drawing.Font("MS UI Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.エクスポート.ForeColor = System.Drawing.SystemColors.Window;
            this.エクスポート.Location = new System.Drawing.Point(1083, 892);
            this.エクスポート.Margin = new System.Windows.Forms.Padding(2);
            this.エクスポート.Name = "エクスポート";
            this.エクスポート.Size = new System.Drawing.Size(150, 50);
            this.エクスポート.TabIndex = 2;
            this.エクスポート.Text = "CSVエクスポート";
            this.エクスポート.UseVisualStyleBackColor = false;
            this.エクスポート.Click += new System.EventHandler(this.エクスポート_Click);
            // 
            // 編集
            // 
            this.編集.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.編集.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.編集.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.編集.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.編集.ForeColor = System.Drawing.SystemColors.Window;
            this.編集.Location = new System.Drawing.Point(1265, 892);
            this.編集.Margin = new System.Windows.Forms.Padding(2);
            this.編集.Name = "編集";
            this.編集.Size = new System.Drawing.Size(150, 50);
            this.編集.TabIndex = 3;
            this.編集.Text = "編集";
            this.編集.UseVisualStyleBackColor = false;
            this.編集.Click += new System.EventHandler(this.編集_Click);
            // 
            // 詳細閲覧
            // 
            this.詳細閲覧.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.詳細閲覧.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.詳細閲覧.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.詳細閲覧.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.詳細閲覧.ForeColor = System.Drawing.SystemColors.Window;
            this.詳細閲覧.Location = new System.Drawing.Point(1449, 892);
            this.詳細閲覧.Margin = new System.Windows.Forms.Padding(2);
            this.詳細閲覧.Name = "詳細閲覧";
            this.詳細閲覧.Size = new System.Drawing.Size(150, 50);
            this.詳細閲覧.TabIndex = 4;
            this.詳細閲覧.Text = "詳細閲覧";
            this.詳細閲覧.UseVisualStyleBackColor = false;
            this.詳細閲覧.Click += new System.EventHandler(this.詳細閲覧_Click);
            // 
            // 評価入力
            // 
            this.評価入力.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.評価入力.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.評価入力.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.評価入力.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.評価入力.ForeColor = System.Drawing.SystemColors.Window;
            this.評価入力.Location = new System.Drawing.Point(1632, 892);
            this.評価入力.Margin = new System.Windows.Forms.Padding(2);
            this.評価入力.Name = "評価入力";
            this.評価入力.Size = new System.Drawing.Size(150, 50);
            this.評価入力.TabIndex = 5;
            this.評価入力.Text = "評価入力";
            this.評価入力.UseVisualStyleBackColor = false;
            this.評価入力.Click += new System.EventHandler(this.評価入力_Click);
            // 
            // linkLabel1
            // 
            this.linkLabel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Font = new System.Drawing.Font("MS UI Gothic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.linkLabel1.LinkColor = System.Drawing.Color.DeepSkyBlue;
            this.linkLabel1.Location = new System.Drawing.Point(435, 903);
            this.linkLabel1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(60, 27);
            this.linkLabel1.TabIndex = 8;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "戻る";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // historymasterBindingSource
            // 
            this.historymasterBindingSource.DataMember = "history_master";
            this.historymasterBindingSource.CurrentChanged += new System.EventHandler(this.historymasterBindingSource_CurrentChanged);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8,
            this.dataGridViewTextBoxColumn9,
            this.dataGridViewTextBoxColumn10,
            this.dataGridViewTextBoxColumn11,
            this.dataGridViewCheckBoxColumn1,
            this.dataGridViewTextBoxColumn12});
            this.dataGridView1.DataSource = this.historymasterBindingSource1;
            this.dataGridView1.Location = new System.Drawing.Point(262, 78);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 21;
            this.dataGridView1.Size = new System.Drawing.Size(1353, 707);
            this.dataGridView1.TabIndex = 9;
            // 
            // pBLDBDataSet
            // 
            this.pBLDBDataSet.DataSetName = "PBLDBDataSet";
            this.pBLDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // historymasterBindingSource1
            // 
            this.historymasterBindingSource1.DataMember = "history_master";
            this.historymasterBindingSource1.DataSource = this.pBLDBDataSet;
            // 
            // history_masterTableAdapter
            // 
            this.history_masterTableAdapter.ClearBeforeFill = true;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "参加者No";
            this.dataGridViewTextBoxColumn1.HeaderText = "参加者No";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "日付";
            this.dataGridViewTextBoxColumn2.HeaderText = "日付";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "名前";
            this.dataGridViewTextBoxColumn3.HeaderText = "名前";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "フリガナ";
            this.dataGridViewTextBoxColumn4.HeaderText = "フリガナ";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "ポイント";
            this.dataGridViewTextBoxColumn5.HeaderText = "ポイント";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "所属";
            this.dataGridViewTextBoxColumn6.HeaderText = "所属";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "年齢";
            this.dataGridViewTextBoxColumn7.HeaderText = "年齢";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "出身校コード";
            this.dataGridViewTextBoxColumn8.HeaderText = "出身校コード";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.DataPropertyName = "学年";
            this.dataGridViewTextBoxColumn9.HeaderText = "学年";
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            // 
            // dataGridViewTextBoxColumn10
            // 
            this.dataGridViewTextBoxColumn10.DataPropertyName = "参加コース";
            this.dataGridViewTextBoxColumn10.HeaderText = "参加コース";
            this.dataGridViewTextBoxColumn10.Name = "dataGridViewTextBoxColumn10";
            // 
            // dataGridViewTextBoxColumn11
            // 
            this.dataGridViewTextBoxColumn11.DataPropertyName = "参加学科コード";
            this.dataGridViewTextBoxColumn11.HeaderText = "参加学科コード";
            this.dataGridViewTextBoxColumn11.Name = "dataGridViewTextBoxColumn11";
            // 
            // dataGridViewCheckBoxColumn1
            // 
            this.dataGridViewCheckBoxColumn1.DataPropertyName = "合否";
            this.dataGridViewCheckBoxColumn1.HeaderText = "合否";
            this.dataGridViewCheckBoxColumn1.Name = "dataGridViewCheckBoxColumn1";
            // 
            // dataGridViewTextBoxColumn12
            // 
            this.dataGridViewTextBoxColumn12.DataPropertyName = "入試パスNo";
            this.dataGridViewTextBoxColumn12.HeaderText = "入試パスNo";
            this.dataGridViewTextBoxColumn12.Name = "dataGridViewTextBoxColumn12";
            // 
            // _7閲覧画面
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(1904, 1041);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.評価入力);
            this.Controls.Add(this.詳細閲覧);
            this.Controls.Add(this.編集);
            this.Controls.Add(this.エクスポート);
            this.Controls.Add(this.メニュー);
            this.Controls.Add(this.TOP);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "_7閲覧画面";
            this.Text = "_7閲覧画面";
            this.Load += new System.EventHandler(this._7閲覧画面_Load);
            ((System.ComponentModel.ISupportInitialize)(this.historymasterBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBLDBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.historymasterBindingSource1)).EndInit();
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
        private System.Windows.Forms.LinkLabel linkLabel1;
        //private PBLDBDataSet pBLDBDataSet;
        private System.Windows.Forms.BindingSource historymasterBindingSource;
        //private PBLDBDataSetTableAdapters.history_masterTableAdapter history_masterTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn 参加者NoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 日付DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 名前DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn フリガナDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ポイントDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 所属DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 年齢DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 出身校コードDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 学年DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 参加コースDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 参加学科コードDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn 合否DataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 入試パスNoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridView dataGridView1;
        private PBLDBDataSet pBLDBDataSet;
        private System.Windows.Forms.BindingSource historymasterBindingSource1;
        private PBLDBDataSetTableAdapters.history_masterTableAdapter history_masterTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn10;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn11;
        private System.Windows.Forms.DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn12;
    }
}