using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DistantCheck : MonoBehaviour
{
    
    public Transform distobutton;
    
<<<<<<< Updated upstream
    public float distance;
=======
    private float distance;
>>>>>>> Stashed changes
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
<<<<<<< Updated upstream
        distance = Mathf.Abs(distobutton.transform.position.x - transform.position.x);
        //Debug.Log(distance);
=======
        distance = (distobutton.transform.position.x - transform.position.x);
        Debug.Log(distance);
>>>>>>> Stashed changes
    }
}
