using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Bryan Castaneda 
public class BallScript : MonoBehaviour
{
    // Vars
    protected Rigidbody rb;
    [SerializeField] protected float worldVelocity = 25;
    [SerializeField] protected Vector3 startForce = Vector3.zero;
    [SerializeField] protected int damage = 1;

    // Methods
    private void OnEnable()
    {
        rb = GetComponent<Rigidbody>();
        ApplyStartForce();
    }

    private void FixedUpdate()
    {
        LimitBallVelocity();
    }

    protected void ApplyStartForce()
    {
        rb.AddForce(startForce, ForceMode.Impulse);
    }
    protected void LimitBallVelocity()
    {
        Vector3 hV3 = rb.velocity;

        Vector3 nV3 = Vector3.zero;

        nV3.x = Mathf.Clamp(hV3.x, -worldVelocity, worldVelocity);
        nV3.y = Mathf.Clamp(hV3.y, -worldVelocity, worldVelocity);
        nV3.z = Mathf.Clamp(hV3.z, -worldVelocity, worldVelocity);

        rb.velocity = nV3;
    }

    private void OnCollisionEnter(Collision collision)
    {
        BreakBrick bb = collision.gameObject.GetComponent<BreakBrick>();
        if (bb != null)
        {
            bb.Break(damage);
        }

    }

    }
