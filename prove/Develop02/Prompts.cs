public class Prompts

{
    List<string> prompts = new List<string>(){
        "How are you today?", "What's your favorite color?", "What did you eat this morning?",
        "What's the name of your best friend?", "Top 10 numbers. Go!"
    };

    public string getPrompt(){
        Random rand = new Random();
        int randNumber = rand.Next(prompts.Count());
        return prompts[randNumber];
    }
}