using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Paddle : MonoBehaviour
{
    [SerializeField] float UnityWidth = 16f;
    [SerializeField] float minX = 1f;
    [SerializeField] float maxX = 15f;

    //cached components
    GameStatus myGame;
    Ball myBall;
   
    void Start()
    {
        myGame = FindObjectOfType<GameStatus>();
        myBall = FindObjectOfType<Ball>();
    }

    // Update is called once per frame
    void Update()
    {
        Vector2 PaddlePos = new Vector2(transform.position.x, transform.position.y);
        PaddlePos.x = Mathf.Clamp(GetPosX(), minX, maxX);
        transform.position = PaddlePos;
    }

    private float GetPosX()
    {
        if(myGame.IsAutoPlayEnabled())
        {
            return myBall.transform.position.x;
        }
        else
        {
            return Input.mousePosition.x / Screen.width * UnityWidth;
        }
    }
}
