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

    Dictionary<string, bool> answers = new Dictionary<string, bool>();

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
        foreach(KeyValuePair<string, bool> answer in answers)
        {
            buttons[i].GetComponentInChildren<TMP_Text>().text = answer.Key;
            i++;
        }

    }


    public void Answer(int index)
    {
        string answer = buttons[index].GetComponentInChildren<TMP_Text>().text;
        bool correct = answers[answer];
        if (correct)
            Debug.Log("CORRECT");
        else
            Debug.Log("FAIL");
    }
}
