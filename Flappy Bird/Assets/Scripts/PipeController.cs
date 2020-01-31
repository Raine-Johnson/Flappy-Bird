using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*public class PipeController : MonoBehaviour
{
    public GameObject pipe;
    private List<GameObject> Pipes;
    private float time = 0.0f;
    public float timeToFirstPipe = 5.0f;
    public float timeBetweenPipes = 2.0f;
    private const float PIPE_WIDTH = 7.8f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        time += Time.deltaTime;

        if (time >= timeToFirstPipe && (time-timeToFirstPipe)%timeBetweenPipes == 0)
        {
            CreatePipe();
        }
        for(int i = 0; i < Pipes.Count; i++)
        {
            Pipes[i].transform.position -= new Vector3(0.01f, 0, 0);
            if(Pipes[i].transform.position.x <= -8)
            {
                Destroy(Pipes[i]);
            }
        }
    }

    private void CreatePipe()
    {
        GameObject newPipe = Instantiate(pipe, new Vector3(0, Random.Range(0,10), 0), Quaternion.identity);
        Pipes.Add(newPipe);
    }
}
*/