using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Score : MonoBehaviour
{
    public static int Current_Score = 0;
    [SerializeField] TextMeshProUGUI text;

    public void Set_Score(int amount)
    {
        Current_Score += amount;
        PrintScore();
    }

    private void PrintScore()
    {
        Debug.Log(Current_Score);
        text.text = Current_Score.ToString();
    }


}
