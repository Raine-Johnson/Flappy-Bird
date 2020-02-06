using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bob : MonoBehaviour
{
    public GameManager gameManager;
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
            gameManager.flappyBird.transform.position = new Vector3(-2, offset, 0);
        }
    }  
}
