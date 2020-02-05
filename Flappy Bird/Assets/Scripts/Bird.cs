using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bird : MonoBehaviour
{
    // Start is called before the first frame update
    
    public GameManager gameManager;
    private const float JUMP_AMOUNT = 8f;
    private static Bird instance;
    public Vector3 startPosition;

    void Start()
    {
        instance.transform.position = startPosition;
    }
    public static Bird GetInstance()
    {
        return instance;
    }
    private Rigidbody2D birdRigidBody2D;
    private void Awake()
    {
        instance = this;
        birdRigidBody2D = GetComponent<Rigidbody2D>();
    }
    // Update is called once per frame
    private void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space))
        {
            Jump();
        }
    }
    private void Jump()
    {
        if (gameManager.mode == GameManager.Mode.Menu)
        {
            gameManager.mode = GameManager.Mode.Start;
            gameManager.Restart();
        }
        else
        {
            if (gameManager.mode == GameManager.Mode.Start)
            {
                gameManager.mode = GameManager.Mode.Game;
            }
            birdRigidBody2D.velocity = Vector2.up * JUMP_AMOUNT;
        }
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        gameManager.GameOver();
    }
    public void resetBird()
    {
        instance.transform.position = startPosition;
    }

}
