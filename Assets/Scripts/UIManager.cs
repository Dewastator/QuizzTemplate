using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class UIManager : MonoBehaviour
{
    public ListOfQuestions ListOfQuestions;
    public IntValue currentIndex;

    [SerializeField]
    List<Transform> buttons;

    [SerializeField]
    TMP_Text questionText;


    private void Start()
    {
        PopulateQuestion();
    }

    private void PopulateQuestion()
    {
        Question question = ListOfQuestions.questions[currentIndex.Value];
        questionText.text = question.question;
        question.ShuffleAnswers();
        int i = 0;
        foreach(string answer in question.answers)
        {
            buttons[i].GetComponentInChildren<TMP_Text>().text = answer;
            i++;
        }

    }


    public void Answer(int index)
    {
        int answerIndex = ListOfQuestions.questions[currentIndex.Value].answerIndex;
        string answerText = ListOfQuestions.questions[currentIndex.Value].answers[answerIndex];

        string buttonText = buttons[index].GetComponentInChildren<TMP_Text>().text;
        bool correct = answerText == buttonText;

        ResetQuestion();
        if (correct)
        {
            Debug.Log("CORRECT");
        }
        else
        {
            Debug.Log("FALSE");
        }
    }

    private void ResetQuestion()
    {

        currentIndex.Value = UnityEngine.Random.Range(0, ListOfQuestions.questions.Count);
        PopulateQuestion();

    }
}
