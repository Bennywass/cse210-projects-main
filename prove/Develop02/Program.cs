using System;

class Program
{
    static void Main(string[] args)

    {
        
        JournalLog journalLog = new JournalLog();
        

        string input = "words";

        Console.WriteLine();
        Console.WriteLine("Welcome to the journal program.");

        // Do While to keep the journal up until the user quits.
        do 
        {

            // display options for user.
            Console.WriteLine();
            Console.WriteLine("What would you like to do?");
            Console.WriteLine("1: Entry");
            Console.WriteLine("2: Save");
            Console.WriteLine("3: Display");
            Console.WriteLine("4: Load");
            Console.WriteLine("5: Quit");

            // Get input.
            Console.Write("> ");
            input = Console.ReadLine();

            // This is for getting the random entry and have the user input 
            if(input == "1"){
                journalLog.newEntry();
            }

            // To save all elements from our list to a text file.
            else if(input == "2"){
                journalLog.saveEntry();
            }

            // To display elements from the text file.
            else if(input == "3"){
                journalLog.displayEntries();
            }

            // load and read the entries list.
            else if(input == "4")
            {
                journalLog.readEntries();
            }
        
        
        } while(input != "5");

        
    }

}