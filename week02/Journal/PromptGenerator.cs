using System;
using System.Collections.Generic;
public class PromptGenerator
{
    public static List<string> _prompts = new List<string>() { "How can I be more kind to myself?", "How have I done any good in the world today?", "What is a favorite sin that I need to let go of?", "What is one thing I will regret not doing and why don't I do it?", "What is something virtuous, lovely or of good report that I experienced today?", "Who inspires me and why?", "Am I more focused on tasks or people today and why?", "Is the process or the goal more important to me today?", "What can I simplify in my life right now?", "Close your eyes and take 3 deep breaths. What comes to mind?", "What was the best part of your day?", "How did I see the hand of God today?", "How did I experience kindness today?", "What did I study in the scriptures today?", "What can I try to do better tomorrow?" };

    PromptGenerator()
    {

    }
    public static string GetRandomPrompt()
    {
        Random randomGenerator = new Random();
        int number = randomGenerator.Next(0, 14);

        return _prompts[number];
    }
}
