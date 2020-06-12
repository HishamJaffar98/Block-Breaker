using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{
    //Params
    [SerializeField] Paddle paddle1;
    [SerializeField] float xPush = 2f;
    [SerializeField] float yPush = 15f;
    [SerializeField] AudioClip[] ballSounds;
    [SerializeField] GameObject ballTrail;
    [Range(0.3f,10f)] [SerializeField] float randomFactor;
    Vector2 paddleToBallVector;
    bool hasStarted = false;

    //Cached Components
    AudioSource myAudioSource;
    Rigidbody2D ballRigidBody;

    // Start is called before the first frame update
    void Start()
    {
        paddleToBallVector = transform.position - paddle1.transform.position;
        myAudioSource = GetComponent<AudioSource>();
        ballRigidBody = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if(hasStarted == false)
        {
            LockBall();
            LaunchBall();
            ballTrail.SetActive(false);
        }
        else
        {
            ballTrail.SetActive(true);
        }
    }

    private void LockBall()
    {
        Vector2 PaddlePos = new Vector2(paddle1.transform.position.x, paddle1.transform.position.y);
        transform.position = PaddlePos + paddleToBallVector;
    }

    private void LaunchBall()
    {
        if(Input.GetMouseButtonDown(0))
        {
            hasStarted = true;
            ballRigidBody.velocity = new Vector2(xPush,yPush);
        }
    }

    private void OnCollisionEnter2D()
    {
        if(hasStarted == true)
        {
            Vector2 velocityTweak = new Vector2(UnityEngine.Random.Range(2f, randomFactor), UnityEngine.Random.Range(2f, randomFactor));
            AudioClip newClip = ballSounds[UnityEngine.Random.Range(0, ballSounds.Length)];
            myAudioSource.PlayOneShot(newClip);
            ballRigidBody.velocity += velocityTweak;
        }
    }
}
