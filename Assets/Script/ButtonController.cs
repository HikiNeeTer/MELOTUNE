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
        ButtonControl();

        //Switching lane mechanic
        if (Input.GetKeyDown(KeyCode.Space)) 
        {
            gameObject.SetActive(false);
            antButton.SetActive(true);
        }

    }

    void ButtonControl()
    {
        // If Press W/A/S/D color changed
        if (Input.GetKeyDown(KeyCode.W))
        {
            GetComponent<SpriteRenderer>().color = Color.grey;
        }
        if (Input.GetKeyUp(KeyCode.W))
        {
            GetComponent<SpriteRenderer>().color = Color.white;
        }

        // If Press W/A/S/D color changed
        if (Input.GetKeyDown(KeyCode.A))
        {
            GetComponent<SpriteRenderer>().color = Color.grey;
        }
        if (Input.GetKeyUp(KeyCode.A))
        {
            GetComponent<SpriteRenderer>().color = Color.white;
        }

        // If Press W/A/S/D color changed
        if (Input.GetKeyDown(KeyCode.D))
        {
            GetComponent<SpriteRenderer>().color = Color.grey;
        }
        if (Input.GetKeyUp(KeyCode.D))
        {
            GetComponent<SpriteRenderer>().color = Color.white;
        }

        // If Press W/A/S/D color changed
        if (Input.GetKeyDown(KeyCode.S))
        {
            GetComponent<SpriteRenderer>().color = Color.grey;
        }
        if (Input.GetKeyUp(KeyCode.S))
        {
            GetComponent<SpriteRenderer>().color = Color.white;
        }
    }
}
