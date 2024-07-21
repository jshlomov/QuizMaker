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

            //Create the file if not exists
            if (!File.Exists(path))
            {
                new XDocument(new XElement("Quiz",
                    new XElement("Item",
                        new XElement("Question", "why?"),
                        new XElement("Answer", "kaha."))))
                    .Save(path);
                return;
            }
            else
            active = XDocument.Load(path);
        }

        /// <summary>
        /// Get the list of question and answers from the xml file
        /// </summary>
        /// <returns>a list of QuesAndAns the contaun all the items. else return null</returns>
        public List<QuesAndAns>? GetListOfQuesAndAns()
        {
            return (from qa in active.Root.Elements()
                    select new QuesAndAns(qa.Element("Question").Value,
                    qa.Element("Answer").Value)).ToList();
        }

        public void AddQuesAndAnsToXML(QuesAndAns qa)
        {
            active.Root.Add(new XElement("Item",
                new XElement("Question", qa.Question),
                new XElement("Answer", qa.Answer)));
            active.Root.Save(path);
        }
    }
}