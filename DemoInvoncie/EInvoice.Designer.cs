namespace DemoInvoncie
{
    partial class EInvoice
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
            this.components = new System.ComponentModel.Container();
            this.gridControlEInvocie = new DevExpress.XtraGrid.GridControl();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.MenuStripAppearanceSave = new System.Windows.Forms.ToolStripMenuItem();
            this.ContextMenuXmlConverting = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuStripAppreanceInvoncie = new System.Windows.Forms.ToolStripMenuItem();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn3 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn4 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn5 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn6 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn7 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn8 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn9 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn10 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn11 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn12 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn13 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn14 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn15 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn16 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn17 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ItemCheckEditInvocie = new DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit();
            this.panelUst = new DevExpress.XtraEditors.PanelControl();
            this.panelAna = new DevExpress.XtraEditors.PanelControl();
            this.dateEdit1 = new DevExpress.XtraEditors.DateEdit();
            this.dateEdit2 = new DevExpress.XtraEditors.DateEdit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlEInvocie)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemCheckEditInvocie)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelUst)).BeginInit();
            this.panelUst.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelAna)).BeginInit();
            this.panelAna.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dateEdit1.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEdit1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEdit2.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEdit2.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // gridControlEInvocie
            // 
            this.gridControlEInvocie.ContextMenuStrip = this.contextMenuStrip1;
            this.gridControlEInvocie.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControlEInvocie.Location = new System.Drawing.Point(2, 2);
            this.gridControlEInvocie.MainView = this.gridView1;
            this.gridControlEInvocie.Name = "gridControlEInvocie";
            this.gridControlEInvocie.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.ItemCheckEditInvocie});
            this.gridControlEInvocie.Size = new System.Drawing.Size(796, 413);
            this.gridControlEInvocie.TabIndex = 0;
            this.gridControlEInvocie.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuStripAppearanceSave,
            this.ContextMenuXmlConverting,
            this.MenuStripAppreanceInvoncie});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(172, 70);
            // 
            // MenuStripAppearanceSave
            // 
            this.MenuStripAppearanceSave.Name = "MenuStripAppearanceSave";
            this.MenuStripAppearanceSave.Size = new System.Drawing.Size(171, 22);
            this.MenuStripAppearanceSave.Text = "Görünümü Kaydet";
            this.MenuStripAppearanceSave.Click += new System.EventHandler(this.MenuStripAppearanceSave_Click);
            // 
            // ContextMenuXmlConverting
            // 
            this.ContextMenuXmlConverting.Name = "ContextMenuXmlConverting";
            this.ContextMenuXmlConverting.Size = new System.Drawing.Size(171, 22);
            this.ContextMenuXmlConverting.Text = "Xml Kaydet";
            this.ContextMenuXmlConverting.Click += new System.EventHandler(this.ContextMenuXmlConverting_Click);
            // 
            // MenuStripAppreanceInvoncie
            // 
            this.MenuStripAppreanceInvoncie.Name = "MenuStripAppreanceInvoncie";
            this.MenuStripAppreanceInvoncie.Size = new System.Drawing.Size(171, 22);
            this.MenuStripAppreanceInvoncie.Text = "Görüntüle";
            this.MenuStripAppreanceInvoncie.Click += new System.EventHandler(this.MenuStripAppreanceInvoncie_Click);
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn1,
            this.gridColumn2,
            this.gridColumn3,
            this.gridColumn4,
            this.gridColumn5,
            this.gridColumn6,
            this.gridColumn7,
            this.gridColumn8,
            this.gridColumn9,
            this.gridColumn10,
            this.gridColumn11,
            this.gridColumn12,
            this.gridColumn13,
            this.gridColumn14,
            this.gridColumn15,
            this.gridColumn16,
            this.gridColumn17});
            this.gridView1.GridControl = this.gridControlEInvocie;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsView.ColumnAutoWidth = false;
            this.gridView1.OptionsView.ShowFooter = true;
            this.gridView1.OptionsView.ShowGroupPanel = false;
            // 
            // gridColumn1
            // 
            this.gridColumn1.Caption = "UUID";
            this.gridColumn1.FieldName = "UUID";
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.Visible = true;
            this.gridColumn1.VisibleIndex = 1;
            this.gridColumn1.Width = 41;
            // 
            // gridColumn2
            // 
            this.gridColumn2.Caption = "Vergi Numarası";
            this.gridColumn2.FieldName = "TaxNumber";
            this.gridColumn2.Name = "gridColumn2";
            this.gridColumn2.Visible = true;
            this.gridColumn2.VisibleIndex = 2;
            this.gridColumn2.Width = 80;
            // 
            // gridColumn3
            // 
            this.gridColumn3.Caption = "Fatura Numarası";
            this.gridColumn3.FieldName = "InvoiceNumber";
            this.gridColumn3.Name = "gridColumn3";
            this.gridColumn3.Visible = true;
            this.gridColumn3.VisibleIndex = 3;
            this.gridColumn3.Width = 38;
            // 
            // gridColumn4
            // 
            this.gridColumn4.Caption = "Fatura Numarası";
            this.gridColumn4.FieldName = "InvoiceProfile";
            this.gridColumn4.Name = "gridColumn4";
            this.gridColumn4.Visible = true;
            this.gridColumn4.VisibleIndex = 4;
            this.gridColumn4.Width = 38;
            // 
            // gridColumn5
            // 
            this.gridColumn5.Caption = "Durum Açıklaması";
            this.gridColumn5.FieldName = "InvoiceStatusDescription";
            this.gridColumn5.Name = "gridColumn5";
            this.gridColumn5.Visible = true;
            this.gridColumn5.VisibleIndex = 5;
            this.gridColumn5.Width = 38;
            // 
            // gridColumn6
            // 
            this.gridColumn6.Caption = "Fatura Türü";
            this.gridColumn6.FieldName = "InvoiceType";
            this.gridColumn6.Name = "gridColumn6";
            this.gridColumn6.Visible = true;
            this.gridColumn6.VisibleIndex = 6;
            this.gridColumn6.Width = 38;
            // 
            // gridColumn7
            // 
            this.gridColumn7.Caption = "İşlem Tarihi";
            this.gridColumn7.DisplayFormat.FormatString = "d";
            this.gridColumn7.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.gridColumn7.FieldName = "IssueDate";
            this.gridColumn7.Name = "gridColumn7";
            this.gridColumn7.Visible = true;
            this.gridColumn7.VisibleIndex = 7;
            this.gridColumn7.Width = 38;
            // 
            // gridColumn8
            // 
            this.gridColumn8.Caption = "Oluşturulma Tarihi";
            this.gridColumn8.DisplayFormat.FormatString = "d";
            this.gridColumn8.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.gridColumn8.FieldName = "CreatedDate";
            this.gridColumn8.Name = "gridColumn8";
            this.gridColumn8.Visible = true;
            this.gridColumn8.VisibleIndex = 8;
            this.gridColumn8.Width = 38;
            // 
            // gridColumn9
            // 
            this.gridColumn9.Caption = "Durum";
            this.gridColumn9.FieldName = "Status";
            this.gridColumn9.Name = "gridColumn9";
            this.gridColumn9.Visible = true;
            this.gridColumn9.VisibleIndex = 9;
            this.gridColumn9.Width = 38;
            // 
            // gridColumn10
            // 
            this.gridColumn10.Caption = "Para Birimi";
            this.gridColumn10.FieldName = "CurrencyCode";
            this.gridColumn10.Name = "gridColumn10";
            this.gridColumn10.Visible = true;
            this.gridColumn10.VisibleIndex = 10;
            this.gridColumn10.Width = 38;
            // 
            // gridColumn11
            // 
            this.gridColumn11.Caption = "Ödenecek Tutar";
            this.gridColumn11.FieldName = "PayableAmount";
            this.gridColumn11.Name = "gridColumn11";
            this.gridColumn11.Visible = true;
            this.gridColumn11.VisibleIndex = 11;
            this.gridColumn11.Width = 38;
            // 
            // gridColumn12
            // 
            this.gridColumn12.Caption = "Takma Adı";
            this.gridColumn12.FieldName = "Alias";
            this.gridColumn12.Name = "gridColumn12";
            this.gridColumn12.Visible = true;
            this.gridColumn12.VisibleIndex = 12;
            this.gridColumn12.Width = 38;
            // 
            // gridColumn13
            // 
            this.gridColumn13.Caption = "Alıcı Adı";
            this.gridColumn13.FieldName = "ReceiverName";
            this.gridColumn13.Name = "gridColumn13";
            this.gridColumn13.Visible = true;
            this.gridColumn13.VisibleIndex = 13;
            this.gridColumn13.Width = 38;
            // 
            // gridColumn14
            // 
            this.gridColumn14.Caption = "Alıcı Vergi Numarası";
            this.gridColumn14.FieldName = "ReceiverTaxNumber";
            this.gridColumn14.Name = "gridColumn14";
            this.gridColumn14.Visible = true;
            this.gridColumn14.VisibleIndex = 14;
            this.gridColumn14.Width = 38;
            // 
            // gridColumn15
            // 
            this.gridColumn15.Caption = "Alıcı Takma Adı";
            this.gridColumn15.FieldName = "ReceiverAlias";
            this.gridColumn15.Name = "gridColumn15";
            this.gridColumn15.Visible = true;
            this.gridColumn15.VisibleIndex = 15;
            this.gridColumn15.Width = 38;
            // 
            // gridColumn16
            // 
            this.gridColumn16.Caption = "Yazdırıldı mı?";
            this.gridColumn16.FieldName = "IsPrint";
            this.gridColumn16.Name = "gridColumn16";
            this.gridColumn16.Visible = true;
            this.gridColumn16.VisibleIndex = 16;
            this.gridColumn16.Width = 38;
            // 
            // gridColumn17
            // 
            this.gridColumn17.Caption = "Seç";
            this.gridColumn17.ColumnEdit = this.ItemCheckEditInvocie;
            this.gridColumn17.Name = "gridColumn17";
            this.gridColumn17.Visible = true;
            this.gridColumn17.VisibleIndex = 0;
            this.gridColumn17.Width = 60;
            // 
            // ItemCheckEditInvocie
            // 
            this.ItemCheckEditInvocie.AutoHeight = false;
            this.ItemCheckEditInvocie.Name = "ItemCheckEditInvocie";
            // 
            // panelUst
            // 
            this.panelUst.Controls.Add(this.dateEdit2);
            this.panelUst.Controls.Add(this.dateEdit1);
            this.panelUst.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelUst.Location = new System.Drawing.Point(0, 0);
            this.panelUst.Name = "panelUst";
            this.panelUst.Size = new System.Drawing.Size(800, 33);
            this.panelUst.TabIndex = 1;
            // 
            // panelAna
            // 
            this.panelAna.Controls.Add(this.gridControlEInvocie);
            this.panelAna.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelAna.Location = new System.Drawing.Point(0, 33);
            this.panelAna.Name = "panelAna";
            this.panelAna.Size = new System.Drawing.Size(800, 417);
            this.panelAna.TabIndex = 2;
            // 
            // dateEdit1
            // 
            this.dateEdit1.EditValue = null;
            this.dateEdit1.Location = new System.Drawing.Point(12, 5);
            this.dateEdit1.Name = "dateEdit1";
            this.dateEdit1.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateEdit1.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateEdit1.Size = new System.Drawing.Size(87, 20);
            this.dateEdit1.TabIndex = 0;
            // 
            // dateEdit2
            // 
            this.dateEdit2.EditValue = null;
            this.dateEdit2.Location = new System.Drawing.Point(115, 5);
            this.dateEdit2.Name = "dateEdit2";
            this.dateEdit2.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateEdit2.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateEdit2.Size = new System.Drawing.Size(87, 20);
            this.dateEdit2.TabIndex = 1;
            // 
            // EInvoice
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panelAna);
            this.Controls.Add(this.panelUst);
            this.Name = "EInvoice";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "E-Fatura ";
            this.Load += new System.EventHandler(this.EInvoice_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridControlEInvocie)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemCheckEditInvocie)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelUst)).EndInit();
            this.panelUst.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.panelAna)).EndInit();
            this.panelAna.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dateEdit1.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEdit1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEdit2.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEdit2.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gridControlEInvocie;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraEditors.PanelControl panelUst;
        private DevExpress.XtraEditors.PanelControl panelAna;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem MenuStripAppearanceSave;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn3;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn4;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn5;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn6;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn7;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn8;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn9;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn10;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn11;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn12;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn13;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn14;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn15;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn16;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn17;
        private DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit ItemCheckEditInvocie;
        private System.Windows.Forms.ToolStripMenuItem ContextMenuXmlConverting;
        private System.Windows.Forms.ToolStripMenuItem MenuStripAppreanceInvoncie;
        private DevExpress.XtraEditors.DateEdit dateEdit1;
        private DevExpress.XtraEditors.DateEdit dateEdit2;
    }
}