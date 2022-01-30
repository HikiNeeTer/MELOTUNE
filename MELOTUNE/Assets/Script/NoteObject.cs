using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NoteObject : MonoBehaviour
{
    public bool canPressed;
    public KeyCode keyToPress;
    GameObject buttonReference;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // If User Hit Note then Destroy Object
        if (canPressed)
        {
            // Check if user is press key or not? / Checking that this note is the front note or not?
            if (Input.GetKeyDown(keyToPress) && buttonReference.GetComponent<ButtonCheck>().isCurrentNote() == this.gameObject)
            {
                // Delete this note from NoteList
                buttonReference.GetComponent<ButtonCheck>().deleteNote();
                Destroy(gameObject);
            }
        }
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        // If trigger then note can Press
        if (collision.CompareTag("Button"))
        {
            // When note trigger with button get buttonReference
            buttonReference = collision.gameObject;
            // Add current note to NoteList which are in buttonReference
            buttonReference.GetComponent<ButtonCheck>().addNote(this.gameObject);
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
