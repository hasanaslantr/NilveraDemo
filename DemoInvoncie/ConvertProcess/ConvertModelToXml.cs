﻿using NLayer.Entities.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Windows.Forms;
using System.Xml.Linq;
using System.Xml.Serialization;

namespace DemoInvoncie.ConvertProcess
{
    public class ConvertModelToXml<T> where T : class
    {
        public async Task< DialogResult> ModelToXmlAsync(T values)
        {
            try
            {
                return await Task.Run(() =>
                {
                    XmlSerializer serializer = new XmlSerializer(typeof(T));
                    using (SaveFileDialog saveFileDialog = new SaveFileDialog())
                    {
                        saveFileDialog.Filter = "XML Dosyaları|*.xml";
                        saveFileDialog.Title = "XML Dosyasını Kaydet";
                        if (saveFileDialog.ShowDialog() == DialogResult.OK)
                        {
                            string filePath = saveFileDialog.FileName;
                            using (TextWriter writer = new StreamWriter(filePath)) { serializer.Serialize(writer, values); }
                            return MessageBox.Show("Dosyanız başarılı bir şekilde kaydedildi", "Bilgi Mesajı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                            return MessageBox.Show("Dosyanız kayıt işlemi iptal edildi", "Uyarı Mesajı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                });

               
            }
            catch (Exception ex) { return MessageBox.Show(ex.Message, "Uyarı Mesajı", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }

        public async Task<string> ModelToXmlStringAsync(T values)
        {
           
                return await Task.Run(() =>
                {
                    XmlSerializer serializer = new XmlSerializer(typeof(T));
                    using (StringWriter stringWriter = new StringWriter())
                    {
                        serializer.Serialize(stringWriter, values);
                         return stringWriter.ToString();
                    }
                });
         


           

        }


    }
}
