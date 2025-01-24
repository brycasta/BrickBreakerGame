// Bryan Castaneda
// 1/23/2025

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameMannager : MonoBehaviour
{

    // Vars
    private static GameMannager instance;
    private float playerScore = 0;


    // Methods


    // Accessors
    public static GameMannager Instance
    { 
        get 
        {
            if (instance == null)
            {
                GameObject aGO = new GameObject("Game Manager");
                instance = aGO.AddComponent<GameMannager>();
                DontDestroyOnLoad(aGO);
            }
            return instance;

        }
    }

}
