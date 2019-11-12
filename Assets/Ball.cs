using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{
    private GameObject gm;
    public float speed = 10f;
    Vector2 dir;
    // Start is called before the first frame update
    void Start()
    {
        Invoke("Init", 2);
        gm = GameObject.Find("GameManager");
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        this.transform.Translate(dir * Time.deltaTime * speed);
    }

    void Init()
    {
        dir = new Vector2(0, -1);
        this.transform.Translate(new Vector2(0, 0));
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.collider.tag == "WallLeft" || collision.collider.tag == "WallRight")
        {
            dir.x *= -1;
        }
        else if (collision.collider.tag == "Goal")
        {
            this.transform.position = Vector2.zero;
            gm.GetComponent<GameManager>().Score(true);
            dir = Vector2.zero;
            Invoke("Init", 2);
        }
        else
        {
            Debug.Log("Here");
            float hitPoint = (collision.collider.transform.position.x - this.transform.position.x) / collision.collider.bounds.size.x;
            Debug.Log(hitPoint);
            dir.x = hitPoint;
            dir.y *= -1;
        }
    }
}
