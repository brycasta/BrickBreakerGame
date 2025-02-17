using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BreakBrick : MonoBehaviour
{
    // Variables
    [SerializeField, Range(1, 20)] protected int hitPoints;
    [SerializeField, Range(1, 20)] protected int pointValue;
    protected int currentHitPoints = 0;

    // Break Emitter
    [SerializeField] ParticleSystem hit_PS;

    // Methods
    private void Awake()
    {
        currentHitPoints = hitPoints;
    }
    public void Break(int aDamage)
    {
        currentHitPoints -= aDamage;
        hit_PS.Play();
        DestroyBrick();
    }

    protected void DestroyBrick()
    {
        if (currentHitPoints < 0)
        {
            // Can Add Animations Here
            //FindObjectOfType<RoundManager>().RemoveBrick(this);
            GameManager.Instance.AddScore(pointValue);

            Destroy(gameObject);
        }
    }

    // Accessors
}