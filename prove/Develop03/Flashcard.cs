using System.Linq; 
namespace scripture_memorizer{


    public class Flashcard
    {
        string verse;

        string reference;
        string[] verseText;

        int blanks = 0;

        public void BlankWords()
        {
            for(int i = 0; i < 2; i++)
            {

                if(blanks >= verseText.Count()){
                    return;
                }

                Random rand = new Random();
                int index = rand.Next(verseText.Count());

                if(verseText[index] == "____"){
                    i--;
                    continue;
                }

                verseText[index] = "____";
                blanks++;
            }
        }

        public void getRandSrcript(Dictionary<string, Book> thing)
        {
            Random rand = new Random();
            Book b = thing.ElementAt(rand.Next(thing.Count())).Value;
            Chapter c = b.chapters.ElementAt(rand.Next(b.chapters.Count()));
            Verse v = c.verses.ElementAt(rand.Next(c.verses.Count()));

            verse = v.text;
            reference = v.reference;

            verseText = verse.Split(" ");
        }

        public void getRandRange(Dictionary<string, Book> thing, int num){
            Random rand = new Random();
            Book b = thing.ElementAt(rand.Next(thing.Count())).Value;
            Chapter c = b.chapters.ElementAt(rand.Next(b.chapters.Count()));
            int vidx = rand.Next(c.verses.Count() - num + 1);

            verse = c.GetRange(vidx, num );
            reference = c.reference + ":" + vidx + "-" + (vidx + num);

            verseText = verse.Split(" ");
        }

        public override string ToString()
        {
            return reference + "\n" + string.Join(' ', verseText);
        }

        public string getOriginalText(){
            return verse;
        }
    }
}