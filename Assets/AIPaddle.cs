using UnityEngine;

public class AIPaddle : MonoBehaviour
{
    float dir;
    public float speed;
    float vel;
    float move;

    GameObject ball;

    // Start is called before the first frame update
    void Start()
    {
        vel = 0;
        ball = GameObject.FindWithTag("Ball");
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        dir = transform.position.x - ball.transform.position.x;
        if (dir < 0)
        {
            move = speed * Mathf.Min(dir, 1.0f);
        }
        else if (dir > 0)
        {
            move = -(speed * Mathf.Min(-dir, 1.0f));
        }
        if(move > 5)
        Debug.Log(move);
        vel = -move * Time.deltaTime;
        if ((this.transform.position.x < GameObject.FindWithTag("WallLeft").transform.position.x + GameObject.FindWithTag("WallLeft").transform.localScale.x / 2 + this.transform.localScale.x / 2 && vel < 0) || (this.transform.position.x > GameObject.FindWithTag("WallRight").transform.position.x - GameObject.FindWithTag("WallLeft").transform.localScale.x / 2 - this.transform.localScale.x / 2 && vel > 0))
        {
            vel = 0;
        }
        transform.Translate(new Vector2(vel, 0));
    }
}
