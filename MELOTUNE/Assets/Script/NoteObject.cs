using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NoteObject : MonoBehaviour
{
    public bool canPressed;
    public KeyCode keyToPress;
    GameObject buttonReference;
    public DistantCheck dc;
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
            // If User Hit Note then Destroy Object
            if (Input.GetKeyDown(keyToPress) && buttonReference.GetComponent<ButtonCheck>().isCurrentNote() == this.gameObject)
            {
                Debug.Log(dc.distance);
                if (dc.distance <= 0.5) 
                {
                    Debug.Log("perfect");
                }
                else if(dc.distance <= 1)
                {
                    Debug.Log("Great");
                }
                else if (dc.distance <= 2)
                {
                    Debug.Log("Good");
                }                
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
