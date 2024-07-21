using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Linq;
using System.Xml.Serialization;

namespace QuizMaker
{
    public class XmlService
    {
        string path;
        public XDocument active;

        public XmlService(string path)
        {
            this.path = path;
            active = XDocument.Load(path);
        }

        public List<QuesAndAns> GetListOfQuesAndAns()
        {
            return (from c in active.Root.Descendants("QuesAndAns")
                   select (new QuesAndAns(c.Element("Question").Value,
                          c.Element("Answer").Value))).ToList<QuesAndAns>();
        }

        public void AddQuesAndAnsToXML(QuesAndAns quesAndAns)
        {
            active.Root.Add(new XElement("QuesAndAns", 
                new XElement("Question", quesAndAns.Question), 
                new XElement("Answer", quesAndAns.Answer)));
            active.Save(path);
        }


    }
}
