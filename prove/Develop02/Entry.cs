using System.IO;

public class Entry : IEquatable<Entry>

{
    private char delimiter = ';';


    public string entry;
    public string prompt;
    public string date;

    public string toString(){

        string output = date + delimiter + prompt + delimiter + entry;

        return output;
    }

   public string readableText(){

        string output = date + " " + prompt + " " + entry;

        return output;
    }

    public bool Equals(Entry other)
    {
        return this.entry == other.entry 
        && this.date == other.date && this.prompt == other.prompt;
    }
}