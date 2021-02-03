using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlackBird : Bird
{
    [SerializeField]
    public float _boomForce = 500;
    public CircleCollider2D BlastRadius;

    new void Start()
    {
        base.Start();
        BlastRadius.GetComponent<CircleCollider2D>().enabled = false;
    }

    void OnCollisionEnter2D(Collision2D col)
    {
        if (col.gameObject.tag == "Enemy" || col.gameObject.tag == "Obstacle")
        {
            BlastRadius.GetComponent<CircleCollider2D>().enabled = true;
        }
    }
}


