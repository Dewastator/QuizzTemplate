using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "QuestionList", menuName = "Scriptables/QuestionList")]
public class ListOfQuestions : ScriptableObject
{
    public List<Question> questions = new List<Question>();
}
