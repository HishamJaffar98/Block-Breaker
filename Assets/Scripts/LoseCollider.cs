using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoseCollider : MonoBehaviour
{
    [SerializeField] GameObject[] lifeSprites;
    [SerializeField] int livesGone = 0; //Serialized For Debugging Purposess
    [SerializeField] GameObject myBall;
    [SerializeField] GameObject myPaddle;

    Vector3 paddlePos;
    Vector3 ballPos;
    Vector3 ballandpaddif;
    Quaternion ballRot;

  
    public void Start()
    { 
        ballPos = myBall.transform.position;
        paddlePos = myPaddle.transform.position;
        ballandpaddif = ballPos - paddlePos;
        ballRot = myBall.transform.rotation;

    }

    public void Update()
    {
        paddlePos = myPaddle.transform.position;
    }
    public void OnTriggerEnter2D(Collider2D collision)
    {
        livesGone++;
        if (livesGone == 4)
        {
            SceneManager.LoadScene("GameOverScreen");
        }
        else if(livesGone<4)
        {
            GameObject newBall = Instantiate(myBall,paddlePos+ballandpaddif,ballRot);
            Destroy(lifeSprites[livesGone-1]);
        }
      
    }
}
