using System;
using System.Collections.Generic;
using System.Linq;

[Serializable]
public class Question
{
    public string question;
    public List<String> answers;
    public int answerIndex;

    public void ShuffleAnswers()
    {
        string correctAnswer = answers[answerIndex];

        Random rand = new Random();
        answers = answers.OrderBy(x => Guid.NewGuid()).ToList();

        for (int i = 0; i < answers.Count; i++)
        {
            if (answers[i].Equals(correctAnswer))
            {
                answerIndex = i;
            }
        }
    }
}
