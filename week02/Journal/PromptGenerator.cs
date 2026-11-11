using System;
using System.Collections.Generic;
public class PromptGenerator
{
    public static List<string> _prompts = new List<string>() {"What was the best part of your day?", "How did I see the hand of God today?", "How did I experience kindness today?", "What did I study in the scriptures today?", "What can I try to do better tomorrow?"};

    PromptGenerator()
    {
        
    }
    public static string GetRandomPrompt()
    {
        Random randomGenerator = new Random();
        int number = randomGenerator.Next(0, 4);

        return _prompts[number];
    }
}
