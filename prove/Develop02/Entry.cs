using System;
public class Entry {
    public string prompt;
    public DateTime date;
    public string response;

    public void setResponse(string newResponse){
        response = newResponse;
    }

    public string displayEntry(){
        return date + " - " + prompt + " = " + response;
    }

    // Construct new entry from user
    public Entry(DateTime setDate) {
        PromptGenerator promptgen = new PromptGenerator();
        prompt = promptgen.GetPrompt();
        date = setDate;
    }

    public Entry(string newEntry){
        prompt = Split(char[],Int32)
        date =
        response =
    }
}