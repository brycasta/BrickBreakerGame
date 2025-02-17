using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameEnder : MonoBehaviour
{
    // Variables

    // Methods
    private void OnCollisionEnter(Collision collision)
    {
        GameManager.Instance.StartScene();
    }

    // Accessors
}