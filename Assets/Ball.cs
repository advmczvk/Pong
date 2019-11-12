using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{
    public float speed = 10f;
    Vector2 dir;
    // Start is called before the first frame update
    void Start()
    {
        dir = new Vector2(1, -1);
        this.transform.Translate(new Vector2(-2, 0));
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        this.transform.Translate(dir * Time.deltaTime * speed);
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.collider.tag == "WallLeft" || collision.collider.tag == "WallRight")
        {
            dir.x *= -1;
        }
        else if (collision.collider.tag == "Goal")
        {
            GameManager.Score(true);
        }
        else
        {
            dir.y *= -1;
        }
    }
}
