namespace TRANMINHHUAN_6551071032_VP102_LTTQ
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            btnThoat = new Button();
            groupBox1 = new GroupBox();
            dataGridView1 = new DataGridView();
            txtMaSinhVien = new DataGridViewTextBoxColumn();
            txtTenSinhVien = new DataGridViewTextBoxColumn();
            txtDiemTrungBinh = new DataGridViewTextBoxColumn();
            sinhVienBindingSource = new BindingSource(components);
            groupBox2 = new GroupBox();
            txtTen = new TextBox();
            txtDTB = new TextBox();
            txtMSSV = new TextBox();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            btnXoa = new Button();
            btnSua = new Button();
            btnThem = new Button();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)sinhVienBindingSource).BeginInit();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // btnThoat
            // 
            btnThoat.Location = new Point(458, 42);
            btnThoat.Name = "btnThoat";
            btnThoat.Size = new Size(94, 29);
            btnThoat.TabIndex = 3;
            btnThoat.Text = "Thoát";
            btnThoat.UseVisualStyleBackColor = true;
            btnThoat.Click += btnThoat_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(dataGridView1);
            groupBox1.Location = new Point(37, 95);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(473, 312);
            groupBox1.TabIndex = 4;
            groupBox1.TabStop = false;
            groupBox1.Text = "Danh sách sinh viên";
            // 
            // dataGridView1
            // 
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { txtMaSinhVien, txtTenSinhVien, txtDiemTrungBinh });
            dataGridView1.DataSource = sinhVienBindingSource;
            dataGridView1.Location = new Point(0, 26);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(473, 286);
            dataGridView1.TabIndex = 0;
            // 
            // txtMaSinhVien
            // 
            txtMaSinhVien.DataPropertyName = "MaSinhVien";
            txtMaSinhVien.HeaderText = "MaSinhVien";
            txtMaSinhVien.MinimumWidth = 6;
            txtMaSinhVien.Name = "txtMaSinhVien";
            txtMaSinhVien.Width = 125;
            // 
            // txtTenSinhVien
            // 
            txtTenSinhVien.DataPropertyName = "TenSinhVien";
            txtTenSinhVien.HeaderText = "TenSinhVien";
            txtTenSinhVien.MinimumWidth = 6;
            txtTenSinhVien.Name = "txtTenSinhVien";
            txtTenSinhVien.Width = 125;
            // 
            // txtDiemTrungBinh
            // 
            txtDiemTrungBinh.DataPropertyName = "DiemTrungBinh";
            txtDiemTrungBinh.HeaderText = "DiemTrungBinh";
            txtDiemTrungBinh.MinimumWidth = 6;
            txtDiemTrungBinh.Name = "txtDiemTrungBinh";
            txtDiemTrungBinh.Width = 125;
            // 
            // sinhVienBindingSource
            // 
            sinhVienBindingSource.DataSource = typeof(Models.SinhVien);
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(txtTen);
            groupBox2.Controls.Add(txtDTB);
            groupBox2.Controls.Add(txtMSSV);
            groupBox2.Controls.Add(label3);
            groupBox2.Controls.Add(label2);
            groupBox2.Controls.Add(label1);
            groupBox2.Location = new Point(516, 95);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(249, 247);
            groupBox2.TabIndex = 5;
            groupBox2.TabStop = false;
            groupBox2.Text = "Thông tin sinh viên";
            // 
            // txtTen
            // 
            txtTen.Location = new Point(26, 110);
            txtTen.Name = "txtTen";
            txtTen.Size = new Size(197, 27);
            txtTen.TabIndex = 6;
            // 
            // txtDTB
            // 
            txtDTB.Location = new Point(25, 166);
            txtDTB.Name = "txtDTB";
            txtDTB.Size = new Size(198, 27);
            txtDTB.TabIndex = 5;
            // 
            // txtMSSV
            // 
            txtMSSV.Location = new Point(26, 60);
            txtMSSV.Name = "txtMSSV";
            txtMSSV.Size = new Size(197, 27);
            txtMSSV.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(25, 143);
            label3.Name = "label3";
            label3.Size = new Size(117, 20);
            label3.TabIndex = 2;
            label3.Text = "Điểm trung bình";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(26, 90);
            label2.Name = "label2";
            label2.Size = new Size(93, 20);
            label2.TabIndex = 1;
            label2.Text = "Tên sinh viên";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(25, 37);
            label1.Name = "label1";
            label1.Size = new Size(94, 20);
            label1.TabIndex = 0;
            label1.Text = "Mã sinh viên:";
            // 
            // btnXoa
            // 
            btnXoa.Location = new Point(325, 42);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(94, 29);
            btnXoa.TabIndex = 6;
            btnXoa.Text = "Xóa";
            btnXoa.UseVisualStyleBackColor = true;
            // 
            // btnSua
            // 
            btnSua.Location = new Point(198, 42);
            btnSua.Name = "btnSua";
            btnSua.Size = new Size(94, 29);
            btnSua.TabIndex = 7;
            btnSua.Text = "Sửa";
            btnSua.UseVisualStyleBackColor = true;
            btnSua.Click += btnSua_Click;
            // 
            // btnThem
            // 
            btnThem.Location = new Point(77, 42);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(94, 29);
            btnThem.TabIndex = 8;
            btnThem.Text = "Thêm";
            btnThem.UseVisualStyleBackColor = true;
            btnThem.Click += btnThem_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnThem);
            Controls.Add(btnSua);
            Controls.Add(btnXoa);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(btnThoat);
            Name = "Form1";
            Text = "Form1";
            Activated += Form1_Load;
            groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)sinhVienBindingSource).EndInit();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Button button1;
        private Button button2;
        private Button button3;
        private Button btnThoat;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private TextBox txtDTB;
        private TextBox textBox2;
        private TextBox txtMSSV;
        private Label label3;
        private Label label2;
        private Label label1;
        private ContextMenuStrip contextMenuStrip1;
        private ToolStripMenuItem toolStripMenuItem1;
        private ToolStripTextBox toolStripTextBox1;
        private Button btnXoa;
        private Button btnSua;
        private Button btnThem;
        private DataGridView dataGridView1;
        private BindingSource sinhVienBindingSource;
        private DataGridViewTextBoxColumn txtMaSinhVien;
        private DataGridViewTextBoxColumn txtTenSinhVien;
        private DataGridViewTextBoxColumn txtDiemTrungBinh;
        private TextBox txtTen;
    }
}
