namespace scripture_memorizer
{
    public partial class Book
    {
        public string GetRange(int chapter, int verse)
        {
            Verse v = chapters[chapter - 1].verses[verse - 1];
            return v.reference + "\n" + v.text;
        }


        public string GetRange(int chapter, int verseFrom, int verseTo)
        {
            //string txt = book + " " + chapter + "\n";
            string txt = "";

            while (verseFrom < verseTo)
            {
                Verse v = chapters[chapter - 1].verses[verseFrom - 1];

                //txt += v.verse + " ";
                txt += v.text + "\n";

                verseFrom++;
            }
            return txt.Trim();
        }
    }

    public partial class Chapter{
        public string GetRange(int verseFrom, int length)
        {
            int verseTo = verseFrom + length;
            string txt = "";

            while (verseFrom < verseTo)
            {
                Verse v = verses[verseFrom - 1];

                txt += v.text + " ";

                verseFrom++;
            }
            return txt.Trim();
        }
    }
}