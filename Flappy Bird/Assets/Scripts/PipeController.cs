using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipeController : MonoBehaviour
{
    public GameObject pipe;
    private List<GameObject> Pipes = new List<GameObject>();
    private float time = 0.0f;
    public float timeToFirstPipe = 5.0f;
    public float timeBetweenPipes = 2.0f;
    private float currentTimeBetween = 0.0f;
    private const float PIPE_WIDTH = 7.8f;
    public float startXPosition = 10.0f;
    public float endXPosition = -10.0f;
    public GameManager gameManager;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (gameManager.mode == GameManager.Mode.Game) 
        {
            time += Time.deltaTime;
            currentTimeBetween += Time.deltaTime;

            if (time >= timeToFirstPipe && currentTimeBetween >= timeBetweenPipes)
            {
                CreatePipe();
            }
            for (int i = 0; i < Pipes.Count; i++)
            {
                Pipes[i].transform.position -= new Vector3(0.01f, 0, 0);
                if (Pipes[i].transform.position.x <= endXPosition)
                {
                    Destroy(Pipes[i]);
                    Pipes.Remove(Pipes[i]);
                }
            }
        }
    }

    private void CreatePipe()
    {
        GameObject newPipe = Instantiate(pipe, new Vector3(startXPosition, Random.Range(-2,2), 0), Quaternion.identity);
        Pipes.Add(newPipe);
        currentTimeBetween = 0.0f;
    }

    public void resetPipes()
    {
        int i = 0;
        while(i < Pipes.Count)
        {
            Destroy(Pipes[i]);
            Pipes.Remove(Pipes[i]);
        }
        
    }
}
