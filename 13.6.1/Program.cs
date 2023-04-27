using System.Diagnostics;

namespace PhoneBook
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Укажите ссылку на ваш текстовый файл");
            var fileLink=Console.ReadLine();
            
            var list = new List<string>();
            var list2 = new LinkedList<string>();
            string text;
            StreamReader sr = new StreamReader(fileLink);


            var watchTwo = Stopwatch.StartNew();

            text = sr.ReadLine();
            while (text != null)
            {
                list.Add(text);
                //Read the next line
                text = sr.ReadLine();
            }

            watchTwo.Stop();
            sr.Close();
            Console.WriteLine(list.Count);

            Console.WriteLine($"Вставка в список List: {watchTwo.Elapsed.TotalMilliseconds}  мс");

            StreamReader sr2 = new StreamReader(fileLink);
            var watchTwo2 = Stopwatch.StartNew();


            text = sr2.ReadLine();
            while (text != null)
            {
                list2.AddFirst(text);

                text = sr2.ReadLine();
            }

            watchTwo2.Stop();
            sr2.Close();
            Console.WriteLine(list2.Count);

            Console.WriteLine($"Вставка в список LinkedList: {watchTwo2.Elapsed.TotalMilliseconds}  мс");
        }
    }
}
