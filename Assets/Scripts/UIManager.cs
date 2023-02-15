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

    public List<Answer> answers = new List<Answer>();

    private void Start()
    {
        PopulateQuestion();
    }

    private void PopulateQuestion()
    {
        Question question = ListOfQuestions.questions[currentIndex.Value];
        answers = question.answers;
        questionText.text = question.question;

        int i = 0;
        foreach(var answer in answers)
        {
            buttons[i].GetComponentInChildren<TMP_Text>().text = answer.answerText;
            i++;
        }

    }


    public void Answer(int index)
    {
        bool correct = answers[index].isCorrect;
        if (correct)
            Debug.Log("CORRECT");
        else
            Debug.Log("FAIL");
    }
}
