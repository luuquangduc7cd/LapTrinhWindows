namespace Tuan4_Cinema
{
    partial class FormMain
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
            this.lblTitle = new System.Windows.Forms.Label();
            this.pnlbottom = new System.Windows.Forms.Panel();
            this.sttStrip = new System.Windows.Forms.StatusStrip();
            this.txtThanhTien = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnTinhTien = new System.Windows.Forms.Button();
            this.btnTong = new System.Windows.Forms.Button();
            this.btnHuy = new System.Windows.Forms.Button();
            this.pnlFlow = new System.Windows.Forms.FlowLayoutPanel();
            this.pnlbottom.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.BackColor = System.Drawing.Color.YellowGreen;
            this.lblTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 32F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblTitle.Location = new System.Drawing.Point(0, 0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(810, 100);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Cinema";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnlbottom
            // 
            this.pnlbottom.Controls.Add(this.sttStrip);
            this.pnlbottom.Controls.Add(this.txtThanhTien);
            this.pnlbottom.Controls.Add(this.label1);
            this.pnlbottom.Controls.Add(this.btnTinhTien);
            this.pnlbottom.Controls.Add(this.btnTong);
            this.pnlbottom.Controls.Add(this.btnHuy);
            this.pnlbottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlbottom.Location = new System.Drawing.Point(0, 424);
            this.pnlbottom.Name = "pnlbottom";
            this.pnlbottom.Size = new System.Drawing.Size(810, 125);
            this.pnlbottom.TabIndex = 2;
            // 
            // sttStrip
            // 
            this.sttStrip.Location = new System.Drawing.Point(0, 103);
            this.sttStrip.Name = "sttStrip";
            this.sttStrip.Size = new System.Drawing.Size(810, 22);
            this.sttStrip.TabIndex = 3;
            // 
            // txtThanhTien
            // 
            this.txtThanhTien.Location = new System.Drawing.Point(315, 12);
            this.txtThanhTien.Name = "txtThanhTien";
            this.txtThanhTien.ReadOnly = true;
            this.txtThanhTien.Size = new System.Drawing.Size(382, 27);
            this.txtThanhTien.TabIndex = 2;
            this.txtThanhTien.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(114, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 22);
            this.label1.TabIndex = 1;
            this.label1.Text = "Thành tiền";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnTinhTien
            // 
            this.btnTinhTien.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnTinhTien.FlatAppearance.BorderSize = 0;
            this.btnTinhTien.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTinhTien.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnTinhTien.Location = new System.Drawing.Point(116, 45);
            this.btnTinhTien.Name = "btnTinhTien";
            this.btnTinhTien.Size = new System.Drawing.Size(180, 39);
            this.btnTinhTien.TabIndex = 0;
            this.btnTinhTien.Text = "Tính tiền";
            this.btnTinhTien.UseVisualStyleBackColor = false;
            this.btnTinhTien.Click += new System.EventHandler(this.btnTinhTien_Click);
            // 
            // btnTong
            // 
            this.btnTong.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnTong.FlatAppearance.BorderSize = 0;
            this.btnTong.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTong.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnTong.Location = new System.Drawing.Point(315, 45);
            this.btnTong.Name = "btnTong";
            this.btnTong.Size = new System.Drawing.Size(180, 39);
            this.btnTong.TabIndex = 0;
            this.btnTong.Text = "Tổng tiền";
            this.btnTong.UseVisualStyleBackColor = false;
            this.btnTong.Click += new System.EventHandler(this.btnTong_Click);
            // 
            // btnHuy
            // 
            this.btnHuy.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnHuy.FlatAppearance.BorderSize = 0;
            this.btnHuy.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHuy.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnHuy.Location = new System.Drawing.Point(514, 45);
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Size = new System.Drawing.Size(180, 39);
            this.btnHuy.TabIndex = 0;
            this.btnHuy.Text = "Hủy";
            this.btnHuy.UseVisualStyleBackColor = false;
            this.btnHuy.Click += new System.EventHandler(this.btnHuy_Click);
            // 
            // pnlFlow
            // 
            this.pnlFlow.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.pnlFlow.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlFlow.Location = new System.Drawing.Point(0, 100);
            this.pnlFlow.Name = "pnlFlow";
            this.pnlFlow.Size = new System.Drawing.Size(810, 324);
            this.pnlFlow.TabIndex = 1;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(810, 549);
            this.Controls.Add(this.pnlFlow);
            this.Controls.Add(this.pnlbottom);
            this.Controls.Add(this.lblTitle);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "FormMain";
            this.Text = "FormMain";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormMain_FormClosing);
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.pnlbottom.ResumeLayout(false);
            this.pnlbottom.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Panel pnlbottom;
        private System.Windows.Forms.StatusStrip sttStrip;
        private System.Windows.Forms.TextBox txtThanhTien;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnTinhTien;
        private System.Windows.Forms.Button btnHuy;
        private System.Windows.Forms.FlowLayoutPanel pnlFlow;
        private System.Windows.Forms.Button btnTong;
    }
}

