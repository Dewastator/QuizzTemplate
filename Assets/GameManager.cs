using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public ListOfQuestions ListOfQuestions;
    public IntValue currentIndex;


    private void Awake()
    {
        //TODO: Questions from server
        currentIndex.Value = 0;
        Question question = new Question();
        question.question = "Koliko vidis prstiju?";
        bool val;
        for (int i = 0; i < 4; i++)
        {
            val = i == 0;
            question.answers.Add((1300 * (i + 1)).ToString(), val);
        }
        question.ShuffleAnswers();
        ListOfQuestions.questions.Add(question);
    }

    public void Play()
    {
        //TODO: List Shuffle

        //TODO: Answers Shuffle

    }
}
