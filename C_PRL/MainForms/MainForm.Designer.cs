namespace C_PRL.MainForms
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            pn_show = new Panel();
            btn_sanpham = new Button();
            flp_chucnang = new FlowLayoutPanel();
            btn_BanHang = new Button();
            btn_QL_Nhanvien = new Button();
            btn_QL_Calam = new Button();
            btn_QL_Hoadon = new Button();
            btn_QL_Khuyenmai = new Button();
            btn_QLBan = new Button();
            btn_logout = new Button();
            panel1 = new Panel();
            pictureBox1 = new PictureBox();
            label1 = new Label();
            flp_chucnang.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pn_show
            // 
            pn_show.BackColor = Color.MistyRose;
            pn_show.Location = new Point(282, 2);
            pn_show.Name = "pn_show";
            pn_show.Size = new Size(1225, 642);
            pn_show.TabIndex = 6;
            // 
            // btn_sanpham
            // 
            btn_sanpham.FlatStyle = FlatStyle.Flat;
            btn_sanpham.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold | FontStyle.Italic | FontStyle.Underline, GraphicsUnit.Point);
            btn_sanpham.Location = new Point(3, 58);
            btn_sanpham.Name = "btn_sanpham";
            btn_sanpham.Size = new Size(272, 49);
            btn_sanpham.TabIndex = 0;
            btn_sanpham.Text = "Sản Phẩm";
            btn_sanpham.UseVisualStyleBackColor = true;
            btn_sanpham.Click += pn_SanPham_Click;
            // 
            // flp_chucnang
            // 
            flp_chucnang.BackColor = Color.FromArgb(128, 255, 128);
            flp_chucnang.Controls.Add(btn_BanHang);
            flp_chucnang.Controls.Add(btn_sanpham);
            flp_chucnang.Controls.Add(btn_QL_Nhanvien);
            flp_chucnang.Controls.Add(btn_QL_Calam);
            flp_chucnang.Controls.Add(btn_QL_Hoadon);
            flp_chucnang.Controls.Add(btn_QL_Khuyenmai);
            flp_chucnang.Controls.Add(btn_QLBan);
            flp_chucnang.Controls.Add(btn_logout);
            flp_chucnang.Location = new Point(1, 179);
            flp_chucnang.Name = "flp_chucnang";
            flp_chucnang.Size = new Size(275, 465);
            flp_chucnang.TabIndex = 7;
            // 
            // btn_BanHang
            // 
            btn_BanHang.FlatStyle = FlatStyle.Flat;
            btn_BanHang.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold | FontStyle.Italic | FontStyle.Underline, GraphicsUnit.Point);
            btn_BanHang.Location = new Point(3, 3);
            btn_BanHang.Name = "btn_BanHang";
            btn_BanHang.Size = new Size(272, 49);
            btn_BanHang.TabIndex = 3;
            btn_BanHang.Text = "Bán hàng";
            btn_BanHang.UseVisualStyleBackColor = true;
            btn_BanHang.Click += btn_BanHang_Click;
            // 
            // btn_QL_Nhanvien
            // 
            btn_QL_Nhanvien.FlatStyle = FlatStyle.Flat;
            btn_QL_Nhanvien.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold | FontStyle.Italic | FontStyle.Underline, GraphicsUnit.Point);
            btn_QL_Nhanvien.Location = new Point(3, 113);
            btn_QL_Nhanvien.Name = "btn_QL_Nhanvien";
            btn_QL_Nhanvien.Size = new Size(272, 49);
            btn_QL_Nhanvien.TabIndex = 1;
            btn_QL_Nhanvien.Text = "Nhân Viên";
            btn_QL_Nhanvien.UseVisualStyleBackColor = true;
            btn_QL_Nhanvien.Click += btn_QL_Nhanvien_Click;
            // 
            // btn_QL_Calam
            // 
            btn_QL_Calam.FlatStyle = FlatStyle.Flat;
            btn_QL_Calam.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold | FontStyle.Italic | FontStyle.Underline, GraphicsUnit.Point);
            btn_QL_Calam.Location = new Point(3, 168);
            btn_QL_Calam.Name = "btn_QL_Calam";
            btn_QL_Calam.Size = new Size(272, 49);
            btn_QL_Calam.TabIndex = 2;
            btn_QL_Calam.Text = "Chấm Công";
            btn_QL_Calam.UseVisualStyleBackColor = true;
            btn_QL_Calam.Click += btn_QL_Calam_Click;
            // 
            // btn_QL_Hoadon
            // 
            btn_QL_Hoadon.FlatStyle = FlatStyle.Flat;
            btn_QL_Hoadon.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold | FontStyle.Italic | FontStyle.Underline, GraphicsUnit.Point);
            btn_QL_Hoadon.Location = new Point(3, 223);
            btn_QL_Hoadon.Name = "btn_QL_Hoadon";
            btn_QL_Hoadon.Size = new Size(272, 49);
            btn_QL_Hoadon.TabIndex = 4;
            btn_QL_Hoadon.Text = "Hoá đơn";
            btn_QL_Hoadon.UseVisualStyleBackColor = true;
            btn_QL_Hoadon.Click += btn_QL_Hoadon_Click;
            // 
            // btn_QL_Khuyenmai
            // 
            btn_QL_Khuyenmai.FlatStyle = FlatStyle.Flat;
            btn_QL_Khuyenmai.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold | FontStyle.Italic | FontStyle.Underline, GraphicsUnit.Point);
            btn_QL_Khuyenmai.Location = new Point(3, 278);
            btn_QL_Khuyenmai.Name = "btn_QL_Khuyenmai";
            btn_QL_Khuyenmai.Size = new Size(272, 49);
            btn_QL_Khuyenmai.TabIndex = 5;
            btn_QL_Khuyenmai.Text = "Khuyến mãi";
            btn_QL_Khuyenmai.UseVisualStyleBackColor = true;
            btn_QL_Khuyenmai.Click += btn_QL_Khuyenmai_Click;
            // 
            // btn_QLBan
            // 
            btn_QLBan.FlatStyle = FlatStyle.Flat;
            btn_QLBan.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold | FontStyle.Italic | FontStyle.Underline, GraphicsUnit.Point);
            btn_QLBan.Location = new Point(3, 333);
            btn_QLBan.Name = "btn_QLBan";
            btn_QLBan.Size = new Size(272, 49);
            btn_QLBan.TabIndex = 6;
            btn_QLBan.Text = "Bàn";
            btn_QLBan.UseVisualStyleBackColor = true;
            btn_QLBan.Click += btn_QLBan_Click;
            // 
            // btn_logout
            // 
            btn_logout.FlatStyle = FlatStyle.Flat;
            btn_logout.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold | FontStyle.Italic | FontStyle.Underline, GraphicsUnit.Point);
            btn_logout.Location = new Point(3, 388);
            btn_logout.Name = "btn_logout";
            btn_logout.Size = new Size(272, 49);
            btn_logout.TabIndex = 7;
            btn_logout.Text = "Đăng xuất";
            btn_logout.UseVisualStyleBackColor = true;
            btn_logout.Click += btn_logout_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.LightSalmon;
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(1, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(275, 174);
            panel1.TabIndex = 8;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(3, 3);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(219, 112);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Snap ITC", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(43, 124);
            label1.Name = "label1";
            label1.Size = new Size(222, 36);
            label1.TabIndex = 0;
            label1.Text = "Coffee Time";
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1508, 647);
            Controls.Add(pn_show);
            Controls.Add(flp_chucnang);
            Controls.Add(panel1);
            Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            Name = "MainForm";
            Text = "Coffew";
            Load += MainForm_Load;
            flp_chucnang.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel pn_show;
        private Button btn_sanpham;
        private FlowLayoutPanel flp_chucnang;
        private Button btn_BanHang;
        private Button btn_QL_Nhanvien;
        private Button btn_QL_Calam;
        private Button btn_QL_Hoadon;
        private Button btn_QL_Khuyenmai;
        private Button btn_QLBan;
        private Button btn_logout;
        private Panel panel1;
        private PictureBox pictureBox1;
        private Label label1;
    }
}