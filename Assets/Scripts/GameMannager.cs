// Bryan Castaneda
// 1/23/2025

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    // Variables
    private static GameManager instance;
    private float playerScore = 0;

    // Methods
    public void ResetScore()
    {
        playerScore = 0;
    }

    public void AddScore(float aScore)
    {
        playerScore += aScore;
        foreach (ScoreDisplay sd in FindObjectsOfType<ScoreDisplay>())
        {
            sd.ChangeScore();
        }
    }
    #region sceneManager
    public void NextScene()
    {
        int nextScene = SceneManager.GetActiveScene().buildIndex + 1;

        if (nextScene >= SceneManager.sceneCountInBuildSettings - 1)
        {
            SceneManager.LoadScene(0);
        }
        else
        {
            SceneManager.LoadScene(nextScene);
        }
        if (nextScene == 1)
        {
            ResetScore();
        }
    }
    public void StartScene()
    {
        SceneManager.LoadScene(0);
    }
    #endregion


    // Accessors
    public static GameManager Instance
    {
        get
        {
            if (instance == null)
            {
                GameObject aGO = new GameObject("Game Manager");
                instance = aGO.AddComponent<GameManager>();
                DontDestroyOnLoad(aGO);
            }
            return instance;
        }
    }

    public float PlayerScore { get { return playerScore; } }

}