using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NoteSpawn : MonoBehaviour
{
    public GameObject note;
    public float spawnRate = 2f;

    private bool ready = false;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (!ready)
        {
            if (Input.GetKeyDown(KeyCode.Space))
            {
                ready = true;
                GetComponent<AudioSource>().Play();
            }
        }
        else
        {
        }
    }
}
