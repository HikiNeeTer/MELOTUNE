using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NoteSpawn : MonoBehaviour
{
    public GameObject note;
    float randX;
    public float spawnRate = 2f;
    Vector2 spawnplace;
    float nextSpawn = 0.0f;

    // Start is called before the first frame update
    void Start()
    {
        spawnplace = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        if(Time.time > nextSpawn) 
        {
            nextSpawn = Time.time + spawnRate;
            Instantiate(note, spawnplace, Quaternion.identity);
        }
    }
}
