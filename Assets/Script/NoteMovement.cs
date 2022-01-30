using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NoteMovement : MonoBehaviour
{
    public float beatTempo;
    [HideInInspector] public bool hasStart;

    void Start()
    {
        beatTempo /= 60.0f;
    }

    void Update()
    {
        // If game start -> Note start move and song start play
        if (!hasStart)
        {
            if (Input.GetKeyDown(KeyCode.Space))
            {
                hasStart = true;
            }
        }
        else
        {
            transform.position -= new Vector3(beatTempo * Time.deltaTime, 0.0f, 0.0f);
        }
    }
}
