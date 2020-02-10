using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreAdding : MonoBehaviour
{
    public AudioSource scoreAudio;
    // Start is called before the first frame update
    void Start()
    {
        
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        Score.score++;
        scoreAudio.Play();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
