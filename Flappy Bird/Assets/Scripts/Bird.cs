using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bird : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }
    private const float JUMP_AMOUNT = 5f;
    private static Bird instance;
    public static Bird GetInstance()
    {
        return instance;
    }
    public event EventHandler OnDied;
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
        birdRigidBody2D.velocity = Vector2.up * JUMP_AMOUNT;
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        print("Test");
        birdRigidBody2D.bodyType = RigidbodyType2D.Static;
        if (OnDied != null) OnDied(this, EventArgs.Empty);
    }
    

}
