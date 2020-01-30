using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipeController : MonoBehaviour
{
    private List<Pipe> Pipes;
    private float time = 0.0f;
    public float interpolationPeriod = 0.1f;
    private const float PIPE_WIDTH = 7.8f;
    // Start is called before the first frame update
    void Start()
    {
        CreatePipe(0f, 0f);
        CreatePipe(0f, 20f);
    }

    // Update is called once per frame
    void Update()
    {
        time += Time.deltaTime;

        if (time >= interpolationPeriod)
        {
            time = 0.0f;

            Instantiate(Pipe, new Vector3(7, 0, 0), Quaternion.identity);
            
        }
    }

    private void randomizePosition(Pipe topPipe, Pipe bottomPipe)
    {
        pipe.topPosition.transform.position.y = new Random() * 10 + 7;
        pipe.bottomPosition.transform.position.y = topPosition - 12;
    }

    private void CreatePipe(float height, float xPosition)
    {
        Transform pipeHead = Instantiate(GameAssets.GetInstance().pfPipeHead);
        pipeHead.position = new Vector3(xPosition, 0f);

        Transform pipeBody = Instantiate(GameAssets.GetInstance().pfPipeBody);
        pipeBody.position = new Vector3(xPosition, 0f);
        SpriteRenderer pipeBodySpriteRenderer = pipeBody.GetComponent<pipeBodySpriteRenderer>();
        pipeBodySpriteRenderer.size = new Vector2(PIPE_WIDTH, height);
    }
}
