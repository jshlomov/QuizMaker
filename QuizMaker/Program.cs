namespace QuizMaker
{
    internal class Program
    {
        static void Main(string[] args)
        {
            XmlService xml = new XmlService("data/data.xml");
            int input = 0;
            QuesAndAns quesAndAns = new QuesAndAns();

            while (input != -1)
            {
                Console.WriteLine("1. Create questions\n2. Answer Questions\nExit -1");
                input = int.Parse(Console.ReadLine());
                switch (input)
                {
                    case 1:
                        Console.WriteLine("Type your question");

                    default:
                        break;
                }
            }
            List<QuesAndAns> list = xml.GetListOfQuesAndAns();
            foreach (var item in list)
            {
                Console.WriteLine(item.Question);
                Console.WriteLine(item.Answer);

            }
        }

        public void CreateQueAndAns()
        {

        }
    }
}
