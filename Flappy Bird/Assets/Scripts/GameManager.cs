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
    public enum Mode { Start, Game, Menu }
    public Mode mode;
    public GameObject gameOverScreen;
    public PipeController pipeController;

    public float modeTime = 0;



    // Start is called before the first frame update
    private void Start()
    {
        setMode(Mode.Start);
        gameOverScreen.GetComponent<Canvas>().enabled = false;
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        modeTime += 0.1f;
    } 

    public void setMode(Mode newMode)
    {
        if(mode == newMode)
        {
            return;
        }
        mode = newMode;
        modeTime = 0;
        switch (mode)
        {
            case Mode.Start:
                score = 0;
                gameOverScreen.GetComponent<Canvas>().enabled = false;
                pipeController.resetPipes();
                flappyBird.GetComponent<Bird>().resetBird();
                break;

            case Mode.Game:
                break;

            case Mode.Menu:
                gameOverScreen.GetComponent<Canvas>().enabled = true;
                if (score > highscore)
                {
                    highscore = score;
                }
                break;
        }
    }
}

