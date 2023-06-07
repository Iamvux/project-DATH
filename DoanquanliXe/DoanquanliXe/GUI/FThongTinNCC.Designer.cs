namespace DoanquanliXe
{
    partial class FThongTinNCC
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FThongTinNCC));
            this.labTen = new System.Windows.Forms.Label();
            this.labMa = new System.Windows.Forms.Label();
            this.txtTenNCC = new System.Windows.Forms.TextBox();
            this.dgvTTNCC = new System.Windows.Forms.DataGridView();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnTBao = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtSDT = new System.Windows.Forms.TextBox();
            this.txtDiaChi = new System.Windows.Forms.TextBox();
            this.btnTim = new System.Windows.Forms.Button();
            this.txtTimKiem = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cbbTimKiem = new System.Windows.Forms.ComboBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.btnBack = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.radTang = new System.Windows.Forms.RadioButton();
            this.radGiam = new System.Windows.Forms.RadioButton();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.txtMaNCC = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTTNCC)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // labTen
            // 
            this.labTen.AutoSize = true;
            this.labTen.Location = new System.Drawing.Point(32, 89);
            this.labTen.Name = "labTen";
            this.labTen.Size = new System.Drawing.Size(110, 15);
            this.labTen.TabIndex = 0;
            this.labTen.Text = "Tên Nhà Cung Cấp";
            // 
            // labMa
            // 
            this.labMa.AutoSize = true;
            this.labMa.Location = new System.Drawing.Point(32, 55);
            this.labMa.Name = "labMa";
            this.labMa.Size = new System.Drawing.Size(106, 15);
            this.labMa.TabIndex = 1;
            this.labMa.Text = "Mã Nhà Cung Cấp";
            // 
            // txtTenNCC
            // 
            this.txtTenNCC.Location = new System.Drawing.Point(161, 83);
            this.txtTenNCC.Name = "txtTenNCC";
            this.txtTenNCC.Size = new System.Drawing.Size(128, 22);
            this.txtTenNCC.TabIndex = 6;
            // 
            // dgvTTNCC
            // 
            this.dgvTTNCC.AllowUserToAddRows = false;
            this.dgvTTNCC.AllowUserToDeleteRows = false;
            this.dgvTTNCC.AllowUserToResizeColumns = false;
            this.dgvTTNCC.AllowUserToResizeRows = false;
            this.dgvTTNCC.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dgvTTNCC.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTTNCC.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4});
            this.dgvTTNCC.Cursor = System.Windows.Forms.Cursors.Default;
            this.dgvTTNCC.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgvTTNCC.Location = new System.Drawing.Point(0, 331);
            this.dgvTTNCC.Name = "dgvTTNCC";
            this.dgvTTNCC.ReadOnly = true;
            this.dgvTTNCC.RowHeadersWidth = 51;
            this.dgvTTNCC.RowTemplate.Height = 24;
            this.dgvTTNCC.Size = new System.Drawing.Size(1177, 230);
            this.dgvTTNCC.TabIndex = 12;
            this.dgvTTNCC.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvTTNCC_CellClick);
            // 
            // btnThem
            // 
            this.btnThem.Image = ((System.Drawing.Image)(resources.GetObject("btnThem.Image")));
            this.btnThem.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnThem.Location = new System.Drawing.Point(21, 29);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(107, 36);
            this.btnThem.TabIndex = 15;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Image = ((System.Drawing.Image)(resources.GetObject("btnXoa.Image")));
            this.btnXoa.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnXoa.Location = new System.Drawing.Point(161, 29);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(108, 36);
            this.btnXoa.TabIndex = 16;
            this.btnXoa.Text = "Xoá";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnSua
            // 
            this.btnSua.Image = ((System.Drawing.Image)(resources.GetObject("btnSua.Image")));
            this.btnSua.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSua.Location = new System.Drawing.Point(306, 29);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(96, 36);
            this.btnSua.TabIndex = 17;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnTBao
            // 
            this.btnTBao.Image = ((System.Drawing.Image)(resources.GetObject("btnTBao.Image")));
            this.btnTBao.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnTBao.Location = new System.Drawing.Point(436, 29);
            this.btnTBao.Name = "btnTBao";
            this.btnTBao.Size = new System.Drawing.Size(117, 36);
            this.btnTBao.TabIndex = 18;
            this.btnTBao.Text = "Thông Báo";
            this.btnTBao.UseVisualStyleBackColor = true;
            this.btnTBao.Click += new System.EventHandler(this.btnTBao_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(36, 127);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 15);
            this.label1.TabIndex = 20;
            this.label1.Text = "Số Điện Thoại";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(36, 158);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 15);
            this.label2.TabIndex = 21;
            this.label2.Text = "Địa Chỉ";
            // 
            // txtSDT
            // 
            this.txtSDT.Location = new System.Drawing.Point(161, 123);
            this.txtSDT.Name = "txtSDT";
            this.txtSDT.Size = new System.Drawing.Size(128, 22);
            this.txtSDT.TabIndex = 22;
            // 
            // txtDiaChi
            // 
            this.txtDiaChi.Location = new System.Drawing.Point(161, 160);
            this.txtDiaChi.Name = "txtDiaChi";
            this.txtDiaChi.Size = new System.Drawing.Size(128, 22);
            this.txtDiaChi.TabIndex = 23;
            // 
            // btnTim
            // 
            this.btnTim.Image = ((System.Drawing.Image)(resources.GetObject("btnTim.Image")));
            this.btnTim.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnTim.Location = new System.Drawing.Point(329, 29);
            this.btnTim.Name = "btnTim";
            this.btnTim.Size = new System.Drawing.Size(96, 28);
            this.btnTim.TabIndex = 24;
            this.btnTim.Text = "Tìm";
            this.btnTim.UseVisualStyleBackColor = true;
            this.btnTim.Click += new System.EventHandler(this.btnTim_Click);
            // 
            // txtTimKiem
            // 
            this.txtTimKiem.Location = new System.Drawing.Point(170, 35);
            this.txtTimKiem.Name = "txtTimKiem";
            this.txtTimKiem.Size = new System.Drawing.Size(139, 22);
            this.txtTimKiem.TabIndex = 25;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(21, 33);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 15);
            this.label3.TabIndex = 26;
            this.label3.Text = "Tìm Kiếm";
            // 
            // cbbTimKiem
            // 
            this.cbbTimKiem.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbTimKiem.FormattingEnabled = true;
            this.cbbTimKiem.Items.AddRange(new object[] {
            "Mã",
            "Tên",
            "SĐT",
            "Địa Chỉ"});
            this.cbbTimKiem.Location = new System.Drawing.Point(81, 33);
            this.cbbTimKiem.Name = "cbbTimKiem";
            this.cbbTimKiem.Size = new System.Drawing.Size(72, 23);
            this.cbbTimKiem.TabIndex = 27;
            this.cbbTimKiem.SelectedIndexChanged += new System.EventHandler(this.cbbTimKiem_SelectedIndexChanged);
            // 
            // btnBack
            // 
            this.btnBack.Image = ((System.Drawing.Image)(resources.GetObject("btnBack.Image")));
            this.btnBack.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnBack.Location = new System.Drawing.Point(582, 29);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(123, 36);
            this.btnBack.TabIndex = 28;
            this.btnBack.Text = "Quay Về";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(31, 87);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 15);
            this.label4.TabIndex = 29;
            this.label4.Text = "Sắp Xếp";
            // 
            // radTang
            // 
            this.radTang.AutoSize = true;
            this.radTang.Checked = true;
            this.radTang.Location = new System.Drawing.Point(131, 85);
            this.radTang.Name = "radTang";
            this.radTang.Size = new System.Drawing.Size(56, 19);
            this.radTang.TabIndex = 30;
            this.radTang.TabStop = true;
            this.radTang.Text = "Tăng";
            this.radTang.UseVisualStyleBackColor = true;
            // 
            // radGiam
            // 
            this.radGiam.AutoSize = true;
            this.radGiam.Location = new System.Drawing.Point(130, 110);
            this.radGiam.Name = "radGiam";
            this.radGiam.Size = new System.Drawing.Size(57, 19);
            this.radGiam.TabIndex = 31;
            this.radGiam.Text = "Giảm";
            this.radGiam.UseVisualStyleBackColor = true;
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Mã",
            "Tên"});
            this.comboBox1.Location = new System.Drawing.Point(238, 85);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(113, 23);
            this.comboBox1.TabIndex = 32;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // txtMaNCC
            // 
            this.txtMaNCC.Location = new System.Drawing.Point(161, 50);
            this.txtMaNCC.Name = "txtMaNCC";
            this.txtMaNCC.Size = new System.Drawing.Size(128, 22);
            this.txtMaNCC.TabIndex = 33;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtMaNCC);
            this.groupBox1.Controls.Add(this.txtTenNCC);
            this.groupBox1.Controls.Add(this.labTen);
            this.groupBox1.Controls.Add(this.labMa);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtSDT);
            this.groupBox1.Controls.Add(this.txtDiaChi);
            this.groupBox1.Location = new System.Drawing.Point(25, 22);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(316, 262);
            this.groupBox1.TabIndex = 34;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Nhập Thông Tin";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnSua);
            this.groupBox2.Controls.Add(this.btnThem);
            this.groupBox2.Controls.Add(this.btnXoa);
            this.groupBox2.Controls.Add(this.btnTBao);
            this.groupBox2.Controls.Add(this.btnBack);
            this.groupBox2.Location = new System.Drawing.Point(454, 22);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(711, 83);
            this.groupBox2.TabIndex = 35;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Chức Năng";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.txtTimKiem);
            this.groupBox3.Controls.Add(this.btnTim);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.comboBox1);
            this.groupBox3.Controls.Add(this.cbbTimKiem);
            this.groupBox3.Controls.Add(this.radGiam);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.radTang);
            this.groupBox3.Location = new System.Drawing.Point(522, 114);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(448, 159);
            this.groupBox3.TabIndex = 36;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Tìm Kiêm & Sắp Xếp";
            this.groupBox3.Enter += new System.EventHandler(this.groupBox3_Enter);
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "TenNhaCungCap";
            this.Column1.HeaderText = "Tên Nhà Cung Cấp";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Width = 300;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "MaNhaCungCap";
            this.Column2.HeaderText = "Mã Nhà Cung Cấp";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Width = 300;
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "SoDienThoai";
            this.Column3.HeaderText = "Số Điện Thoại";
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            this.Column3.Width = 300;
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "DiaChi";
            this.Column4.HeaderText = "Địa Chỉ";
            this.Column4.MinimumWidth = 6;
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            this.Column4.Width = 300;
            // 
            // FThongTinNCC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.ClientSize = new System.Drawing.Size(1177, 561);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dgvTTNCC);
            this.Font = new System.Drawing.Font("Times New Roman", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FThongTinNCC";
            this.Text = "Thông tin nhà cung cấp";
            this.Load += new System.EventHandler(this.FThongTinNCC_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTTNCC)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label labTen;
        private System.Windows.Forms.Label labMa;
        private System.Windows.Forms.TextBox txtTenNCC;
        private System.Windows.Forms.DataGridView dgvTTNCC;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnTBao;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtSDT;
        private System.Windows.Forms.TextBox txtDiaChi;
        private System.Windows.Forms.Button btnTim;
        private System.Windows.Forms.TextBox txtTimKiem;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbbTimKiem;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RadioButton radTang;
        private System.Windows.Forms.RadioButton radGiam;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.TextBox txtMaNCC;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
    }
}