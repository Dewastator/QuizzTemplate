using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public ListOfQuestions ListOfQuestions;
    public IntValue currentIndex;


    private void Awake()
    {
        GetQuestionsFromJSON();

        //TODO: Questions from server
        currentIndex.Value = UnityEngine.Random.Range(0, ListOfQuestions.questions.Count);

    }

    private void GetQuestionsFromJSON()
    {
        string path = Application.dataPath + "/questions.json";
        string json = File.ReadAllText(path);

        QuestionList questionList = JsonUtility.FromJson<QuestionList>(json);
        ListOfQuestions.questions = questionList.questions;
        
    }

    public void Play()
    {
        //TODO: List Shuffle

        //TODO: Answers Shuffle

    }

}

[Serializable]
public class QuestionList
{
    public List<Question> questions;
}
