using System.Transactions;

public class Program
{
    public static void Main(string[] args)
    {
         {
            //Word word= new Word("truth");
            //Console.WriteLine(word.GetDisplayText());
     
            Console.WriteLine("Enter The scripture Book)");
            string book = Console.ReadLine();

            Console.WriteLine("Enter The scripture Chapter");
            int chapter = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter The scripture Verse");
            int verse = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter The scripture end verse");
            // int endVerse = int.Parse(Console.ReadLine());

            Console.WriteLine(" Enter the scripture text: ");
            string text = Console.ReadLine();

            List<Word> words= text.Split(" ").Select(x => new Word(x)).ToList();

            Reference reference= new Reference(book, chapter,verse);
            Scripture scripture = new Scripture(reference, words);

            do
            {
              
               scripture.Display();
               Console.WriteLine("Enter to hide a word to memorize, or quit");

               string userInput = Console.ReadLine();

               int wordsToHide = scripture.CountWords();
               if (wordsToHide > 0)
               {
                   scripture.HideWords(2);
               }
               else
               {
               scripture.HideWords(1);
               }
               if (userInput.ToLower() == "quit")
               {
               break;
            }
            
            }

            
            while (!scripture.IsCompletelyHidden());
            {
            Console.WriteLine ($"{scripture}");
            }

            Console.Clear();
            scripture.Display();
            Console.WriteLine("");

            Console.WriteLine("good");



            
        }    
    }
}
