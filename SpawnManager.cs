using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{

    public GameObject pipes;
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SpawnPipe", 2, 2);
    }

    void SpawnPipe()
    {
        Instantiate(pipes, new Vector3(pipes.transform.position.x, pipes.transform.position.y + Random.Range(2, 2), pipes.transform.position.z), Quaternion.identity);

    }
}
