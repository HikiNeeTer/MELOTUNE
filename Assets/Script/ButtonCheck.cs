using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ButtonCheck : MonoBehaviour
{
    private Queue<NoteObject> NoteList;
    private NoteObject noteObj;

    // For Setting KeyCode on Button
    public KeyCode Up = KeyCode.W;
    public KeyCode Down = KeyCode.S;
    public KeyCode Left = KeyCode.A;
    public KeyCode Right = KeyCode.D;

    public static int Score = 0;
    public static int Combo = 0;
    public static float Skill = 0.0f;

    public Text comboText;
    public Text scoreText;
    public Text skillText;

    void Start()
    {
        // Initialize List
        NoteList = new Queue<NoteObject>();
        // For Debugging (!!Create circle for distance detection!!)
        //DrawCircle(0.5f, 0.05f);
        //DrawCircle(1.0f, 0.05f);
        //DrawCircle(2.0f, 0.05f);

        //Setting Text Combo & Score to 0
        comboText.text = "Combo : " + Combo.ToString();
        scoreText.text = "Score : " + Score.ToString();
        skillText.text = "Skill : " + Skill.ToString("F2");
    }

    void Update()
    {
        noteObj = currentNote();
        // If currentNote is null then return
        if (currentNote() == null)
        {
            return;
        }

        if (Input.GetKeyDown(Up) || Input.GetKeyDown(Down) ||
            Input.GetKeyDown(Left) || Input.GetKeyDown(Right))
        {
            // If User Hit Note then Destroy Object
            if (Input.GetKeyDown(noteObj.keyToPress))
            {
                DistantCheck dc = noteObj.GetComponent<DistantCheck>();
                //Debug.Log(dc.distance);
                if (dc.distance <= 0.5)
                {
                    Debug.Log("Perfect");
                    Skill += 0.1f;
                    Combo += 1;
                    Score += 1000;
                }
                else if (dc.distance <= 1)
                {
                    Debug.Log("Great");
                    Skill += 0.075f;
                    Combo += 1;
                    Score += 500;
                }
                else if (dc.distance <= 2)
                {
                    Debug.Log("Good");
                    Skill += 0.05f;
                    Combo = 0;
                    Score += 300;
                }
            }
            else
            {
                Debug.Log("Miss(Wrong Press)");
                Combo = 0;
            }
            deleteNote(noteObj);
            Destroy(noteObj.gameObject);
        }
        Skill = (Skill >= 1.0f ? 1.0f : Skill);
        comboText.text = "Combo : " + Combo.ToString();
        scoreText.text = "Score : " + Score.ToString();
        skillText.text = "Skill : " + Skill.ToString("F2");
    }

    // Add note to NoteList
    public void addNote(NoteObject note)
    {
        NoteList.Enqueue(note);
    }

    // Delete note that are on the front
    public void deleteNote(NoteObject noteObj)
    {
        // If NoteList is empty -> return
        if (NoteList.Count == 0)
        {
            return;
        }

        // If Peek of NoteList is noteObj then delete from List
        if (NoteList.Peek() == noteObj)
        {
            NoteList.Dequeue();
        }
    }

    // For checking what note is on the front
    public NoteObject currentNote()
    {
        // If NoteList is empty -> return null
        if (NoteList.Count == 0)
        {
            return null;
        }

        return NoteList.Peek();
    }
    
    // Function for create circle (!!For distance detection!!)
    private void DrawCircle(float radius, float lineWidth)
    {
        GameObject obj = new GameObject("Circle with radius : " + radius);
        obj.GetComponent<Transform>().position = new Vector3(transform.position.x, transform.position.y, -1.0f);

        int segments = 360;
        LineRenderer line = obj.AddComponent<LineRenderer>();

        line.useWorldSpace = false;
        line.startWidth = lineWidth;
        line.endWidth = lineWidth;
        line.positionCount = segments + 1;

        int pointCounts = segments + 1;
        Vector3[] points = new Vector3[pointCounts];

        for (int i = 0; i < pointCounts; i++)
        {
            float rad = Mathf.Deg2Rad * (i * 360.0f / segments);
            points[i] = new Vector3(Mathf.Cos(rad) * radius, Mathf.Sin(rad) * radius, 0.0f);
        }
        line.SetPositions(points);
    }
}