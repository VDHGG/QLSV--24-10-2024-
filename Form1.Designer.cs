namespace QuanLyDanhSachSvWithCode
{
    partial class Form1
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
            this.dgvSinhVien = new System.Windows.Forms.DataGridView();
            this.ThemButton = new System.Windows.Forms.Button();
            this.XoaButton = new System.Windows.Forms.Button();
            this.SuaButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.MsvText = new System.Windows.Forms.TextBox();
            this.LopSvText = new System.Windows.Forms.TextBox();
            this.TenSvText = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSinhVien)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvSinhVien
            // 
            this.dgvSinhVien.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSinhVien.Location = new System.Drawing.Point(446, 63);
            this.dgvSinhVien.Name = "dgvSinhVien";
            this.dgvSinhVien.RowHeadersWidth = 51;
            this.dgvSinhVien.RowTemplate.Height = 24;
            this.dgvSinhVien.Size = new System.Drawing.Size(428, 159);
            this.dgvSinhVien.TabIndex = 0;
            // 
            // ThemButton
            // 
            this.ThemButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ThemButton.Location = new System.Drawing.Point(446, 419);
            this.ThemButton.Name = "ThemButton";
            this.ThemButton.Size = new System.Drawing.Size(96, 32);
            this.ThemButton.TabIndex = 1;
            this.ThemButton.Text = "THÊM";
            this.ThemButton.UseVisualStyleBackColor = true;
            this.ThemButton.Click += new System.EventHandler(this.ThemButton_Click);
            // 
            // XoaButton
            // 
            this.XoaButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.XoaButton.Location = new System.Drawing.Point(778, 419);
            this.XoaButton.Name = "XoaButton";
            this.XoaButton.Size = new System.Drawing.Size(96, 32);
            this.XoaButton.TabIndex = 3;
            this.XoaButton.Text = "XÓA";
            this.XoaButton.UseVisualStyleBackColor = true;
            this.XoaButton.Click += new System.EventHandler(this.XoaButton_Click);
            // 
            // SuaButton
            // 
            this.SuaButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SuaButton.Location = new System.Drawing.Point(618, 419);
            this.SuaButton.Name = "SuaButton";
            this.SuaButton.Size = new System.Drawing.Size(96, 32);
            this.SuaButton.TabIndex = 4;
            this.SuaButton.Text = "SỬA";
            this.SuaButton.UseVisualStyleBackColor = true;
            this.SuaButton.Click += new System.EventHandler(this.SuaButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(446, 265);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 16);
            this.label1.TabIndex = 5;
            this.label1.Text = "NHẬP MSV:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(446, 310);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 16);
            this.label2.TabIndex = 6;
            this.label2.Text = "NHẬP TÊN SV:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(446, 361);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(98, 16);
            this.label3.TabIndex = 7;
            this.label3.Text = "NHẬP LỚP SV:";
            // 
            // MsvText
            // 
            this.MsvText.Location = new System.Drawing.Point(570, 258);
            this.MsvText.Name = "MsvText";
            this.MsvText.Size = new System.Drawing.Size(326, 22);
            this.MsvText.TabIndex = 8;
            // 
            // LopSvText
            // 
            this.LopSvText.Location = new System.Drawing.Point(570, 355);
            this.LopSvText.Name = "LopSvText";
            this.LopSvText.Size = new System.Drawing.Size(326, 22);
            this.LopSvText.TabIndex = 9;
            // 
            // TenSvText
            // 
            this.TenSvText.Location = new System.Drawing.Point(570, 304);
            this.TenSvText.Name = "TenSvText";
            this.TenSvText.Size = new System.Drawing.Size(326, 22);
            this.TenSvText.TabIndex = 10;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1382, 485);
            this.Controls.Add(this.TenSvText);
            this.Controls.Add(this.LopSvText);
            this.Controls.Add(this.MsvText);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.SuaButton);
            this.Controls.Add(this.XoaButton);
            this.Controls.Add(this.ThemButton);
            this.Controls.Add(this.dgvSinhVien);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSinhVien)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvSinhVien;
        private System.Windows.Forms.Button ThemButton;
        private System.Windows.Forms.Button XoaButton;
        private System.Windows.Forms.Button SuaButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox MsvText;
        private System.Windows.Forms.TextBox LopSvText;
        private System.Windows.Forms.TextBox TenSvText;
    }
}

