namespace Btth3
{
    partial class FrmUocSo
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
            this.grpNhapSo = new System.Windows.Forms.GroupBox();
            this.cboSo = new System.Windows.Forms.ComboBox();
            this.btnCapNhat = new System.Windows.Forms.Button();
            this.txtSo = new System.Windows.Forms.TextBox();
            this.grpUocSo = new System.Windows.Forms.GroupBox();
            this.lstUocSo = new System.Windows.Forms.ListBox();
            this.btnTong = new System.Windows.Forms.Button();
            this.btnChan = new System.Windows.Forms.Button();
            this.btnNguyenTo = new System.Windows.Forms.Button();
            this.btnThoat = new System.Windows.Forms.Button();
            this.grpNhapSo.SuspendLayout();
            this.grpUocSo.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpNhapSo
            // 
            this.grpNhapSo.BackColor = System.Drawing.Color.LightGray;
            this.grpNhapSo.Controls.Add(this.cboSo);
            this.grpNhapSo.Controls.Add(this.btnCapNhat);
            this.grpNhapSo.Controls.Add(this.txtSo);
            this.grpNhapSo.Location = new System.Drawing.Point(74, 55);
            this.grpNhapSo.Name = "grpNhapSo";
            this.grpNhapSo.Size = new System.Drawing.Size(267, 152);
            this.grpNhapSo.TabIndex = 0;
            this.grpNhapSo.TabStop = false;
            this.grpNhapSo.Text = "Nhập số";
            this.grpNhapSo.Enter += new System.EventHandler(this.grpNhapSo_Enter);
            // 
            // cboSo
            // 
            this.cboSo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboSo.FormattingEnabled = true;
            this.cboSo.Location = new System.Drawing.Point(6, 95);
            this.cboSo.Name = "cboSo";
            this.cboSo.Size = new System.Drawing.Size(247, 30);
            this.cboSo.TabIndex = 2;
            this.cboSo.SelectedIndexChanged += new System.EventHandler(this.cboSo_SelectedIndexChanged);
            // 
            // btnCapNhat
            // 
            this.btnCapNhat.BackColor = System.Drawing.Color.Gainsboro;
            this.btnCapNhat.Location = new System.Drawing.Point(145, 31);
            this.btnCapNhat.Name = "btnCapNhat";
            this.btnCapNhat.Size = new System.Drawing.Size(108, 43);
            this.btnCapNhat.TabIndex = 1;
            this.btnCapNhat.Text = "Cập nhật";
            this.btnCapNhat.UseVisualStyleBackColor = false;
            this.btnCapNhat.Click += new System.EventHandler(this.btnCapNhat_Click);
            // 
            // txtSo
            // 
            this.txtSo.Location = new System.Drawing.Point(6, 38);
            this.txtSo.Name = "txtSo";
            this.txtSo.Size = new System.Drawing.Size(133, 30);
            this.txtSo.TabIndex = 1;
            this.txtSo.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // grpUocSo
            // 
            this.grpUocSo.BackColor = System.Drawing.Color.LightGray;
            this.grpUocSo.Controls.Add(this.lstUocSo);
            this.grpUocSo.Location = new System.Drawing.Point(405, 55);
            this.grpUocSo.Name = "grpUocSo";
            this.grpUocSo.Size = new System.Drawing.Size(258, 152);
            this.grpUocSo.TabIndex = 1;
            this.grpUocSo.TabStop = false;
            this.grpUocSo.Text = "Danh sách ước số";
            this.grpUocSo.Enter += new System.EventHandler(this.grpUocSo_Enter);
            // 
            // lstUocSo
            // 
            this.lstUocSo.FormattingEnabled = true;
            this.lstUocSo.ItemHeight = 22;
            this.lstUocSo.Location = new System.Drawing.Point(18, 29);
            this.lstUocSo.Name = "lstUocSo";
            this.lstUocSo.Size = new System.Drawing.Size(220, 114);
            this.lstUocSo.TabIndex = 3;
            this.lstUocSo.SelectedIndexChanged += new System.EventHandler(this.lstUocSo_SelectedIndexChanged);
            // 
            // btnTong
            // 
            this.btnTong.BackColor = System.Drawing.Color.Gainsboro;
            this.btnTong.Location = new System.Drawing.Point(405, 222);
            this.btnTong.Name = "btnTong";
            this.btnTong.Size = new System.Drawing.Size(258, 38);
            this.btnTong.TabIndex = 4;
            this.btnTong.Text = "Tổng các ước số";
            this.btnTong.UseVisualStyleBackColor = false;
            this.btnTong.Click += new System.EventHandler(this.btnTong_Click);
            // 
            // btnChan
            // 
            this.btnChan.BackColor = System.Drawing.Color.Gainsboro;
            this.btnChan.Location = new System.Drawing.Point(405, 266);
            this.btnChan.Name = "btnChan";
            this.btnChan.Size = new System.Drawing.Size(258, 38);
            this.btnChan.TabIndex = 5;
            this.btnChan.Text = "Số lượng các ước số chẵn";
            this.btnChan.UseVisualStyleBackColor = false;
            this.btnChan.Click += new System.EventHandler(this.btnChan_Click);
            // 
            // btnNguyenTo
            // 
            this.btnNguyenTo.BackColor = System.Drawing.Color.Gainsboro;
            this.btnNguyenTo.Location = new System.Drawing.Point(405, 310);
            this.btnNguyenTo.Name = "btnNguyenTo";
            this.btnNguyenTo.Size = new System.Drawing.Size(258, 38);
            this.btnNguyenTo.TabIndex = 6;
            this.btnNguyenTo.Text = "Số lượng các ước số nguyên tố";
            this.btnNguyenTo.UseVisualStyleBackColor = false;
            this.btnNguyenTo.Click += new System.EventHandler(this.btnNguyenTo_Click);
            // 
            // btnThoat
            // 
            this.btnThoat.BackColor = System.Drawing.Color.Gainsboro;
            this.btnThoat.Location = new System.Drawing.Point(246, 310);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(95, 38);
            this.btnThoat.TabIndex = 7;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = false;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // FrmUocSo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkGray;
            this.ClientSize = new System.Drawing.Size(754, 360);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnNguyenTo);
            this.Controls.Add(this.btnChan);
            this.Controls.Add(this.btnTong);
            this.Controls.Add(this.grpUocSo);
            this.Controls.Add(this.grpNhapSo);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FrmUocSo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Combobox";
            this.grpNhapSo.ResumeLayout(false);
            this.grpNhapSo.PerformLayout();
            this.grpUocSo.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpNhapSo;
        private System.Windows.Forms.TextBox txtSo;
        private System.Windows.Forms.Button btnCapNhat;
        private System.Windows.Forms.ComboBox cboSo;
        private System.Windows.Forms.GroupBox grpUocSo;
        private System.Windows.Forms.ListBox lstUocSo;
        private System.Windows.Forms.Button btnTong;
        private System.Windows.Forms.Button btnChan;
        private System.Windows.Forms.Button btnNguyenTo;
        private System.Windows.Forms.Button btnThoat;
    }
}

