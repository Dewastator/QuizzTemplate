using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

[Serializable]
public class Question
{
    public string question;
    public Dictionary<string, bool> answers = new Dictionary<string, bool>(4);
    
    public void ShuffleAnswers()
    {
        System.Random rand = new System.Random();
        answers = answers.OrderBy(x => rand.Next())
          .ToDictionary(item => item.Key, item => item.Value);
    }
}
