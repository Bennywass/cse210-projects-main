using System;
using System.Text.Json;
using System.Linq;
namespace scripture_memorizer
{
    partial class Program
    {

        static Dictionary<string, Book> scriptures = new Dictionary<string, Book>();
        static string path = "scriptures-json-1.0.1/scriptures-json-1.0.1/";
        static string[] jsonFiles =
        {
            "book-of-mormon",
            // "doctrine-and-covenants-modified",
            "new-testament",
            "old-testament",
            "pearl-of-great-price"
        };



        static void Main()
        {
            foreach (string fileName in jsonFiles)
            {
                string text = File.ReadAllText(path + fileName + ".json");
                Root jsonRoot = JsonSerializer.Deserialize<Root>(text);

                foreach (Book b in jsonRoot.books)
                    scriptures.Add(b.book, b);
            }

            Console.WriteLine("Welcome to the scripture memorizor.");
            Console.WriteLine();

            string input = "words";

            Flashcard flashcard = new Flashcard();

            Console.WriteLine("If you want to leave the programe, type 'quite'. If you want to hide words, press 'enter'.",
                "Otherwise, type the scritpures text.");

            Console.WriteLine("PLease provide a range of verses.");

            int num = Convert.ToInt32(Console.ReadLine());
            
            if(num <= 1){
            flashcard.getRandSrcript(scriptures);
            }
            
            else{
            flashcard.getRandRange(scriptures, num);
            }

            do
            {



                    //Console.ReadLine();

                Console.WriteLine(flashcard);
                Console.WriteLine();

                input = Console.ReadLine();



                if(input == flashcard.getOriginalText())
                {
                    Console.WriteLine("Congratulations! You did it!");
                    Console.WriteLine();
                }

                else if(input == "")
                {
                    flashcard.BlankWords();
                }


            }
            while(input != "quite" );

        }
    }
}