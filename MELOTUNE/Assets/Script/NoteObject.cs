using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NoteObject : MonoBehaviour
{
    public bool canPressed;
    public KeyCode keyToPress;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (canPressed)
        {
            // If User Hit Note then Destroy Object
            if (Input.GetKeyDown(keyToPress))
            {
                Destroy(gameObject);
            }
        }
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        // If trigger then note can Press
        if (collision.CompareTag("Button"))
        {
            canPressed = true;
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        // If trigger(exit) then note cannot Press
        if (collision.CompareTag("Button"))
        {
            canPressed = false;
        }
    }
}
