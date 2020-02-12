using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipeController : MonoBehaviour
{
    public GameObject pipe;
    public GameObject floor;
    private List<GameObject> Pipes = new List<GameObject>();
    private List<GameObject> Floors = new List<GameObject>();
    public GameObject startingFloor;
    private float time = 0.0f;
    public float timeToFirstPipe = 5.0f;
    public float timeToFirstFloor = 1.0f;
    public float timeBetweenPipes = 2.0f;
    public float timeBetweenFloors = 3.0f;
    private float currentTimeBetween = 0.0f;
    private float currentTimeBetweenFloors = 0.0f;
    private const float PIPE_WIDTH = 7.8f;
    public float startXPosition = 10.0f;
    public float endXPosition = -10.0f;
    public float PipeSpeed = 0.2f;
    public GameManager gameManager;
    // Start is called before the first frame update
    void Start()
    {
   
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        time += Time.fixedDeltaTime;
        if (gameManager.mode == GameManager.Mode.Game) 
        {
            
            currentTimeBetween += Time.deltaTime;
           

            if (time >= timeToFirstPipe && currentTimeBetween >= timeBetweenPipes)
            {
                CreatePipe();
            }
            
            //print("Pipes: " + Pipes.Count.ToString());
            for (int i = 0; i < Pipes.Count; i++)
            {
                
                Pipes[i].transform.position -= new Vector3(PipeSpeed, 0, 0);
                if (Pipes[i].transform.position.x <= endXPosition)
                {
                    Destroy(Pipes[i]);
                    Pipes.Remove(Pipes[i]);
                }
            }
            
        }
        for (int i = 0; i < Floors.Count; i++)
        {
            Floors[i].transform.position -= new Vector3(PipeSpeed, 0, 0);
            if (Floors[i].transform.position.x <= endXPosition)
            {
                Destroy(Floors[i]);
                Floors.Remove(Floors[i]);
            }
        }
        if (time >= timeToFirstFloor && currentTimeBetweenFloors >= timeBetweenFloors)
        {
            CreateFloor();
        }
        if (startingFloor != null)
        {
            startingFloor.transform.position -= new Vector3(PipeSpeed, 0, 0);
            if (startingFloor.transform.position.x <= -10)
            {
                Destroy(startingFloor);
            }
        }
        currentTimeBetweenFloors += Time.deltaTime;
        
    }

    private void CreatePipe()
    {
        GameObject newPipe = Instantiate(pipe, new Vector3(startXPosition, Random.Range(-1f,2f), 0), Quaternion.identity);
        Pipes.Add(newPipe);
        currentTimeBetween = 0.0f;
    }

    private void CreateFloor()
    {
        GameObject newPipe = Instantiate(floor, new Vector3(startXPosition, -4.5f, 0), Quaternion.identity);
        Floors.Add(newPipe);
        currentTimeBetweenFloors = 0.0f;
    }

    public void resetPipes()
    {
        int i = 0;
        while(i < Pipes.Count)
        {
            Destroy(Pipes[i]);
            Pipes.Remove(Pipes[i]);
        }
        i = 0;
        while(i < Pipes.Count)
        {
            Destroy(Pipes[i]);
            Pipes.Remove(Pipes[i]);
        }
    }
}
