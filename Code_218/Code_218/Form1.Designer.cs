
namespace Code_218
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.picture = new System.Windows.Forms.PictureBox();
            this.xoa = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.file_index = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.ThongBao = new System.Windows.Forms.Label();
            this.btn_yes = new System.Windows.Forms.Button();
            this.btn_no = new System.Windows.Forms.Button();
            this.ThongBao2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picture)).BeginInit();
            this.SuspendLayout();
            // 
            // picture
            // 
            this.picture.BackColor = System.Drawing.Color.White;
            this.picture.Image = ((System.Drawing.Image)(resources.GetObject("picture.Image")));
            this.picture.Location = new System.Drawing.Point(457, 12);
            this.picture.Name = "picture";
            this.picture.Size = new System.Drawing.Size(200, 200);
            this.picture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picture.TabIndex = 1;
            this.picture.TabStop = false;
            // 
            // xoa
            // 
            this.xoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.xoa.ForeColor = System.Drawing.SystemColors.Desktop;
            this.xoa.Location = new System.Drawing.Point(338, 69);
            this.xoa.Name = "xoa";
            this.xoa.Size = new System.Drawing.Size(75, 23);
            this.xoa.TabIndex = 2;
            this.xoa.Text = "DELETE";
            this.xoa.UseVisualStyleBackColor = true;
            this.xoa.Click += new System.EventHandler(this.xoa_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.ForeColor = System.Drawing.Color.Teal;
            this.label1.Location = new System.Drawing.Point(433, 232);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(265, 38);
            this.label1.TabIndex = 3;
            this.label1.Text = "HỆ ĐIỀU HÀNH";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label2.Location = new System.Drawing.Point(391, 292);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(336, 100);
            this.label2.TabIndex = 4;
            this.label2.Text = "Giảng viên: Huỳnh Thanh Tâm\r\nSinh viên: Nguyễn Lam Trường\r\nMSSV: N19DCCN218\r\nLớp:" +
    " D19CQCN02-N";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.White;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label3.ForeColor = System.Drawing.Color.DarkBlue;
            this.label3.Location = new System.Drawing.Point(12, 26);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(292, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "Nhập đường dẫn file bạn muốn xóa:";
            // 
            // file_index
            // 
            this.file_index.Location = new System.Drawing.Point(16, 71);
            this.file_index.Name = "file_index";
            this.file_index.Size = new System.Drawing.Size(288, 20);
            this.file_index.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label4.ForeColor = System.Drawing.Color.DarkBlue;
            this.label4.Location = new System.Drawing.Point(16, 139);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(113, 20);
            this.label4.TabIndex = 7;
            this.label4.Text = "THÔNG BÁO";
            // 
            // ThongBao
            // 
            this.ThongBao.AutoSize = true;
            this.ThongBao.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.ThongBao.ForeColor = System.Drawing.Color.Red;
            this.ThongBao.Location = new System.Drawing.Point(25, 179);
            this.ThongBao.Name = "ThongBao";
            this.ThongBao.Size = new System.Drawing.Size(265, 24);
            this.ThongBao.TabIndex = 8;
            this.ThongBao.Text = "Bạn có chắc chắn xóa File!";
            this.ThongBao.Visible = false;
            // 
            // btn_yes
            // 
            this.btn_yes.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btn_yes.Location = new System.Drawing.Point(49, 249);
            this.btn_yes.Name = "btn_yes";
            this.btn_yes.Size = new System.Drawing.Size(75, 31);
            this.btn_yes.TabIndex = 9;
            this.btn_yes.Text = "YES";
            this.btn_yes.UseVisualStyleBackColor = true;
            this.btn_yes.Visible = false;
            this.btn_yes.Click += new System.EventHandler(this.btn_yes_Click);
            // 
            // btn_no
            // 
            this.btn_no.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.btn_no.Location = new System.Drawing.Point(186, 249);
            this.btn_no.Name = "btn_no";
            this.btn_no.Size = new System.Drawing.Size(75, 31);
            this.btn_no.TabIndex = 10;
            this.btn_no.Text = "NO";
            this.btn_no.UseVisualStyleBackColor = true;
            this.btn_no.Visible = false;
            this.btn_no.Click += new System.EventHandler(this.btn_no_Click);
            // 
            // ThongBao2
            // 
            this.ThongBao2.AutoSize = true;
            this.ThongBao2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold);
            this.ThongBao2.ForeColor = System.Drawing.Color.Red;
            this.ThongBao2.Location = new System.Drawing.Point(25, 203);
            this.ThongBao2.Name = "ThongBao2";
            this.ThongBao2.Size = new System.Drawing.Size(233, 24);
            this.ThongBao2.TabIndex = 11;
            this.ThongBao2.Text = "Đã xóa File thành công!";
            this.ThongBao2.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.ThongBao2);
            this.Controls.Add(this.btn_no);
            this.Controls.Add(this.btn_yes);
            this.Controls.Add(this.ThongBao);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.file_index);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.xoa);
            this.Controls.Add(this.picture);
            this.Name = "Form1";
            this.Text = "XÓA AN TOÀN";
            ((System.ComponentModel.ISupportInitialize)(this.picture)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox picture;
        private System.Windows.Forms.Button xoa;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox file_index;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label ThongBao;
        private System.Windows.Forms.Button btn_yes;
        private System.Windows.Forms.Button btn_no;
        private System.Windows.Forms.Label ThongBao2;
    }
}

