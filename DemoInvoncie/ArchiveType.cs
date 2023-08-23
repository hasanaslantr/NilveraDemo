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
            dateEdit1.EditValue = DateTime.Now;


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
            gridLookUpEdit1.Properties.DisplayMember = "Name";
            gridLookUpEdit1.Properties.DataSource = dataTable;
            gridLookUpEdit1.Properties.View.FocusedRowHandle = 0;
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
            gridLookUpEdit2.Properties.DisplayMember = "Name";
            gridLookUpEdit2.Properties.DataSource = dataTable;
            gridLookUpEdit2.Properties.View.FocusedRowHandle = 0;
        } 
        private void Ileti()
        {
            DataTable dataTable = new DataTable();
            dataTable.Columns.Add("İleti", typeof(string));
            dataTable.Rows.Add("Elektronik");
            dataTable.Rows.Add("Kağıt"); 
            gridLookUpEdit4.Properties.ValueMember = "İleti";
            gridLookUpEdit4.Properties.DisplayMember = "İleti";
            gridLookUpEdit4.Properties.DataSource = dataTable;
            gridLookUpEdit4.Properties.View.FocusedRowHandle = 0;
        } 
        private void Saleschannel()
        {
            DataTable dataTable = new DataTable();
            dataTable.Columns.Add("SatışKanali", typeof(string));
            dataTable.Rows.Add("Normal Satış");
            dataTable.Rows.Add("İnternet Satışı"); 
            gridLookUpEdit3.Properties.ValueMember = "SatışKanali";
            gridLookUpEdit3.Properties.DisplayMember = "SatışKanali";
            gridLookUpEdit3.Properties.DataSource = dataTable;
            gridLookUpEdit3.Properties.View.FocusedRowHandle = 0;
        }
        private void Currency()
        {
            DataTable dataTable = new DataTable();
            dataTable.Columns.Add("Doviz", typeof(string));
            dataTable.Rows.Add("Türk Lirası");
            dataTable.Rows.Add("Amarikan Doları");
            dataTable.Rows.Add("Euro");
            gridLookUpEdit5.Properties.ValueMember = "Doviz";
            gridLookUpEdit5.Properties.DisplayMember = "Doviz";
            gridLookUpEdit5.Properties.DataSource = dataTable;
            gridLookUpEdit5.Properties.View.FocusedRowHandle = 0;

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
            gridLookUpEdit6.Properties.ValueMember = "FaturaTuru";
            gridLookUpEdit6.Properties.DisplayMember = "FaturaTuru";
            gridLookUpEdit6.Properties.DataSource = dataTable;
            gridLookUpEdit6.Properties.View.FocusedRowHandle = 0;
        } 
    }
}
