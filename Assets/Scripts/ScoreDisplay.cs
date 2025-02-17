
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

//Bryan Castaneda
public class ScoreDisplay : MonoBehaviour
{
    // Variables
    [SerializeField] protected TMP_Text scoreText;
    [SerializeField] protected string preText = "Score: ";
    [SerializeField] protected string postText = " pts";

    // Methods
    public void Start()
    {
        ChangeScore();
    }
    public void ChangeScore()
    {
        scoreText.text = preText + GameManager.Instance.PlayerScore + postText;
    }

    // Accessors
}