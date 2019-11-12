using UnityEngine;

public class GameManager : MonoBehaviour
{
    public GameObject ball;
    public GameObject paddle;
    public GameObject sideWall;
    public GameObject goalWall;

    static int playerPoints = 0, aiPoints = 0;

    private void Awake()
    {
        Instantiate(ball);
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
