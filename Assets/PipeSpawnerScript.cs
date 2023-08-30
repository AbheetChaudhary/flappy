using System.Collections;
using System.Collections.Generic;
using System.Timers;
using UnityEngine;
public class PipeSpawnerScript : MonoBehaviour
{
    public GameObject Pipe;
    public float spawnRate = 2;
    private float _timer = 0;
    private float heightOffset = 7;
    
    // Start is called before the first frame update
    void Start()
    {
        SpawnPipe();
    }

    // Update is called once per frame
    void Update()
    {
        if (_timer < spawnRate)
        {
            _timer += Time.deltaTime;
        }
        else
        {
            _timer = 0;
            SpawnPipe();
        }
    }

    void SpawnPipe()
    {
        float maxHeight = transform.position.y + heightOffset;
        float minHeight = transform.position.y - heightOffset;
        
        Instantiate(Pipe, new Vector3(transform.position.x, Random.Range(minHeight, maxHeight), transform.position.z), transform.rotation);
    }
}
