namespace Tuan1_DoiTien
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
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtKetQua = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnVndToUsd = new System.Windows.Forms.Button();
            this.btnVndToEur = new System.Windows.Forms.Button();
            this.btnEurToVnd = new System.Windows.Forms.Button();
            this.btnUsdToVnd = new System.Windows.Forms.Button();
            this.txtTien = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Blue;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(512, 48);
            this.label1.TabIndex = 0;
            this.label1.Text = "ĐỔI TIỀN";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LightSeaGreen;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 48);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(512, 2);
            this.panel1.TabIndex = 1;
            // 
            // txtKetQua
            // 
            this.txtKetQua.Location = new System.Drawing.Point(146, 196);
            this.txtKetQua.Name = "txtKetQua";
            this.txtKetQua.ReadOnly = true;
            this.txtKetQua.Size = new System.Drawing.Size(354, 27);
            this.txtKetQua.TabIndex = 2;
            this.txtKetQua.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(13, 196);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(127, 27);
            this.label2.TabIndex = 3;
            this.label2.Text = "Kết quả:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // btnVndToUsd
            // 
            this.btnVndToUsd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVndToUsd.Location = new System.Drawing.Point(4, 121);
            this.btnVndToUsd.Name = "btnVndToUsd";
            this.btnVndToUsd.Size = new System.Drawing.Size(122, 46);
            this.btnVndToUsd.TabIndex = 4;
            this.btnVndToUsd.Text = "VND to USD";
            this.btnVndToUsd.UseVisualStyleBackColor = true;
            this.btnVndToUsd.Click += new System.EventHandler(this.btnVndToUsd_Click);
            // 
            // btnVndToEur
            // 
            this.btnVndToEur.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVndToEur.Location = new System.Drawing.Point(131, 121);
            this.btnVndToEur.Name = "btnVndToEur";
            this.btnVndToEur.Size = new System.Drawing.Size(122, 46);
            this.btnVndToEur.TabIndex = 4;
            this.btnVndToEur.Text = "VND to EUR";
            this.btnVndToEur.UseVisualStyleBackColor = true;
            this.btnVndToEur.Click += new System.EventHandler(this.btnVndToEur_Click);
            // 
            // btnEurToVnd
            // 
            this.btnEurToVnd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEurToVnd.Location = new System.Drawing.Point(387, 121);
            this.btnEurToVnd.Name = "btnEurToVnd";
            this.btnEurToVnd.Size = new System.Drawing.Size(122, 46);
            this.btnEurToVnd.TabIndex = 4;
            this.btnEurToVnd.Text = "EUR to VND";
            this.btnEurToVnd.UseVisualStyleBackColor = true;
            this.btnEurToVnd.Click += new System.EventHandler(this.btnEurToVnd_Click);
            // 
            // btnUsdToVnd
            // 
            this.btnUsdToVnd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUsdToVnd.Location = new System.Drawing.Point(258, 121);
            this.btnUsdToVnd.Name = "btnUsdToVnd";
            this.btnUsdToVnd.Size = new System.Drawing.Size(122, 46);
            this.btnUsdToVnd.TabIndex = 4;
            this.btnUsdToVnd.Text = "USD to VND";
            this.btnUsdToVnd.UseVisualStyleBackColor = true;
            this.btnUsdToVnd.Click += new System.EventHandler(this.btnUsdToVnd_Click);
            // 
            // txtTien
            // 
            this.txtTien.Location = new System.Drawing.Point(145, 70);
            this.txtTien.Name = "txtTien";
            this.txtTien.Size = new System.Drawing.Size(354, 27);
            this.txtTien.TabIndex = 2;
            this.txtTien.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(12, 70);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(127, 27);
            this.label3.TabIndex = 3;
            this.label3.Text = "Tiền quy đổi:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(512, 249);
            this.Controls.Add(this.btnUsdToVnd);
            this.Controls.Add(this.btnEurToVnd);
            this.Controls.Add(this.btnVndToEur);
            this.Controls.Add(this.btnVndToUsd);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtTien);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtKetQua);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtKetQua;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnVndToUsd;
        private System.Windows.Forms.Button btnVndToEur;
        private System.Windows.Forms.Button btnEurToVnd;
        private System.Windows.Forms.Button btnUsdToVnd;
        private System.Windows.Forms.TextBox txtTien;
        private System.Windows.Forms.Label label3;
    }
}

