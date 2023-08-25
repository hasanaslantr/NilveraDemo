using System;
using System.IO;
using System.Threading.Tasks;
using System.Xml.Xsl;
using System.Xml.Linq;
using System.Text;
using System.Web.UI.WebControls;
using System.Xml;

namespace DemoInvoncie.ConvertProcess
{
    public class ConvertXmlToHtml
    {
        public async Task<string> XmlToHtmlAsync(string xmlString)
        {
            try
            { 
                XmlDocument xmlDocument = new XmlDocument();
                xmlDocument.LoadXml(xmlString);

                XslCompiledTransform transform = new XslCompiledTransform();
                transform.Load(@"InvoiceTemplate/transform.xslt");

                using (StringWriter htmlWriter = new StringWriter())
                {
                    transform.Transform(xmlDocument, new XsltArgumentList(), htmlWriter);
                    return htmlWriter.ToString();
                }
            }
            catch (Exception ex)
            {
                return "Dönüştürme sırasında bir hata oluştu: " + ex.Message;
            }

        }


    }
}
