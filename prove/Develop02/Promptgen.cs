using System;
using System.Runtime.InteropServices;

public class PromptGenerator
{
    public readonly List<string> journalPrompts = new List<string>
    {
        "What was the most memorable part of your day and why?",
        "Describe a challenge you faced today and how you handled it.",
        "What is something you learned today, big or small?",
        "Write about a moment that made you smile today.",
        "How did you practice gratitude today?",
        "What is one goal you accomplished today?",
        "Describe a conversation that stood out to you today.",
        "What is one thing you wish you had done differently today?",
        "How did you step out of your comfort zone today?",
        "What is something new you tried or experienced today?",
        "What is a thought or feeling that has been on your mind today?",
        "If you could relive one moment from today, what would it be and why?",
        "What was the most peaceful or relaxing moment of your day?",
        "Describe someone who had a positive impact on your day.",
        "What is something you did for yourself today that made you feel good?",
        "What inspired you today, and how did it affect you?",
        "If today were a chapter in your life story, what would the title be?",
        "What is one thing you are looking forward to tomorrow?",
        "Write about a lesson today taught you about life.",
        "Describe how you felt at different points throughout the day."
    };
    public Random rnd = new();
    public List<int> unusedprompts;

    public PromptGenerator() {
        unusedprompts = Enumerable.Range(0, journalPrompts.Count).ToList();
    }

    public string GetPrompt() {
        if (unusedprompts.Count == 0) unusedprompts = Enumerable.Range(0, journalPrompts.Count).ToList();
        
        int i = rnd.Next(unusedprompts.Count);
        unusedprompts.Remove(i);
        return journalPrompts[i];
    }

}