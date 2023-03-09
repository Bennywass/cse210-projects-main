public class JournalLog

{
    private List<Entry> entries = new List<Entry> ();

    public void newEntry()
    {
        Entry entry = new Entry();

        Prompts prompts = new Prompts(); 
        entry.prompt = prompts.getPrompt();

        Console.WriteLine();
        Console.WriteLine(entry.prompt);

        Console.Write("> ");
        entry.entry = Console.ReadLine();

        DateTime theCurrentTime = DateTime.Now;
        entry.date = theCurrentTime.ToShortDateString();

        entries.Add(entry);
    }



    public void saveEntry()
    {
            Console.WriteLine("Input the file name: ");
            Console.Write("> ");
            string fileName = Console.ReadLine();
            using (StreamWriter outputFile = new StreamWriter(fileName, false))
            {

                // You can add text to the file with the WriteLine method
                foreach(var entry in entries)
                    outputFile.WriteLine(entries.Last().toString());
            }

    }

    public void readEntries(){

        try
        {

        

        Console.WriteLine("Input the file name: ");
        Console.Write("> ");
        string fileName = Console.ReadLine();

        string[] lines = System.IO.File.ReadAllLines(fileName);

        foreach (string line in lines)
        {
            string[] parts = line.Split(";");

            Entry retrievedEntry = new Entry();
            retrievedEntry.date = parts[0];
            retrievedEntry.prompt = parts[1];
            retrievedEntry.entry = parts[2];

            if(!entries.Contains(retrievedEntry))
                entries.Add(retrievedEntry);
        }

        }


        catch
        {
            Console.WriteLine("ERROR FILE NOT FOUND");
        }
    }


    public void displayEntries()
    {
        foreach(Entry item in entries)
        {
            Console.WriteLine(item.readableText());
        }
    }
}