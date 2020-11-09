using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using System.Xml;
using System.Xml.Linq;
using System.Xml.Schema;

namespace Assignment7
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select Service1.svc or Service1.svc.cs at the Solution Explorer and start debugging.
    public class Service1 : IService1
    {
        public List<string> searchByTagName(string xmlUrl, string tagName)
        {
            List<string> result = new List<string>();
            XmlDocument document = new XmlDocument();
            document.Load(xmlUrl);
            XmlNodeList nodeList = document.GetElementsByTagName(tagName);
            result.Add("Matching Searches Found:" + nodeList.Count);
            foreach(XmlNode node in nodeList)
            {
                result.Add("Node Values:->" + node.InnerText);
            }

            return result;
        }

        public string verifyXml(string xsdUrl, string xmlUrl)
        {
            string result = "No Errors Found";
            try
            {
                XmlSchemaSet schema = new XmlSchemaSet();
                schema.Add("", xsdUrl);

                var document = XDocument.Load(xmlUrl);

                document.Validate(schema, (o, e) =>
                {
                    result = "Not Validated: " + e.Message;
                });
            } catch (Exception e)
            {
                return "Unable to Load XML File Or XML Not Matching with XSD";
            }
          
            return result;
        }
    }
}
