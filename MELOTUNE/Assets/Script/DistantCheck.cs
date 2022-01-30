using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DistantCheck : MonoBehaviour
{
    
    public Transform distobutton;
    
    public float distance;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        distance = Mathf.Abs(distobutton.transform.position.x - transform.position.x);
        //Debug.Log(distance);
    }
}
