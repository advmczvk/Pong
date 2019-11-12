using UnityEngine;

public class Paddle : MonoBehaviour
{
    public float speed;
    float vel;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {

        vel = Input.GetAxis("Horizontal") * Time.deltaTime * speed;
        if ((this.transform.position.x < GameObject.FindWithTag("WallLeft").transform.position.x + GameObject.FindWithTag("WallLeft").transform.localScale.x / 2 + this.transform.localScale.x / 2 && vel < 0) || (this.transform.position.x > GameObject.FindWithTag("WallRight").transform.position.x - GameObject.FindWithTag("WallLeft").transform.localScale.x / 2 - this.transform.localScale.x / 2 && vel > 0))
        {
            vel = 0;
        }
        this.transform.Translate(vel, 0, 0);
    }
}
