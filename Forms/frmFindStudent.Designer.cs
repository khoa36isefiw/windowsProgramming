namespace _20110375_HuynhDangKhoa_LoginForm
{
    partial class frmFindStudent
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
            this.lbl_StudentID = new System.Windows.Forms.Label();
            this.btn_Find = new System.Windows.Forms.Button();
            this.txtStudentID = new System.Windows.Forms.TextBox();
            this.dataGRV_StudentFound = new System.Windows.Forms.DataGridView();
            this.cboFind = new System.Windows.Forms.ComboBox();
            this.txtFind = new System.Windows.Forms.TextBox();
            this.btnFind2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGRV_StudentFound)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_StudentID
            // 
            this.lbl_StudentID.AutoSize = true;
            this.lbl_StudentID.Location = new System.Drawing.Point(5, 15);
            this.lbl_StudentID.Name = "lbl_StudentID";
            this.lbl_StudentID.Size = new System.Drawing.Size(68, 16);
            this.lbl_StudentID.TabIndex = 0;
            this.lbl_StudentID.Text = "Student ID";
            // 
            // btn_Find
            // 
            this.btn_Find.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(194)))), ((int)(((byte)(233)))));
            this.btn_Find.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Find.Location = new System.Drawing.Point(26, 63);
            this.btn_Find.Name = "btn_Find";
            this.btn_Find.Size = new System.Drawing.Size(117, 57);
            this.btn_Find.TabIndex = 1;
            this.btn_Find.Text = "Find";
            this.btn_Find.UseVisualStyleBackColor = false;
            this.btn_Find.Click += new System.EventHandler(this.btn_Find_Click);
            // 
            // txtStudentID
            // 
            this.txtStudentID.Location = new System.Drawing.Point(91, 12);
            this.txtStudentID.Name = "txtStudentID";
            this.txtStudentID.Size = new System.Drawing.Size(82, 22);
            this.txtStudentID.TabIndex = 2;
            // 
            // dataGRV_StudentFound
            // 
            this.dataGRV_StudentFound.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGRV_StudentFound.Location = new System.Drawing.Point(189, 12);
            this.dataGRV_StudentFound.Name = "dataGRV_StudentFound";
            this.dataGRV_StudentFound.RowHeadersWidth = 51;
            this.dataGRV_StudentFound.RowTemplate.Height = 24;
            this.dataGRV_StudentFound.Size = new System.Drawing.Size(1193, 593);
            this.dataGRV_StudentFound.TabIndex = 3;
            // 
            // cboFind
            // 
            this.cboFind.FormattingEnabled = true;
            this.cboFind.Items.AddRange(new object[] {
            "Student ID"});
            this.cboFind.Location = new System.Drawing.Point(12, 175);
            this.cboFind.Name = "cboFind";
            this.cboFind.Size = new System.Drawing.Size(121, 24);
            this.cboFind.TabIndex = 4;
            // 
            // txtFind
            // 
            this.txtFind.Location = new System.Drawing.Point(6, 217);
            this.txtFind.Name = "txtFind";
            this.txtFind.Size = new System.Drawing.Size(100, 22);
            this.txtFind.TabIndex = 5;
            // 
            // btnFind2
            // 
            this.btnFind2.Location = new System.Drawing.Point(13, 264);
            this.btnFind2.Name = "btnFind2";
            this.btnFind2.Size = new System.Drawing.Size(110, 49);
            this.btnFind2.TabIndex = 6;
            this.btnFind2.Text = "Chạy Đi Luân!";
            this.btnFind2.UseVisualStyleBackColor = true;
            this.btnFind2.Click += new System.EventHandler(this.btnFind2_Click);
            // 
            // frmFindStudent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1394, 617);
            this.Controls.Add(this.btnFind2);
            this.Controls.Add(this.txtFind);
            this.Controls.Add(this.cboFind);
            this.Controls.Add(this.dataGRV_StudentFound);
            this.Controls.Add(this.txtStudentID);
            this.Controls.Add(this.btn_Find);
            this.Controls.Add(this.lbl_StudentID);
            this.Name = "frmFindStudent";
            this.Text = "frmFindStudent";
            this.Load += new System.EventHandler(this.frmFindStudent_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGRV_StudentFound)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_StudentID;
        private System.Windows.Forms.Button btn_Find;
        private System.Windows.Forms.TextBox txtStudentID;
        private System.Windows.Forms.DataGridView dataGRV_StudentFound;
        private System.Windows.Forms.ComboBox cboFind;
        private System.Windows.Forms.TextBox txtFind;
        private System.Windows.Forms.Button btnFind2;
    }
}