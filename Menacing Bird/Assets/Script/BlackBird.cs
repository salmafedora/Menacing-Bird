using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlackBird : Bird
{
    [SerializeField]
    public float _boomForce = 5000;

    public void OnCollisionEnter2D(Collision2D col)
    {
        if (col.gameObject.GetComponent<Rigidbody2D>() == null) return;
        if (col.gameObject.tag == "Enemy" || col.gameObject.tag == "Obstacle")
        {
            col.gameObject.GetComponent<Rigidbody2D>().AddForce(new Vector2(500, 500));
            Destroy(gameObject);
        }
    }
}
