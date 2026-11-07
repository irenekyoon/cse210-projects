using System;

class Program
{
    static void Main(string[] args)
    {
        List<string> prompts = new List<string>();



        public static string GetRandomPrompt()
    {
        string p1 = "best moment";
        string p2 = "best smile";
        string p3 = "best kindness";
        string p4 = "do better tomorrow moment";
        string p5 = "gratitute momemt";

        List<string> prompts = new List<string>();
        prompts.Add(p1);
        prompts.Add(p2);
        prompts.Add(p3);
        prompts.Add(p4);
        prompts.Add(p5);

        for (int i = 0; i < prompts.Count; i++)
        {
            Random randomGenerator = new Random();
            int number = randomGenerator.Next(1, 6);
            if (number == i)
            {

            }

        }

        return "";
    }
}
}