﻿namespace OIC_PBL
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
            this.TOP.Location = new System.Drawing.Point(117, 362);
            this.TOP.Name = "TOP";
            this.TOP.Size = new System.Drawing.Size(36, 15);
            this.TOP.TabIndex = 0;
            this.TOP.TabStop = true;
            this.TOP.Text = "TOP";
            this.TOP.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.TOP_LinkClicked);
            // 
            // メニュー
            // 
            this.メニュー.AutoSize = true;
            this.メニュー.LinkColor = System.Drawing.Color.DeepSkyBlue;
            this.メニュー.Location = new System.Drawing.Point(199, 362);
            this.メニュー.Name = "メニュー";
            this.メニュー.Size = new System.Drawing.Size(50, 15);
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
            this.詳細閲覧.Location = new System.Drawing.Point(400, 329);
            this.詳細閲覧.Name = "詳細閲覧";
            this.詳細閲覧.Size = new System.Drawing.Size(110, 48);
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
            this.否認.Location = new System.Drawing.Point(529, 329);
            this.否認.Name = "否認";
            this.否認.Size = new System.Drawing.Size(110, 48);
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
            this.承認.Location = new System.Drawing.Point(656, 329);
            this.承認.Name = "承認";
            this.承認.Size = new System.Drawing.Size(110, 48);
            this.承認.TabIndex = 4;
            this.承認.Text = "承認";
            this.承認.UseVisualStyleBackColor = false;
            this.承認.Click += new System.EventHandler(this.承認_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(57, 29);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(709, 294);
            this.dataGridView1.TabIndex = 5;
            // 
            // _6_1上長承認画面
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.承認);
            this.Controls.Add(this.否認);
            this.Controls.Add(this.詳細閲覧);
            this.Controls.Add(this.メニュー);
            this.Controls.Add(this.TOP);
            this.Name = "_6_1上長承認画面";
            this.Text = "_6_1上長承認画面";
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