using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bob : MonoBehaviour
{
    public GameManager gameManager;
    float timeLeft;
    public float totalTime = 2;
    public float bobStrength = -10;
    // Start is called before the first frame update
    void Start()
    {
        timeLeft = Mathf.Sqrt(totalTime); 
    }

    // Update is called once per frame
    void Update()
    {
        if (gameManager.mode == GameManager.Mode.Start)
        {
            timeLeft -= Time.deltaTime;
            if (timeLeft < 0)
            {
                startBob();
                timeLeft = totalTime;
            }
       }
    }

    public void startBob()
    {
        print("Bobbing");
        Physics2D.gravity = new Vector3(0f, bobStrength, 0f);
        bobStrength = -bobStrength;
        
    }
}
