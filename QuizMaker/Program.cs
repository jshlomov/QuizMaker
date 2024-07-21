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
                        quesAndAns.Question = Console.ReadLine();
                        Console.WriteLine("Type the answer");
                        quesAndAns.Answer = Console.ReadLine();
                        break;
                    case 2:
                        List<QuesAndAns> list = xml.GetListOfQuesAndAns();
                        foreach (var item in list)
                        {
                            int i = 1;
                            Console.WriteLine(i++ + ". " + item.Question);
                        }
                        Console.WriteLine("Choose question");
                        int index = int.Parse(Console.ReadLine());
                        Console.WriteLine("What is your answer (to exit press 0)");
                        while()


                        break;
                    default:
                        break;
                }
            }
        }
    }
}
