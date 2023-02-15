using System;
using System.Collections.Generic;
using System.Linq;

[Serializable]
public class Question
{
    public string question;
    public List<Answer> answers = new List<Answer>();

    public void ShuffleAnswers()
    {
        System.Random rand = new System.Random();
        answers = answers.OrderBy(x => Guid.NewGuid()).ToList();

    }

    public void CreateQuestion()
    {
        question = "Koliko vidis prstiju?";

        bool val;
        for (int i = 0; i < 4; i++)
        {
            val = i == 0;
            string answerText = (1300 * (i + 1)).ToString();
            Answer answer = new Answer(answerText, val);
            answers.Add(answer);
        }
    }
}
