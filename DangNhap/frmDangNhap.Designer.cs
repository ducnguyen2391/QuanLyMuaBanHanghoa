namespace QuanLyMuaBanHanghoa.DangNhap
{
    partial class frmDangNhap
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
            this.groupBoxDangNhap = new System.Windows.Forms.GroupBox();
            this.cboxremember = new System.Windows.Forms.CheckBox();
            this.txtMatkhau = new System.Windows.Forms.TextBox();
            this.txtTaikhoan = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_frmDN_Thoat = new System.Windows.Forms.Button();
            this.btnDangNhap = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.groupBoxDangNhap.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxDangNhap
            // 
            this.groupBoxDangNhap.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBoxDangNhap.Controls.Add(this.cboxremember);
            this.groupBoxDangNhap.Controls.Add(this.txtMatkhau);
            this.groupBoxDangNhap.Controls.Add(this.txtTaikhoan);
            this.groupBoxDangNhap.Controls.Add(this.label2);
            this.groupBoxDangNhap.Controls.Add(this.label1);
            this.groupBoxDangNhap.Controls.Add(this.btn_frmDN_Thoat);
            this.groupBoxDangNhap.Controls.Add(this.btnDangNhap);
            this.groupBoxDangNhap.Location = new System.Drawing.Point(64, 15);
            this.groupBoxDangNhap.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBoxDangNhap.Name = "groupBoxDangNhap";
            this.groupBoxDangNhap.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBoxDangNhap.Size = new System.Drawing.Size(531, 242);
            this.groupBoxDangNhap.TabIndex = 0;
            this.groupBoxDangNhap.TabStop = false;
            // 
            // cboxremember
            // 
            this.cboxremember.AutoSize = true;
            this.cboxremember.Location = new System.Drawing.Point(128, 135);
            this.cboxremember.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cboxremember.Name = "cboxremember";
            this.cboxremember.Size = new System.Drawing.Size(111, 20);
            this.cboxremember.TabIndex = 3;
            this.cboxremember.Text = "Nhớ mật khẩu";
            this.cboxremember.UseVisualStyleBackColor = true;
            this.cboxremember.CheckedChanged += new System.EventHandler(this.cboxremember_CheckedChanged);
            // 
            // txtMatkhau
            // 
            this.txtMatkhau.Location = new System.Drawing.Point(128, 80);
            this.txtMatkhau.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtMatkhau.Multiline = true;
            this.txtMatkhau.Name = "txtMatkhau";
            this.txtMatkhau.PasswordChar = '*';
            this.txtMatkhau.Size = new System.Drawing.Size(276, 24);
            this.txtMatkhau.TabIndex = 2;
            // 
            // txtTaikhoan
            // 
            this.txtTaikhoan.Location = new System.Drawing.Point(128, 41);
            this.txtTaikhoan.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtTaikhoan.Name = "txtTaikhoan";
            this.txtTaikhoan.Size = new System.Drawing.Size(276, 22);
            this.txtTaikhoan.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 89);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Mật khẩu:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 49);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Tên đăng nhập:";
            // 
            // btn_frmDN_Thoat
            // 
            this.btn_frmDN_Thoat.Location = new System.Drawing.Point(324, 186);
            this.btn_frmDN_Thoat.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_frmDN_Thoat.Name = "btn_frmDN_Thoat";
            this.btn_frmDN_Thoat.Size = new System.Drawing.Size(100, 28);
            this.btn_frmDN_Thoat.TabIndex = 5;
            this.btn_frmDN_Thoat.Text = "Thoát";
            this.btn_frmDN_Thoat.UseVisualStyleBackColor = true;
            this.btn_frmDN_Thoat.Click += new System.EventHandler(this.btn_frmDN_Thoat_Click);
            // 
            // btnDangNhap
            // 
            this.btnDangNhap.Location = new System.Drawing.Point(201, 186);
            this.btnDangNhap.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnDangNhap.Name = "btnDangNhap";
            this.btnDangNhap.Size = new System.Drawing.Size(100, 28);
            this.btnDangNhap.TabIndex = 4;
            this.btnDangNhap.Text = "Đăng nhập";
            this.btnDangNhap.UseVisualStyleBackColor = true;
            this.btnDangNhap.Click += new System.EventHandler(this.btnDangNhap_Click);
            // 
            // frmDangNhap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(612, 334);
            this.Controls.Add(this.groupBoxDangNhap);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "frmDangNhap";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Thông tin đăng nhập";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmDangNhap_FormClosed);
            this.Load += new System.EventHandler(this.frmDangNhap_Load);
            this.groupBoxDangNhap.ResumeLayout(false);
            this.groupBoxDangNhap.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxDangNhap;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.CheckBox cboxremember;
        private System.Windows.Forms.TextBox txtMatkhau;
        private System.Windows.Forms.TextBox txtTaikhoan;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_frmDN_Thoat;
        private System.Windows.Forms.Button btnDangNhap;
    }
}