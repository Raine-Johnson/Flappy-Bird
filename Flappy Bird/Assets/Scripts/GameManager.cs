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
        gameOverScreen.gameObject.SetActive(false);
        mode = Mode.Start;
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        modeTime += 0.1f;
    }

    public void Restart()
    {
        mode = Mode.Start;
        modeTime = 0;
        //score.ResetScore();
        score = 0;
        gameOverScreen.gameObject.SetActive(false);
        pipeController.resetPipes();
        flappyBird.GetComponent<Bird>().resetBird();
        
    }

    public void GameOver()
    {
        mode = GameManager.Mode.Game;
        Physics2D.gravity = new Vector3(0f, -10f, 0f);
        modeTime = 0;

        gameOverScreen.gameObject.SetActive(true);
        if (score > highscore)
        {
            highscore = score;
        }
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
                break;

            case Mode.Game:
                break;

            case Mode.Menu:
                break;
        }
    }
}

