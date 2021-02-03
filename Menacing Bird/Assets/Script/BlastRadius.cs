using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlastRadius : MonoBehaviour
{
    public BlackBird bird;
    private bool isBirdDestroyed;

    // Start is called before the first frame update
    void Start()
    {

    }

    void OnTriggerStay2D(Collider2D col)
    {
        if (col.gameObject.tag == "Enemy" || col.gameObject.tag == "Obstacle")
        {
            Vector2 direction = col.gameObject.transform.position + bird.transform.position;
            col.gameObject.GetComponent<Rigidbody2D>().AddForce(new Vector2(bird._boomForce / direction.x, bird._boomForce / direction.y));

            if (!isBirdDestroyed)
            {
                isBirdDestroyed = true;
                Destroy(bird.gameObject);
            }
        }
    }
}
