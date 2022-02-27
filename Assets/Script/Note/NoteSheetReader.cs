using System.IO;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class NoteComponent
{
    public KeyCode type;
    public int row;
    public Vector2 pos;
}

[System.Serializable]
public class NoteSheet
{
    public string name;
    public float BPM;
    public List<NoteComponent> allNote = new List<NoteComponent>();
}


public class NoteSheetReader : MonoBehaviour
{
    [Header("Note Type")]
    public GameObject noteUp;
    public GameObject noteDown;
    public GameObject noteLeft;
    public GameObject noteRight;

    [Header("System Input/Output")]
    public string fileName;
    public NoteSheet loadNoteSheet;

    private void Start()
    {
        string loadString = File.ReadAllText(Application.dataPath + "/Load/" + fileName + ".json");
        Debug.Log(loadString);
        if (loadString != null)
        {
            loadNoteSheet = JsonUtility.FromJson<NoteSheet>(loadString);
            Debug.Log(loadNoteSheet.name);
        }
        CreateNote(loadNoteSheet.allNote);
            
    }

    private void Update()
    {
        
    }

    private void CreateNote(List<NoteComponent> allNote)
    {
        allNote.Sort(SortByPosX);
        int sLayer = 0;
        foreach (NoteComponent note in allNote)
        {
            GameObject obj = null;
            if (note.type == KeyCode.W)
            {
                obj = Instantiate(noteUp, new Vector3(note.pos.x, note.row == 1 ? -2.5f : -0.5f, -8.0f), Quaternion.identity);
            }
            else if (note.type == KeyCode.S)
            {
                obj = Instantiate(noteDown, new Vector3(note.pos.x, note.row == 1 ? -2.5f : -0.5f, -8.0f), Quaternion.identity);
            }
            else if (note.type == KeyCode.A)
            {
                obj = Instantiate(noteLeft, new Vector3(note.pos.x, note.row == 1 ? -2.5f : -0.5f, -8.0f), Quaternion.identity);
            }
            else if (note.type == KeyCode.D)
            {
                obj = Instantiate(noteRight, new Vector3(note.pos.x, note.row == 1 ? -2.5f : -0.5f, -8.0f), Quaternion.identity);
            }
            obj.GetComponent<SpriteRenderer>().sortingOrder = allNote.Count - sLayer;
            obj.transform.SetParent(transform);
            sLayer++;
        }
    }

    int SortByPosX(NoteComponent a, NoteComponent b)
    {
        return a.pos.x.CompareTo(b.pos.x);
    }
}
