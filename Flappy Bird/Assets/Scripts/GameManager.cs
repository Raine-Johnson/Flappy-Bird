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
    public Mode mode;

    // Start is called before the first frame update
    private void Start()
    {
<<<<<<< HEAD
        mode = Start;
=======
        GameObject gameObject = new GameObject("Pipe", typeof(SpriteRenderer));
        gameObject.GetComponent<SpriteRenderer>().sprite = GameAssets.GetInstance().pipeHeadSprite;
        
>>>>>>> c5cfa2ba82ceec2efaa290c6563ac1da5273bde9
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
        mode = Menu;
    }

    public void Restart()
    {
        score = 0;
        mode = Start;
    }
}

