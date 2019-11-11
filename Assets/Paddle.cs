using UnityEngine;

public class Paddle : MonoBehaviour
{
    public float speed;
    float translation;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {

        translation = Input.GetAxis("Horizontal");
        Move(false);
        
    }

    private void Move(bool wallHit)
    {
        if (!wallHit)
        {
            this.transform.Translate(translation * Time.deltaTime * speed, 0, 0);
        }
        else
        {
            Debug.Log("In the wall!!!");
            this.transform.Translate(0, 0, 0);
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.collider.CompareTag("Wall"))
        {
            Move(true); //TODO Add movement restrictions
        }
    }
}
