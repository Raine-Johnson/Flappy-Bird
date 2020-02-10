using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bird : MonoBehaviour
{
    // Start is called before the first frame update
    
    public GameManager gameManager;
    private const float JUMP_AMOUNT = 10f;
    private static Bird bird;
    public Vector3 startPosition;

    public AudioSource flapAudio;
    public AudioSource dieAudio;

    void Start()
    {
        bird.transform.position = startPosition;
    }
    public static Bird GetInstance()
    {
        return bird;
    }
    private Rigidbody2D birdRigidBody2D;
    private void Awake()
    {
        bird = this;
        birdRigidBody2D = GetComponent<Rigidbody2D>();
    }
    // Update is called once per frame
    private void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space))
        {
            flapAudio.Play();
            Jump();
        }
    }
    private void Jump()
    {
        if (gameManager.mode == GameManager.Mode.Menu)
        {
            gameManager.setMode(GameManager.Mode.Start);
        }
        else
        {
            if (gameManager.mode == GameManager.Mode.Start)
            {
                gameManager.setMode(GameManager.Mode.Game);

            }
            birdRigidBody2D.velocity = Vector2.up * JUMP_AMOUNT;
        }
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        gameManager.setMode(GameManager.Mode.Menu);
        dieAudio.Play();
    }
    public void resetBird()
    {
        bird.transform.position = startPosition;
    }

}
