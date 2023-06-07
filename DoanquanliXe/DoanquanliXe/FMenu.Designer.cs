namespace DoanquanliXe
{
    partial class FMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FMenu));
            this.panel_left = new System.Windows.Forms.Panel();
            this.btnDoc = new System.Windows.Forms.Button();
            this.btnGhi = new System.Windows.Forms.Button();
            this.btnXe = new System.Windows.Forms.Button();
            this.btnTTNCC = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel_top = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel_body = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.panel_left.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel_top.SuspendLayout();
            this.panel_body.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // panel_left
            // 
            this.panel_left.BackColor = System.Drawing.SystemColors.MenuText;
            this.panel_left.Controls.Add(this.pictureBox3);
            this.panel_left.Controls.Add(this.btnDoc);
            this.panel_left.Controls.Add(this.btnGhi);
            this.panel_left.Controls.Add(this.btnXe);
            this.panel_left.Controls.Add(this.btnTTNCC);
            this.panel_left.Controls.Add(this.pictureBox1);
            this.panel_left.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel_left.Location = new System.Drawing.Point(0, 0);
            this.panel_left.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel_left.Name = "panel_left";
            this.panel_left.Size = new System.Drawing.Size(211, 803);
            this.panel_left.TabIndex = 0;
            // 
            // btnDoc
            // 
            this.btnDoc.BackColor = System.Drawing.Color.Transparent;
            this.btnDoc.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnDoc.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDoc.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnDoc.Image = ((System.Drawing.Image)(resources.GetObject("btnDoc.Image")));
            this.btnDoc.Location = new System.Drawing.Point(0, 558);
            this.btnDoc.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnDoc.Name = "btnDoc";
            this.btnDoc.Size = new System.Drawing.Size(211, 121);
            this.btnDoc.TabIndex = 5;
            this.btnDoc.Text = "Đọc File";
            this.btnDoc.UseVisualStyleBackColor = false;
            this.btnDoc.Click += new System.EventHandler(this.btnDoc_Click);
            // 
            // btnGhi
            // 
            this.btnGhi.BackColor = System.Drawing.Color.Transparent;
            this.btnGhi.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnGhi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGhi.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnGhi.Image = ((System.Drawing.Image)(resources.GetObject("btnGhi.Image")));
            this.btnGhi.Location = new System.Drawing.Point(0, 420);
            this.btnGhi.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnGhi.Name = "btnGhi";
            this.btnGhi.Size = new System.Drawing.Size(211, 138);
            this.btnGhi.TabIndex = 4;
            this.btnGhi.Text = "Ghi File";
            this.btnGhi.UseVisualStyleBackColor = false;
            this.btnGhi.Click += new System.EventHandler(this.btnGhi_Click);
            // 
            // btnXe
            // 
            this.btnXe.BackColor = System.Drawing.Color.Transparent;
            this.btnXe.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnXe.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnXe.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnXe.Image = ((System.Drawing.Image)(resources.GetObject("btnXe.Image")));
            this.btnXe.Location = new System.Drawing.Point(0, 286);
            this.btnXe.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnXe.Name = "btnXe";
            this.btnXe.Size = new System.Drawing.Size(211, 134);
            this.btnXe.TabIndex = 2;
            this.btnXe.Text = "Thông Tin Xe";
            this.btnXe.UseVisualStyleBackColor = false;
            this.btnXe.Click += new System.EventHandler(this.btnXe_Click);
            // 
            // btnTTNCC
            // 
            this.btnTTNCC.BackColor = System.Drawing.Color.Transparent;
            this.btnTTNCC.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnTTNCC.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTTNCC.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnTTNCC.Image = ((System.Drawing.Image)(resources.GetObject("btnTTNCC.Image")));
            this.btnTTNCC.Location = new System.Drawing.Point(0, 149);
            this.btnTTNCC.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnTTNCC.Name = "btnTTNCC";
            this.btnTTNCC.Size = new System.Drawing.Size(211, 137);
            this.btnTTNCC.TabIndex = 3;
            this.btnTTNCC.Text = "Nhà Cung Cấp";
            this.btnTTNCC.UseVisualStyleBackColor = false;
            this.btnTTNCC.Click += new System.EventHandler(this.btnTTNCC_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(211, 149);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click_1);
            // 
            // panel_top
            // 
            this.panel_top.BackColor = System.Drawing.SystemColors.GrayText;
            this.panel_top.Controls.Add(this.label1);
            this.panel_top.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_top.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel_top.Location = new System.Drawing.Point(211, 0);
            this.panel_top.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel_top.Name = "panel_top";
            this.panel_top.Size = new System.Drawing.Size(1099, 149);
            this.panel_top.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Ink Free", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(511, 85);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(150, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "TRANG CHỦ";
            // 
            // panel_body
            // 
            this.panel_body.BackColor = System.Drawing.SystemColors.ControlDark;
            this.panel_body.Controls.Add(this.pictureBox2);
            this.panel_body.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_body.Location = new System.Drawing.Point(211, 149);
            this.panel_body.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel_body.Name = "panel_body";
            this.panel_body.Size = new System.Drawing.Size(1099, 654);
            this.panel_body.TabIndex = 2;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(0, 0);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(1099, 654);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 0;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(0, 679);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(211, 124);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 6;
            this.pictureBox3.TabStop = false;
            // 
            // FMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(1310, 803);
            this.Controls.Add(this.panel_body);
            this.Controls.Add(this.panel_top);
            this.Controls.Add(this.panel_left);
            this.Font = new System.Drawing.Font("Times New Roman", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FMenu";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "MENU";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel_left.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel_top.ResumeLayout(false);
            this.panel_top.PerformLayout();
            this.panel_body.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel_left;
        private System.Windows.Forms.Panel panel_top;
        //private System.Windows.Forms.Button btnKho;
        private System.Windows.Forms.Button btnTTNCC;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel_body;
        private System.Windows.Forms.Button btnXe;
        private System.Windows.Forms.Button btnDoc;
        private System.Windows.Forms.Button btnGhi;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
    }
}

