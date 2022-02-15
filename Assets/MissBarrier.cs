using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MissBarrier : MonoBehaviour
{
    public bool NoteMiss = false;
    public SkillEasy ES;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Note")) 
        {
            NoteMiss = true;
            if (ES.isskill == false) 
            {
                Debug.Log("Miss (Pressing late)");
                ButtonCheck.Combo = 0;
            }               
            Destroy(collision.gameObject);           
        }
    }
}
