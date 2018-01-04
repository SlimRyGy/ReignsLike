using System.Collections.Generic;

[System.Serializable]
public class Questions
{
    public string question;

    public string answerYes;
    public string answerNo;
    
    public List<Effect> effects_yes = new List<Effect>();
    public List<Effect> effects_no = new List<Effect>();
}