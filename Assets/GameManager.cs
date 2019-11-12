using UnityEngine;

public class GameManager : MonoBehaviour
{
    GameObject ball;
    public GameObject ballPrefab;
    public GameObject paddle;
    public GameObject sideWall;
    public GameObject goalWall;

    static int playerPoints = 0, aiPoints = 0;

    private void Awake()
    {
        Instantiate(ballPrefab);
        ball = GameObject.FindWithTag("Ball");
    }

    public void Score(bool player)
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
        Debug.Log(playerPoints);

    }
}
