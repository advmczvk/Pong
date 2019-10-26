using UnityEngine;

public class Paddle : MonoBehaviour
{
    Rigidbody2D rb;
    Vector2 position;
    bool isDown;
    // Start is called before the first frame update
    void Start()
    {
        position = transform.position;
        if(this.name == "PaddleDown")
        {
            isDown = true;
            rb.AddForce(position);
            
        }
        else
        {
            isDown = false;
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (isDown)
        {
            //if(Input.get)
        }
    }
}
