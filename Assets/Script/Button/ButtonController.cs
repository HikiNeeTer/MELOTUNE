using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonController : MonoBehaviour
{
    public GameObject antButton;
    public NoteMovement noteMovement;

    void Start()
    {
        
    }

    void Update()
    {
        ButtonControl();

        //Switching Lane mechanic when Game Start
        if (Input.GetKeyDown(KeyCode.Space)) 
        {
            transform.position = new Vector2(transform.position.x, (transform.position.y <= -2.4 ? -0.5f:-2.5f)); 
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
