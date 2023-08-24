using DemoInvoncie.NilveraApi.Archive;
using DevExpress.XtraEditors;
using NLayer.Entities.Models;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;

namespace DemoInvoncie
{
    public partial class ArchiveType : UserControl
    {
        public ArchiveType()
        {
            InitializeComponent();
        }


        ApiSeries _series = new ApiSeries();
        ApiTemplates _templates = new ApiTemplates(); 
        private void checkEditIrsaliye_CheckedChanged(object sender, EventArgs e)
        {
            if (checkEditIrsaliye.Checked)
                groupControl1.Visible = true;
            else
                groupControl1.Visible = false;
        }  
        private async void ArchiveType_Load(object sender, EventArgs e)
        {
            dateEditInvoice.EditValue = DateTime.Now;


            // Fatura serileri
            await Series();

            //Fatura Şaplonları
            await Template(); 

            Ileti(); 
            //Satış Kanalı
            Saleschannel();

            //Para birmi
            Currency();

            //Fatura Türü
            InvoriceType();

            //Fatura Senaryosu
            InvoriceScenario();


        } 
        private async System.Threading.Tasks.Task Series()
        {
            DataTable dataTable = new DataTable();
         //   dataTable.Columns.Add("ID", typeof(int));
            dataTable.Columns.Add("Name", typeof(string));
            foreach (var series in await _series.SeriesAsync())
            {
                dataTable.Rows.Add(  series.Name);
            }
          //  gridLookUpEdit1.Properties.ValueMember = "ID";
            gridLookUpEditInvoiceSeries.Properties.DisplayMember = "Name";
            gridLookUpEditInvoiceSeries.Properties.DataSource = dataTable;
            gridLookUpEditInvoiceSeries.Properties.View.FocusedRowHandle = 0;
        } 
        private async System.Threading.Tasks.Task Template()
        {
            DataTable dataTable = new DataTable();
         //   dataTable.Columns.Add("ID", typeof(int));
            dataTable.Columns.Add("Name", typeof(string));
            foreach (var template in await _templates.GetTemplatesAsync())
            {
                dataTable.Rows.Add(  template.Name);
            }
          //  gridLookUpEdit2.Properties.ValueMember = "ID";
            gridLookUpEditInvoIceTemplate.Properties.DisplayMember = "Name";
            gridLookUpEditInvoIceTemplate.Properties.DataSource = dataTable;
            gridLookUpEditInvoIceTemplate.Properties.View.FocusedRowHandle = 0;
        } 
        private void Ileti()
        {
            DataTable dataTable = new DataTable();
            dataTable.Columns.Add("İleti", typeof(string));
            dataTable.Rows.Add("Elektronik");
            dataTable.Rows.Add("Kağıt"); 
            gridLookUpEditSendType.Properties.ValueMember = "İleti";
            gridLookUpEditSendType.Properties.DisplayMember = "İleti";
            gridLookUpEditSendType.Properties.DataSource = dataTable;
            gridLookUpEditSendType.Properties.View.FocusedRowHandle = 0;
        } 
        private void Saleschannel()
        {
            DataTable dataTable = new DataTable();
            dataTable.Columns.Add("SatışKanali", typeof(string));
            dataTable.Rows.Add("Normal Satış");
            dataTable.Rows.Add("İnternet Satışı"); 
            gridLookUpEditSalesPlatform.Properties.ValueMember = "SatışKanali";
            gridLookUpEditSalesPlatform.Properties.DisplayMember = "SatışKanali";
            gridLookUpEditSalesPlatform.Properties.DataSource = dataTable;
            gridLookUpEditSalesPlatform.Properties.View.FocusedRowHandle = 0;
        }
        private void Currency()
        {
            DataTable dataTable = new DataTable();
            dataTable.Columns.Add("Doviz", typeof(string));
            dataTable.Rows.Add("Türk Lirası");
            dataTable.Rows.Add("Amarikan Doları");
            dataTable.Rows.Add("Euro");
            gridLookUpEditCurrencyCode.Properties.ValueMember = "Doviz";
            gridLookUpEditCurrencyCode.Properties.DisplayMember = "Doviz";
            gridLookUpEditCurrencyCode.Properties.DataSource = dataTable;
            gridLookUpEditCurrencyCode.Properties.View.FocusedRowHandle = 0;

        } 
        private void InvoriceType()
        {
            DataTable dataTable = new DataTable();
            dataTable.Columns.Add("FaturaTuru", typeof(string));
            dataTable.Rows.Add("Satış");
            dataTable.Rows.Add("İade");
            dataTable.Rows.Add("Tevkifat");
            dataTable.Rows.Add("Tevkifat iade");
            dataTable.Rows.Add("Vergi istisna");
            dataTable.Rows.Add("İhracat kayıtlı");
            gridLookUpEditInvoiceType.Properties.ValueMember = "FaturaTuru";
            gridLookUpEditInvoiceType.Properties.DisplayMember = "FaturaTuru";
            gridLookUpEditInvoiceType.Properties.DataSource = dataTable;
            gridLookUpEditInvoiceType.Properties.View.FocusedRowHandle = 0;
        }
        private void InvoriceScenario()
        {
            DataTable dataTable = new DataTable();
            dataTable.Columns.Add("FaturaSenaryosu", typeof(string));
            dataTable.Rows.Add("E-Arşiv Fatura"); 
            gridLookUpEdit7.Properties.ValueMember = "FaturaTuru";
            gridLookUpEdit7.Properties.DisplayMember = "FaturaTuru";
            gridLookUpEdit7.Properties.DataSource = dataTable;
            gridLookUpEdit7.Properties.View.FocusedRowHandle = 0;
        }
    }
}
