/************************
 * By: Adeline Braun
 * Last Edited: 1/30/2020
 * Description: Manages the global variables in the game
 ***********************/
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public GameObject flappyBird;
    int score;
    int highscore;
    enum Mode { Start, Game, Menu }
    //public Mode mode;

    // Start is called before the first frame update
    private void Start()
    {
        //mode = Start;

<<<<<<< HEAD
        
=======
        GameObject gameObject = new GameObject("Pipe", typeof(SpriteRenderer));
<<<<<<< HEAD
        gameObject.GetComponent<SpriteRenderer>().sprite = GameAssets.GetInstance().pipeSprite;
=======
        gameObject.GetComponent<SpriteRenderer>().sprite = GameAssets.GetInstance().pipeHeadSprite;
<<<<<<< HEAD
=======
>>>>>>> 6d675cef968596da639cdf1dc930703dff84e70d
        
>>>>>>> 2a31830ff39e6b320c18383d8d9daff81fe469b3
>>>>>>> 45a9ca703c84f228e2a61b221cf7e15a52e1fdb9

    }

    // Update is called once per frame
    void Update()
    {
       
    }

    void Death()
    {
        if(score > highscore)
        {
            highscore = score;
        }
        //mode = Menu;
    }

    public void Restart()
    {
        score = 0;
        //mode = Start;
    }
}

