using System.Collections;
using System.Collections.Generic;
using UnityEditor.Experimental.GraphView;
using UnityEngine;

public class BirdSpawner : MonoBehaviour
{
    public GameObject DuckPrefab;

    public int Direction = -1;
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("Spawn", 0, 3);
    }

    void Spawn()
    {
        GameObject duckInstance = GameObject.Instantiate(DuckPrefab);
        duckInstance.transform.position = this.transform.position;
        duckInstance.GetComponent<Birdfly>().Speed = 2f * Direction;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
