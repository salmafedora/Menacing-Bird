using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlackBird : Bird
{
    [SerializeField]
    public float _boomForce = 5000;
    public CircleCollider2D BlastRadius;

    new void Start()
    {
        base.Start();
        BlastRadius.GetComponent<CircleCollider2D>().enabled = false;
    }

    void OnCollisionEnter2D(Collision2D col)
    {
        if (col.gameObject.tag == "Enemy" || col.gameObject.tag == "Obstacle" || col.gameObject.tag == "Woods")
        {
            BlastRadius.GetComponent<CircleCollider2D>().enabled = true;
        }
    }
}


