using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameObject ball;
    public GameObject paddle;
    public GameObject sideWall;
    public GameObject goalWall;

    float screenHeight, screenWidth;
    static int playerPoints = 0, aiPoints = 0;

    private void Awake()
    {
        screenHeight = Camera.main.orthographicSize * 2;
        screenWidth = screenHeight * Screen.width / Screen.height;

        Instantiate(ball);
        //Left wall
        sideWall.transform.localScale = new Vector2(0.2f, screenHeight);
        Instantiate(sideWall, new Vector3(Camera.main.ScreenToWorldPoint(Vector2.zero).x, 0, 0), new Quaternion(0, 0, 0, 0));

        //Right wall
        sideWall.transform.localScale = new Vector2(0.2f, screenHeight);
        Instantiate(sideWall, new Vector3(Camera.main.ScreenToWorldPoint(new Vector2(Screen.width, Screen.height)).x, 0, 0), new Quaternion(0, 0, 0, 0));

        //Bottom wall
        goalWall.transform.localScale = new Vector2(screenWidth, 0.2f);
        Instantiate(goalWall, new Vector3(0, Camera.main.ScreenToWorldPoint(Vector2.zero).y, 0), new Quaternion(0, 0, 0, 0));

        //Top wall
        goalWall.transform.localScale = new Vector2(screenWidth, 0.2f);
        Instantiate(goalWall, new Vector3(0, Camera.main.ScreenToWorldPoint(new Vector2(Screen.width, Screen.height)).y, 0), new Quaternion(0, 0, 0, 0));
    }

    public static void Score(bool player)
    {
        if (player)
        {
            playerPoints++;
        }
        else
        {
            aiPoints++;
        }

        //TODO: Restart ball

    }
}
