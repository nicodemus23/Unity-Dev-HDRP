using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField] TMP_Text scoreText;

    private int score = 0;
    private float health = 100.0f;

    public int Score { 
        get { return score; }
        set { score = value; scoreText.text = score.ToString(); }
    }   

    public void AddPoints(int points)
    {
        Score += points;
    }
}
