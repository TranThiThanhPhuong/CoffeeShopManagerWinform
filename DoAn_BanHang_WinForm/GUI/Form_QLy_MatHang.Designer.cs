
namespace GUI
{
    partial class Form_QLy_MatHang
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dtgv_MatHang = new System.Windows.Forms.DataGridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.theLoaiBindingSource3 = new System.Windows.Forms.BindingSource(this.components);
            this.dataSet_HangHoa1 = new GUI.DataSet_HangHoa();
            this.txtHinhAnh = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtMaMH = new System.Windows.Forms.TextBox();
            this.txtMaLoai = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btn_LamMoi = new GUI.CT_Button();
            this.btnSuaHangHoa = new GUI.CT_Button();
            this.btnXoaHangHoa = new GUI.CT_Button();
            this.btnThemHangHoa = new GUI.CT_Button();
            this.btn_ThemHinhAnh = new GUI.CT_Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtGiaTien = new System.Windows.Forms.TextBox();
            this.txtTenMatHang = new System.Windows.Forms.TextBox();
            this.theLoaiBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.theLoaiBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.dataSet_HangHoa = new GUI.DataSet_HangHoa();
            this.matHangBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.matHangTableAdapter = new GUI.DataSet_HangHoaTableAdapters.MatHangTableAdapter();
            this.theLoaiBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.theLoaiTableAdapter = new GUI.DataSet_HangHoaTableAdapters.TheLoaiTableAdapter();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgv_MatHang)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.theLoaiBindingSource3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet_HangHoa1)).BeginInit();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.theLoaiBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.theLoaiBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet_HangHoa)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.matHangBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.theLoaiBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dtgv_MatHang);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Left;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Size = new System.Drawing.Size(1038, 837);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Mặt Hàng";
            // 
            // dtgv_MatHang
            // 
            this.dtgv_MatHang.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgv_MatHang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgv_MatHang.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtgv_MatHang.Location = new System.Drawing.Point(4, 24);
            this.dtgv_MatHang.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dtgv_MatHang.Name = "dtgv_MatHang";
            this.dtgv_MatHang.RowHeadersWidth = 62;
            this.dtgv_MatHang.Size = new System.Drawing.Size(1030, 808);
            this.dtgv_MatHang.TabIndex = 0;
            this.dtgv_MatHang.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgv_MatHang_CellContentClick);
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.groupBox2.Controls.Add(this.comboBox1);
            this.groupBox2.Controls.Add(this.txtHinhAnh);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.txtMaMH);
            this.groupBox2.Controls.Add(this.txtMaLoai);
            this.groupBox2.Controls.Add(this.groupBox3);
            this.groupBox2.Controls.Add(this.btn_ThemHinhAnh);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.txtGiaTien);
            this.groupBox2.Controls.Add(this.txtTenMatHang);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Right;
            this.groupBox2.Location = new System.Drawing.Point(1059, 0);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox2.Size = new System.Drawing.Size(513, 837);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Chức năng";
            // 
            // comboBox1
            // 
            this.comboBox1.DataSource = this.theLoaiBindingSource3;
            this.comboBox1.DisplayMember = "TenTheLoai";
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(194, 243);
            this.comboBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(180, 28);
            this.comboBox1.TabIndex = 14;
            this.comboBox1.ValueMember = "TenTheLoai";
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // theLoaiBindingSource3
            // 
            this.theLoaiBindingSource3.DataMember = "TheLoai";
            this.theLoaiBindingSource3.DataSource = this.dataSet_HangHoa1;
            // 
            // dataSet_HangHoa1
            // 
            this.dataSet_HangHoa1.DataSetName = "DataSet_HangHoa";
            this.dataSet_HangHoa1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // txtHinhAnh
            // 
            this.txtHinhAnh.Location = new System.Drawing.Point(194, 374);
            this.txtHinhAnh.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtHinhAnh.Name = "txtHinhAnh";
            this.txtHinhAnh.Size = new System.Drawing.Size(270, 26);
            this.txtHinhAnh.TabIndex = 13;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(51, 38);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(125, 23);
            this.label5.TabIndex = 12;
            this.label5.Text = "Mã mặt hàng";
            // 
            // txtMaMH
            // 
            this.txtMaMH.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaMH.Location = new System.Drawing.Point(194, 29);
            this.txtMaMH.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtMaMH.Name = "txtMaMH";
            this.txtMaMH.Size = new System.Drawing.Size(270, 30);
            this.txtMaMH.TabIndex = 11;
            // 
            // txtMaLoai
            // 
            this.txtMaLoai.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaLoai.Location = new System.Drawing.Point(194, 303);
            this.txtMaLoai.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtMaLoai.Name = "txtMaLoai";
            this.txtMaLoai.Size = new System.Drawing.Size(180, 30);
            this.txtMaLoai.TabIndex = 10;
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.SystemColors.ControlLight;
            this.groupBox3.Controls.Add(this.btn_LamMoi);
            this.groupBox3.Controls.Add(this.btnSuaHangHoa);
            this.groupBox3.Controls.Add(this.btnXoaHangHoa);
            this.groupBox3.Controls.Add(this.btnThemHangHoa);
            this.groupBox3.Location = new System.Drawing.Point(9, 588);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox3.Size = new System.Drawing.Size(495, 131);
            this.groupBox3.TabIndex = 9;
            this.groupBox3.TabStop = false;
            // 
            // btn_LamMoi
            // 
            this.btn_LamMoi.BackColor = System.Drawing.Color.LightSteelBlue;
            this.btn_LamMoi.BackgroundColor = System.Drawing.Color.LightSteelBlue;
            this.btn_LamMoi.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btn_LamMoi.BorderRadius = 7;
            this.btn_LamMoi.BorderSize = 0;
            this.btn_LamMoi.FlatAppearance.BorderSize = 0;
            this.btn_LamMoi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_LamMoi.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_LamMoi.ForeColor = System.Drawing.Color.White;
            this.btn_LamMoi.Location = new System.Drawing.Point(384, 29);
            this.btn_LamMoi.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_LamMoi.Name = "btn_LamMoi";
            this.btn_LamMoi.Size = new System.Drawing.Size(102, 62);
            this.btn_LamMoi.TabIndex = 13;
            this.btn_LamMoi.Text = "Làm mới";
            this.btn_LamMoi.TextColor = System.Drawing.Color.White;
            this.btn_LamMoi.UseVisualStyleBackColor = false;
            this.btn_LamMoi.Click += new System.EventHandler(this.btn_LamMoi_Click);
            // 
            // btnSuaHangHoa
            // 
            this.btnSuaHangHoa.BackColor = System.Drawing.Color.LightSteelBlue;
            this.btnSuaHangHoa.BackgroundColor = System.Drawing.Color.LightSteelBlue;
            this.btnSuaHangHoa.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnSuaHangHoa.BorderRadius = 7;
            this.btnSuaHangHoa.BorderSize = 0;
            this.btnSuaHangHoa.FlatAppearance.BorderSize = 0;
            this.btnSuaHangHoa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSuaHangHoa.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSuaHangHoa.ForeColor = System.Drawing.Color.White;
            this.btnSuaHangHoa.Location = new System.Drawing.Point(261, 29);
            this.btnSuaHangHoa.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnSuaHangHoa.Name = "btnSuaHangHoa";
            this.btnSuaHangHoa.Size = new System.Drawing.Size(102, 62);
            this.btnSuaHangHoa.TabIndex = 12;
            this.btnSuaHangHoa.Text = "Sửa";
            this.btnSuaHangHoa.TextColor = System.Drawing.Color.White;
            this.btnSuaHangHoa.UseVisualStyleBackColor = false;
            this.btnSuaHangHoa.Click += new System.EventHandler(this.btnSuaHangHoa_Click);
            // 
            // btnXoaHangHoa
            // 
            this.btnXoaHangHoa.BackColor = System.Drawing.Color.LightSteelBlue;
            this.btnXoaHangHoa.BackgroundColor = System.Drawing.Color.LightSteelBlue;
            this.btnXoaHangHoa.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnXoaHangHoa.BorderRadius = 7;
            this.btnXoaHangHoa.BorderSize = 0;
            this.btnXoaHangHoa.FlatAppearance.BorderSize = 0;
            this.btnXoaHangHoa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnXoaHangHoa.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoaHangHoa.ForeColor = System.Drawing.Color.White;
            this.btnXoaHangHoa.Location = new System.Drawing.Point(135, 29);
            this.btnXoaHangHoa.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnXoaHangHoa.Name = "btnXoaHangHoa";
            this.btnXoaHangHoa.Size = new System.Drawing.Size(102, 62);
            this.btnXoaHangHoa.TabIndex = 11;
            this.btnXoaHangHoa.Text = "Xóa";
            this.btnXoaHangHoa.TextColor = System.Drawing.Color.White;
            this.btnXoaHangHoa.UseVisualStyleBackColor = false;
            this.btnXoaHangHoa.Click += new System.EventHandler(this.btnXoaHangHoa_Click);
            // 
            // btnThemHangHoa
            // 
            this.btnThemHangHoa.BackColor = System.Drawing.Color.LightSteelBlue;
            this.btnThemHangHoa.BackgroundColor = System.Drawing.Color.LightSteelBlue;
            this.btnThemHangHoa.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnThemHangHoa.BorderRadius = 7;
            this.btnThemHangHoa.BorderSize = 0;
            this.btnThemHangHoa.FlatAppearance.BorderSize = 0;
            this.btnThemHangHoa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThemHangHoa.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThemHangHoa.ForeColor = System.Drawing.Color.White;
            this.btnThemHangHoa.Location = new System.Drawing.Point(9, 29);
            this.btnThemHangHoa.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnThemHangHoa.Name = "btnThemHangHoa";
            this.btnThemHangHoa.Size = new System.Drawing.Size(102, 62);
            this.btnThemHangHoa.TabIndex = 10;
            this.btnThemHangHoa.Text = "Thêm";
            this.btnThemHangHoa.TextColor = System.Drawing.Color.White;
            this.btnThemHangHoa.UseVisualStyleBackColor = false;
            this.btnThemHangHoa.Click += new System.EventHandler(this.btnThemHangHoa_Click);
            // 
            // btn_ThemHinhAnh
            // 
            this.btn_ThemHinhAnh.BackColor = System.Drawing.Color.LightSteelBlue;
            this.btn_ThemHinhAnh.BackgroundColor = System.Drawing.Color.LightSteelBlue;
            this.btn_ThemHinhAnh.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btn_ThemHinhAnh.BorderRadius = 7;
            this.btn_ThemHinhAnh.BorderSize = 0;
            this.btn_ThemHinhAnh.FlatAppearance.BorderSize = 0;
            this.btn_ThemHinhAnh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_ThemHinhAnh.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ThemHinhAnh.ForeColor = System.Drawing.Color.White;
            this.btn_ThemHinhAnh.Location = new System.Drawing.Point(194, 437);
            this.btn_ThemHinhAnh.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_ThemHinhAnh.Name = "btn_ThemHinhAnh";
            this.btn_ThemHinhAnh.Size = new System.Drawing.Size(184, 62);
            this.btn_ThemHinhAnh.TabIndex = 8;
            this.btn_ThemHinhAnh.Text = "Hình ảnh";
            this.btn_ThemHinhAnh.TextColor = System.Drawing.Color.White;
            this.btn_ThemHinhAnh.UseVisualStyleBackColor = false;
            this.btn_ThemHinhAnh.Click += new System.EventHandler(this.btn_ThemHinhAnh_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(56, 243);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(79, 23);
            this.label4.TabIndex = 6;
            this.label4.Text = "Tên loại";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(56, 311);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 23);
            this.label3.TabIndex = 5;
            this.label3.Text = "Mã loại";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(56, 169);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 23);
            this.label2.TabIndex = 4;
            this.label2.Text = "Giá Tiền";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(51, 100);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(130, 23);
            this.label1.TabIndex = 3;
            this.label1.Text = "Tên mặt hàng";
            // 
            // txtGiaTien
            // 
            this.txtGiaTien.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGiaTien.Location = new System.Drawing.Point(194, 160);
            this.txtGiaTien.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtGiaTien.Name = "txtGiaTien";
            this.txtGiaTien.Size = new System.Drawing.Size(270, 30);
            this.txtGiaTien.TabIndex = 2;
            // 
            // txtTenMatHang
            // 
            this.txtTenMatHang.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTenMatHang.Location = new System.Drawing.Point(194, 91);
            this.txtTenMatHang.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtTenMatHang.Name = "txtTenMatHang";
            this.txtTenMatHang.Size = new System.Drawing.Size(270, 30);
            this.txtTenMatHang.TabIndex = 0;
            // 
            // theLoaiBindingSource2
            // 
            this.theLoaiBindingSource2.DataMember = "TheLoai";
            this.theLoaiBindingSource2.DataSource = this.dataSet_HangHoa1;
            // 
            // theLoaiBindingSource1
            // 
            this.theLoaiBindingSource1.DataMember = "TheLoai";
            this.theLoaiBindingSource1.DataSource = this.dataSet_HangHoa1;
            // 
            // dataSet_HangHoa
            // 
            this.dataSet_HangHoa.DataSetName = "DataSet_HangHoa";
            this.dataSet_HangHoa.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // matHangBindingSource
            // 
            this.matHangBindingSource.DataMember = "MatHang";
            this.matHangBindingSource.DataSource = this.dataSet_HangHoa;
            // 
            // matHangTableAdapter
            // 
            this.matHangTableAdapter.ClearBeforeFill = true;
            // 
            // theLoaiBindingSource
            // 
            this.theLoaiBindingSource.DataMember = "TheLoai";
            this.theLoaiBindingSource.DataSource = this.dataSet_HangHoa;
            // 
            // theLoaiTableAdapter
            // 
            this.theLoaiTableAdapter.ClearBeforeFill = true;
            // 
            // Form_QLy_MatHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1572, 837);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximumSize = new System.Drawing.Size(1594, 893);
            this.MinimumSize = new System.Drawing.Size(1594, 893);
            this.Name = "Form_QLy_MatHang";
            this.Text = "Form_QLy_MatHang";
            this.Load += new System.EventHandler(this.Form_QLy_MatHang_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgv_MatHang)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.theLoaiBindingSource3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet_HangHoa1)).EndInit();
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.theLoaiBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.theLoaiBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet_HangHoa)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.matHangBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.theLoaiBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtGiaTien;
        private System.Windows.Forms.TextBox txtTenMatHang;
        private CT_Button btn_ThemHinhAnh;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private DataSet_HangHoa dataSet_HangHoa;
        private System.Windows.Forms.BindingSource matHangBindingSource;
        private DataSet_HangHoaTableAdapters.MatHangTableAdapter matHangTableAdapter;
        private System.Windows.Forms.BindingSource theLoaiBindingSource;
        private DataSet_HangHoaTableAdapters.TheLoaiTableAdapter theLoaiTableAdapter;
        private System.Windows.Forms.GroupBox groupBox3;
        private CT_Button btnSuaHangHoa;
        private CT_Button btnXoaHangHoa;
        private CT_Button btnThemHangHoa;
        private DataSet_HangHoa dataSet_HangHoa1;
        private System.Windows.Forms.BindingSource theLoaiBindingSource1;
        private System.Windows.Forms.TextBox txtMaLoai;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtMaMH;
        private System.Windows.Forms.BindingSource theLoaiBindingSource2;
        private System.Windows.Forms.TextBox txtHinhAnh;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.BindingSource theLoaiBindingSource3;
        private System.Windows.Forms.DataGridView dtgv_MatHang;
        private CT_Button btn_LamMoi;
    }
}