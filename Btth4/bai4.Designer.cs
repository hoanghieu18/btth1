namespace Btth4
{
    partial class FrmPhepTinh
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtSo1 = new System.Windows.Forms.TextBox();
            this.txtSo2 = new System.Windows.Forms.TextBox();
            this.grpPhepTinh = new System.Windows.Forms.GroupBox();
            this.radChia = new System.Windows.Forms.RadioButton();
            this.radCong = new System.Windows.Forms.RadioButton();
            this.radNhan = new System.Windows.Forms.RadioButton();
            this.radTru = new System.Windows.Forms.RadioButton();
            this.label3 = new System.Windows.Forms.Label();
            this.txtKQ = new System.Windows.Forms.TextBox();
            this.grpPhepTinh.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(93, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 22);
            this.label1.TabIndex = 0;
            this.label1.Text = "Số 1:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(93, 95);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 22);
            this.label2.TabIndex = 1;
            this.label2.Text = "Số 2:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // txtSo1
            // 
            this.txtSo1.Location = new System.Drawing.Point(193, 38);
            this.txtSo1.Name = "txtSo1";
            this.txtSo1.Size = new System.Drawing.Size(447, 30);
            this.txtSo1.TabIndex = 0;
            this.txtSo1.TextChanged += new System.EventHandler(this.txtSo1_TextChanged);
            // 
            // txtSo2
            // 
            this.txtSo2.Location = new System.Drawing.Point(193, 87);
            this.txtSo2.Name = "txtSo2";
            this.txtSo2.Size = new System.Drawing.Size(447, 30);
            this.txtSo2.TabIndex = 1;
            this.txtSo2.TextChanged += new System.EventHandler(this.txtSo2_TextChanged);
            // 
            // grpPhepTinh
            // 
            this.grpPhepTinh.Controls.Add(this.radChia);
            this.grpPhepTinh.Controls.Add(this.radCong);
            this.grpPhepTinh.Controls.Add(this.radNhan);
            this.grpPhepTinh.Controls.Add(this.radTru);
            this.grpPhepTinh.Location = new System.Drawing.Point(73, 144);
            this.grpPhepTinh.Name = "grpPhepTinh";
            this.grpPhepTinh.Size = new System.Drawing.Size(567, 80);
            this.grpPhepTinh.TabIndex = 2;
            this.grpPhepTinh.TabStop = false;
            this.grpPhepTinh.Text = "Phép tính";
            this.grpPhepTinh.Enter += new System.EventHandler(this.grpPhepTinh_Enter);
            // 
            // radChia
            // 
            this.radChia.AutoSize = true;
            this.radChia.Location = new System.Drawing.Point(433, 39);
            this.radChia.Name = "radChia";
            this.radChia.Size = new System.Drawing.Size(68, 26);
            this.radChia.TabIndex = 5;
            this.radChia.TabStop = true;
            this.radChia.Text = "Chia";
            this.radChia.UseVisualStyleBackColor = true;
            this.radChia.CheckedChanged += new System.EventHandler(this.radioButton4_CheckedChanged);
            // 
            // radCong
            // 
            this.radCong.AutoSize = true;
            this.radCong.Location = new System.Drawing.Point(23, 39);
            this.radCong.Name = "radCong";
            this.radCong.Size = new System.Drawing.Size(72, 26);
            this.radCong.TabIndex = 0;
            this.radCong.TabStop = true;
            this.radCong.Text = "Cộng";
            this.radCong.UseVisualStyleBackColor = true;
            this.radCong.CheckedChanged += new System.EventHandler(this.radCong_CheckedChanged);
            // 
            // radNhan
            // 
            this.radNhan.AutoSize = true;
            this.radNhan.Location = new System.Drawing.Point(289, 39);
            this.radNhan.Name = "radNhan";
            this.radNhan.Size = new System.Drawing.Size(72, 26);
            this.radNhan.TabIndex = 4;
            this.radNhan.TabStop = true;
            this.radNhan.Text = "Nhân";
            this.radNhan.UseVisualStyleBackColor = true;
            this.radNhan.CheckedChanged += new System.EventHandler(this.radNhan_CheckedChanged_1);
            // 
            // radTru
            // 
            this.radTru.AutoSize = true;
            this.radTru.Location = new System.Drawing.Point(159, 39);
            this.radTru.Name = "radTru";
            this.radTru.Size = new System.Drawing.Size(60, 26);
            this.radTru.TabIndex = 3;
            this.radTru.TabStop = true;
            this.radTru.Text = "Trừ";
            this.radTru.UseVisualStyleBackColor = true;
            this.radTru.CheckedChanged += new System.EventHandler(this.radTru_CheckedChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(85, 257);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 22);
            this.label3.TabIndex = 3;
            this.label3.Text = "Kết quả:";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // txtKQ
            // 
            this.txtKQ.Location = new System.Drawing.Point(193, 249);
            this.txtKQ.Name = "txtKQ";
            this.txtKQ.ReadOnly = true;
            this.txtKQ.Size = new System.Drawing.Size(447, 30);
            this.txtKQ.TabIndex = 2;
            this.txtKQ.TextChanged += new System.EventHandler(this.txtKQ_TextChanged_1);
            // 
            // FrmPhepTinh
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(701, 332);
            this.Controls.Add(this.txtKQ);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.grpPhepTinh);
            this.Controls.Add(this.txtSo2);
            this.Controls.Add(this.txtSo1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FrmPhepTinh";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Phép tính";
            this.Load += new System.EventHandler(this.FrmPhepTinh_Load);
            this.grpPhepTinh.ResumeLayout(false);
            this.grpPhepTinh.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtSo1;
        private System.Windows.Forms.TextBox txtSo2;
        private System.Windows.Forms.GroupBox grpPhepTinh;
        private System.Windows.Forms.RadioButton radCong;
        private System.Windows.Forms.RadioButton radTru;
        private System.Windows.Forms.RadioButton radNhan;
        private System.Windows.Forms.RadioButton radChia;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtKQ;
    }
}

