namespace DemoInvoncie
{
    partial class deneme
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
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.linkLabel19 = new System.Windows.Forms.LinkLabel();
            this.linkLabel18 = new System.Windows.Forms.LinkLabel();
            this.linkLabel17 = new System.Windows.Forms.LinkLabel();
            this.linkLabel16 = new System.Windows.Forms.LinkLabel();
            this.linkLabel15 = new System.Windows.Forms.LinkLabel();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.linkLabel19);
            this.groupControl1.Controls.Add(this.linkLabel18);
            this.groupControl1.Controls.Add(this.linkLabel17);
            this.groupControl1.Controls.Add(this.linkLabel16);
            this.groupControl1.Controls.Add(this.linkLabel15);
            this.groupControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupControl1.Location = new System.Drawing.Point(0, 0);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(869, 450);
            this.groupControl1.TabIndex = 1;
            this.groupControl1.Text = "Maliyet Bilgileri";
            // 
            // linkLabel19
            // 
            this.linkLabel19.AutoSize = true;
            this.linkLabel19.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.linkLabel19.LinkColor = System.Drawing.Color.Teal;
            this.linkLabel19.Location = new System.Drawing.Point(353, 33);
            this.linkLabel19.Name = "linkLabel19";
            this.linkLabel19.Size = new System.Drawing.Size(103, 17);
            this.linkLabel19.TabIndex = 35;
            this.linkLabel19.TabStop = true;
            this.linkLabel19.Text = "Ödenecek Tutar";
            // 
            // linkLabel18
            // 
            this.linkLabel18.AutoSize = true;
            this.linkLabel18.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.linkLabel18.LinkColor = System.Drawing.Color.Teal;
            this.linkLabel18.Location = new System.Drawing.Point(485, 33);
            this.linkLabel18.Name = "linkLabel18";
            this.linkLabel18.Size = new System.Drawing.Size(170, 17);
            this.linkLabel18.TabIndex = 34;
            this.linkLabel18.TabStop = true;
            this.linkLabel18.Text = "Vergiler Dahil Toplam Tutar";
            // 
            // linkLabel17
            // 
            this.linkLabel17.AutoSize = true;
            this.linkLabel17.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.linkLabel17.LinkColor = System.Drawing.Color.Teal;
            this.linkLabel17.Location = new System.Drawing.Point(202, 33);
            this.linkLabel17.Name = "linkLabel17";
            this.linkLabel17.Size = new System.Drawing.Size(108, 17);
            this.linkLabel17.TabIndex = 33;
            this.linkLabel17.TabStop = true;
            this.linkLabel17.Text = "Hesaplanan KDV";
            // 
            // linkLabel16
            // 
            this.linkLabel16.AutoSize = true;
            this.linkLabel16.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.linkLabel16.LinkColor = System.Drawing.Color.Teal;
            this.linkLabel16.Location = new System.Drawing.Point(683, 33);
            this.linkLabel16.Name = "linkLabel16";
            this.linkLabel16.Size = new System.Drawing.Size(117, 17);
            this.linkLabel16.TabIndex = 32;
            this.linkLabel16.TabStop = true;
            this.linkLabel16.Text = "Net Tutar(Matrah)";
            // 
            // linkLabel15
            // 
            this.linkLabel15.AutoSize = true;
            this.linkLabel15.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.linkLabel15.LinkColor = System.Drawing.Color.Teal;
            this.linkLabel15.Location = new System.Drawing.Point(10, 33);
            this.linkLabel15.Name = "linkLabel15";
            this.linkLabel15.Size = new System.Drawing.Size(160, 17);
            this.linkLabel15.TabIndex = 31;
            this.linkLabel15.TabStop = true;
            this.linkLabel15.Text = "Mal Hizmet Toplam Tutar";
            // 
            // deneme
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(869, 450);
            this.Controls.Add(this.groupControl1);
            this.Name = "deneme";
            this.Text = "deneme";
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.GroupControl groupControl1;
        private System.Windows.Forms.LinkLabel linkLabel19;
        private System.Windows.Forms.LinkLabel linkLabel18;
        private System.Windows.Forms.LinkLabel linkLabel17;
        private System.Windows.Forms.LinkLabel linkLabel16;
        private System.Windows.Forms.LinkLabel linkLabel15;
    }
}