using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace TryIt
{
    public partial class _Default : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            var xmlUrl = TextBox1.Text;
            var xsdUrl = TextBox2.Text;            
            SampleXmlService.Service1Client service = new SampleXmlService.Service1Client();
            var result = service.verifyXml(xsdUrl, xmlUrl);
            ListBox1.Items.Add(result);
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            var xmlUrl = TextBox3.Text;
            var tagName = TextBox4.Text;
            SampleXmlService.Service1Client service = new SampleXmlService.Service1Client();
            var result = service.searchByTagName(xmlUrl, tagName);

            foreach(string valu in result)
            {
                ListBox2.Items.Add(valu);
            }
        }
    }
}