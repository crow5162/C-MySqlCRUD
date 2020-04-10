namespace MySqlCRUD
{
    partial class Form1
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.dgvPhoneNumber = new System.Windows.Forms.DataGridView();
            this.NameBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.NumberBox = new System.Windows.Forms.TextBox();
            this.DescBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.GroupBox = new System.Windows.Forms.TextBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.SearchBox = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPhoneNumber)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.Control;
            this.label1.Font = new System.Drawing.Font("Palatino Linotype", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(43, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(116, 47);
            this.label1.TabIndex = 0;
            this.label1.Text = "Name";
            // 
            // dgvPhoneNumber
            // 
            this.dgvPhoneNumber.AllowUserToAddRows = false;
            this.dgvPhoneNumber.AllowUserToDeleteRows = false;
            this.dgvPhoneNumber.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPhoneNumber.Location = new System.Drawing.Point(499, 143);
            this.dgvPhoneNumber.Name = "dgvPhoneNumber";
            this.dgvPhoneNumber.ReadOnly = true;
            this.dgvPhoneNumber.RowTemplate.Height = 23;
            this.dgvPhoneNumber.Size = new System.Drawing.Size(471, 468);
            this.dgvPhoneNumber.TabIndex = 3;
            this.dgvPhoneNumber.DoubleClick += new System.EventHandler(this.dgvPhoneNumber_DoubleClick);
            // 
            // NameBox
            // 
            this.NameBox.Location = new System.Drawing.Point(51, 74);
            this.NameBox.Multiline = true;
            this.NameBox.Name = "NameBox";
            this.NameBox.Size = new System.Drawing.Size(411, 35);
            this.NameBox.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Palatino Linotype", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(43, 112);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(254, 47);
            this.label2.TabIndex = 5;
            this.label2.Text = "PhoneNumber";
            // 
            // NumberBox
            // 
            this.NumberBox.Location = new System.Drawing.Point(51, 162);
            this.NumberBox.Multiline = true;
            this.NumberBox.Name = "NumberBox";
            this.NumberBox.Size = new System.Drawing.Size(411, 35);
            this.NumberBox.TabIndex = 6;
            // 
            // DescBox
            // 
            this.DescBox.Location = new System.Drawing.Point(51, 250);
            this.DescBox.Multiline = true;
            this.DescBox.Name = "DescBox";
            this.DescBox.Size = new System.Drawing.Size(411, 147);
            this.DescBox.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Palatino Linotype", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(43, 200);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(206, 47);
            this.label3.TabIndex = 7;
            this.label3.Text = "Description";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Palatino Linotype", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(43, 400);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(258, 47);
            this.label4.TabIndex = 9;
            this.label4.Text = "GroupNumber";
            // 
            // GroupBox
            // 
            this.GroupBox.Location = new System.Drawing.Point(51, 450);
            this.GroupBox.Multiline = true;
            this.GroupBox.Name = "GroupBox";
            this.GroupBox.Size = new System.Drawing.Size(411, 101);
            this.GroupBox.TabIndex = 10;
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnSave.Font = new System.Drawing.Font("굴림", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnSave.Location = new System.Drawing.Point(51, 568);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(133, 43);
            this.btnSave.TabIndex = 11;
            this.btnSave.Text = "SAVE";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.Tomato;
            this.btnDelete.Font = new System.Drawing.Font("굴림", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnDelete.Location = new System.Drawing.Point(190, 568);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(133, 43);
            this.btnDelete.TabIndex = 12;
            this.btnDelete.Text = "DELETE";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.Silver;
            this.btnCancel.Font = new System.Drawing.Font("굴림", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnCancel.Location = new System.Drawing.Point(329, 568);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(133, 43);
            this.btnCancel.TabIndex = 13;
            this.btnCancel.Text = "CANCEL";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // SearchBox
            // 
            this.SearchBox.Location = new System.Drawing.Point(499, 74);
            this.SearchBox.Multiline = true;
            this.SearchBox.Name = "SearchBox";
            this.SearchBox.Size = new System.Drawing.Size(318, 35);
            this.SearchBox.TabIndex = 14;
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnSearch.Font = new System.Drawing.Font("굴림", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnSearch.Location = new System.Drawing.Point(837, 64);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(133, 54);
            this.btnSearch.TabIndex = 15;
            this.btnSearch.Text = "SEARCH";
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.SystemColors.Control;
            this.label5.Font = new System.Drawing.Font("Gill Sans MT", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(352, 24);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(287, 38);
            this.label5.TabIndex = 16;
            this.label5.Text = "Telephone Book App";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1000, 652);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.SearchBox);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.GroupBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.DescBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.NumberBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.NameBox);
            this.Controls.Add(this.dgvPhoneNumber);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "MySql CRUD App";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPhoneNumber)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvPhoneNumber;
        private System.Windows.Forms.TextBox NameBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox NumberBox;
        private System.Windows.Forms.TextBox DescBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox GroupBox;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.TextBox SearchBox;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Label label5;
    }
}

