namespace Btth2
{
    partial class FrmBai2
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
            this.txtHoTen = new System.Windows.Forms.TextBox();
            this.lblHoTen = new System.Windows.Forms.LinkLabel();
            this.label1 = new System.Windows.Forms.Label();
            this.grpKieuChu = new System.Windows.Forms.GroupBox();
            this.rad2 = new System.Windows.Forms.RadioButton();
            this.rad1 = new System.Windows.Forms.RadioButton();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnKQ = new System.Windows.Forms.Button();
            this.txtKQ = new System.Windows.Forms.TextBox();
            this.grpKieuChu.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtHoTen
            // 
            this.txtHoTen.Location = new System.Drawing.Point(298, 58);
            this.txtHoTen.Name = "txtHoTen";
            this.txtHoTen.Size = new System.Drawing.Size(369, 30);
            this.txtHoTen.TabIndex = 1;
            this.txtHoTen.TextChanged += new System.EventHandler(this.txtHoTen_TextChanged);
            // 
            // lblHoTen
            // 
            this.lblHoTen.AutoSize = true;
            this.lblHoTen.LinkColor = System.Drawing.Color.Black;
            this.lblHoTen.Location = new System.Drawing.Point(124, 61);
            this.lblHoTen.Name = "lblHoTen";
            this.lblHoTen.Size = new System.Drawing.Size(134, 22);
            this.lblHoTen.TabIndex = 2;
            this.lblHoTen.TabStop = true;
            this.lblHoTen.Text = "Nhập họ và tên:";
            this.lblHoTen.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lblHoTen_LinkClicked);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(348, 211);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 22);
            this.label1.TabIndex = 7;
            // 
            // grpKieuChu
            // 
            this.grpKieuChu.Controls.Add(this.rad2);
            this.grpKieuChu.Controls.Add(this.rad1);
            this.grpKieuChu.Location = new System.Drawing.Point(128, 108);
            this.grpKieuChu.Name = "grpKieuChu";
            this.grpKieuChu.Size = new System.Drawing.Size(439, 100);
            this.grpKieuChu.TabIndex = 8;
            this.grpKieuChu.TabStop = false;
            this.grpKieuChu.Text = "Chọn kiểu chữ";
            this.grpKieuChu.Enter += new System.EventHandler(this.grpKieuChu_Enter);
            // 
            // rad2
            // 
            this.rad2.AutoSize = true;
            this.rad2.Location = new System.Drawing.Point(29, 62);
            this.rad2.Name = "rad2";
            this.rad2.Size = new System.Drawing.Size(97, 26);
            this.rad2.TabIndex = 1;
            this.rad2.TabStop = true;
            this.rad2.Text = "Chữ hoa";
            this.rad2.UseVisualStyleBackColor = true;
            this.rad2.CheckedChanged += new System.EventHandler(this.rad2_CheckedChanged);
            // 
            // rad1
            // 
            this.rad1.AutoSize = true;
            this.rad1.Location = new System.Drawing.Point(29, 29);
            this.rad1.Name = "rad1";
            this.rad1.Size = new System.Drawing.Size(123, 26);
            this.rad1.TabIndex = 0;
            this.rad1.TabStop = true;
            this.rad1.Text = "Chữ thường";
            this.rad1.UseVisualStyleBackColor = true;
            this.rad1.CheckedChanged += new System.EventHandler(this.rad1_CheckedChanged);
            // 
            // btnXoa
            // 
            this.btnXoa.BackColor = System.Drawing.Color.Gainsboro;
            this.btnXoa.Location = new System.Drawing.Point(586, 119);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(81, 89);
            this.btnXoa.TabIndex = 9;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = false;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnKQ
            // 
            this.btnKQ.BackColor = System.Drawing.Color.Gainsboro;
            this.btnKQ.Location = new System.Drawing.Point(138, 234);
            this.btnKQ.Name = "btnKQ";
            this.btnKQ.Size = new System.Drawing.Size(142, 30);
            this.btnKQ.TabIndex = 10;
            this.btnKQ.Text = "Kết quả";
            this.btnKQ.UseVisualStyleBackColor = false;
            this.btnKQ.Click += new System.EventHandler(this.btnKQ_Click);
            // 
            // txtKQ
            // 
            this.txtKQ.Location = new System.Drawing.Point(322, 234);
            this.txtKQ.Name = "txtKQ";
            this.txtKQ.Size = new System.Drawing.Size(345, 30);
            this.txtKQ.TabIndex = 11;
            this.txtKQ.TextChanged += new System.EventHandler(this.txtKQ_TextChanged);
            // 
            // FrmBai2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(780, 307);
            this.Controls.Add(this.txtKQ);
            this.Controls.Add(this.btnKQ);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.grpKieuChu);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblHoTen);
            this.Controls.Add(this.txtHoTen);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FrmBai2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Đổi kiểu chữ";
            this.Load += new System.EventHandler(this.FrmBai2_Load);
            this.grpKieuChu.ResumeLayout(false);
            this.grpKieuChu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtHoTen;
        private System.Windows.Forms.LinkLabel lblHoTen;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox grpKieuChu;
        private System.Windows.Forms.RadioButton rad2;
        private System.Windows.Forms.RadioButton rad1;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnKQ;
        private System.Windows.Forms.TextBox txtKQ;
    }
}

