using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bob : MonoBehaviour
{
    public GameManager gameManager;
    public float bobStrength = -10;
    // Start is called before the first frame update
    void Start()
    {
         
    }

    // Update is called once per frame
    void Update()
    {
        if (gameManager.mode == GameManager.Mode.Start)
        {
            float offset = Mathf.Sin(gameManager.modeTime)/2;
            Bird.GetInstance().transform.position = new Vector3(-2, offset, 0);
        }
    }

    public void startBob()
    {
        print("Bobbing");
        Physics2D.gravity = new Vector3(0f, 0f, 0f);
        bobStrength = -bobStrength;
        
    }
}
