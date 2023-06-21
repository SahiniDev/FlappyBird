using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipeSpawner : MonoBehaviour
{
    public float spawnRate = 0.7f;
    private float timeCounter = 0;
    public GameObject pipeToSpawn;
    public float spawnVariance = 0.5f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(timeCounter > spawnRate)
        {
            GameObject pipe = Instantiate(pipeToSpawn);
            pipe.transform.position = transform.position + new Vector3(0, Random.Range(-spawnVariance, spawnVariance), 0);
            Destroy(pipe, 15);

            timeCounter = 0;
        }

        timeCounter += Time.deltaTime; 
    }
}
