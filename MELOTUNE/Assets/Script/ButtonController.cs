using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonController : MonoBehaviour
{
    public GameObject antButton;

    void Start()
    {
        
    }

    void Update()
    {
        // If Press W color changed
        if (Input.GetKeyDown(KeyCode.W))
        {
            GetComponent<SpriteRenderer>().color = Color.grey;
        }
        if (Input.GetKeyUp(KeyCode.W))
        {
            GetComponent<SpriteRenderer>().color = Color.white;
        }

        //Switching lane mechanic
        if (Input.GetKeyDown(KeyCode.Space)) 
        {
            gameObject.SetActive(false);
            antButton.SetActive(true);
        }
    }
}
