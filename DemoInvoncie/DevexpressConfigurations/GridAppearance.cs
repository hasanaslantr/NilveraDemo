using DevExpress.XtraGrid;
using System;
using System.IO;
using System.Windows.Forms;

namespace DemoInvoncie.DevexpressConfigurations
{
    public class GridAppearance
    {

        public DialogResult GridSave(string formName, GridControl grid)
        {
            // Dosyayı kontrol edelim, yoksa oluşturalım
            try
            {
                string fileName = @"Appearance\" + formName + "_" + grid.Name + ".xml";
                if (!File.Exists(fileName))
                {
                    using (FileStream fs = File.Create(fileName)) { }
                }
                grid.MainView.SaveLayoutToXml(fileName);
                return MessageBox.Show("Tablo görünümünüz kaydedildi", "Bilgi Mesajı", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {

                return MessageBox.Show("Hata oluştu: " + ex.Message, "Hata Mesajı", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        public void GridApp(string formName, GridControl grid)
        {
            try
            {
                string fileName = @"Appearance\" + formName + "_" + grid.Name + ".xml";
                grid.MainView.RestoreLayoutFromXml(fileName);
            }
            catch (Exception) { }
        }
    }
}
