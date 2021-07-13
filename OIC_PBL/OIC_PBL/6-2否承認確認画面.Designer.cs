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
            this.この内容で登録してよろしいですか = new System.Windows.Forms.Label();
            this.編集 = new System.Windows.Forms.Button();
            this.確定 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // この内容で登録してよろしいですか
            // 
            this.この内容で登録してよろしいですか.AutoSize = true;
            this.この内容で登録してよろしいですか.Font = new System.Drawing.Font("MS UI Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.この内容で登録してよろしいですか.Location = new System.Drawing.Point(89, 60);
            this.この内容で登録してよろしいですか.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.この内容で登録してよろしいですか.Name = "この内容で登録してよろしいですか";
            this.この内容で登録してよろしいですか.Size = new System.Drawing.Size(285, 18);
            this.この内容で登録してよろしいですか.TabIndex = 0;
            this.この内容で登録してよろしいですか.Text = "この内容で登録してよろしいですか？";
            // 
            // 編集
            // 
            this.編集.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.編集.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.編集.ForeColor = System.Drawing.SystemColors.Window;
            this.編集.Location = new System.Drawing.Point(621, 409);
            this.編集.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.編集.Name = "編集";
            this.編集.Size = new System.Drawing.Size(134, 46);
            this.編集.TabIndex = 1;
            this.編集.Text = "編集";
            this.編集.UseVisualStyleBackColor = false;
            this.編集.Click += new System.EventHandler(this.編集_Click);
            // 
            // 確定
            // 
            this.確定.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.確定.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.確定.ForeColor = System.Drawing.SystemColors.Window;
            this.確定.Location = new System.Drawing.Point(795, 409);
            this.確定.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.確定.Name = "確定";
            this.確定.Size = new System.Drawing.Size(134, 46);
            this.確定.TabIndex = 2;
            this.確定.Text = "確定";
            this.確定.UseVisualStyleBackColor = false;
            this.確定.Click += new System.EventHandler(this.確定_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.MenuBar;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(102, 89);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(831, 313);
            this.dataGridView1.TabIndex = 3;
            // 
            // _6_2承認確認画面
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(1000, 540);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.確定);
            this.Controls.Add(this.編集);
            this.Controls.Add(this.この内容で登録してよろしいですか);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
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
    }
}