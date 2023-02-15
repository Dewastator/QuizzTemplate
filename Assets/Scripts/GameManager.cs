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
        Question question = new Question();
        question.CreateQuestion();        
        question.ShuffleAnswers();
        ListOfQuestions.questions.Add(question);
        currentIndex.Value++;

    }

    public void Play()
    {
        //TODO: List Shuffle

        //TODO: Answers Shuffle

    }
}
