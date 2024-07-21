using System;
using System.Collections.Generic;
using System.Dynamic;
using System.IO.Pipes;
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
            return (from qa in active.Elements()
                   select new QuesAndAns(qa.Element("Question").Value,
                   qa.Element("Answer").Value)).ToList();
        }

        public void AddQuesAndAnsToXML(QuesAndAns qa)
        {
            active.Add(new XElement("Item",
                new XElement("Question", qa.Question),
                new XElement("Answer", qa.Answer)));
            active.Save(path);
        }
    }
}