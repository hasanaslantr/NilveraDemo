using iTextSharp.text.pdf;
using iTextSharp.text;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DemoInvoncie.ConvertProcess
{
    public class ConvertStringToPdf
    {
        public async Task<DialogResult> stringToPdfAsync(string pdfString)
        {
            try
            {
                Document doc = new Document();
                MemoryStream memoryStream = new MemoryStream();
                PdfWriter writer = PdfWriter.GetInstance(doc, memoryStream);
                doc.Open();
                doc.Add(new Paragraph(pdfString));
                doc.Close();

                SaveFileDialog saveFileDialog = new SaveFileDialog();
                saveFileDialog.Filter = "PDF Dosyaları|*.pdf";
                saveFileDialog.Title = "PDF Dosyasını Kaydet";

                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    File.WriteAllBytes(saveFileDialog.FileName, memoryStream.ToArray());
                   return MessageBox.Show("Dosyanız başarılı bir şekilde kaydedildi", "Bilgi Mesajı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                   return MessageBox.Show("Dosya kaydetme işlemi iptal edildi", "Uyarı Mesajı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception error)
            {
               return MessageBox.Show(error.Message, "Hata Mesajı", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

        }
    }
}
