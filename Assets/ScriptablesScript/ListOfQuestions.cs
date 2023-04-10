using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
[CreateAssetMenu(fileName = "QuestionList", menuName = "Scriptables/QuestionList")]
public class ListOfQuestions : ScriptableObject
{
    public List<Question> questions = new List<Question>();
}
