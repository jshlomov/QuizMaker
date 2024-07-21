using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuizMaker
{
    public class QuesAndAns
    {
        public string Question { get; set; }
        public string Answer { get; set; }

        public QuesAndAns(string question, string answer)
        {
            Question = question;
            Answer = answer;
        }

        public QuesAndAns()
        {
            
        }
    }
}
