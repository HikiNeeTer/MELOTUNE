using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GradeDisplay : MonoBehaviour
{
    [SerializeField] private Text grade1Text;
    [SerializeField] private Text accuracy1Text;
    [SerializeField] private Text grade2Text;
    [SerializeField] private Text accuracy2Text;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        grade1Text.text = "Grade: " + PlayerPrefs.GetString("Grade1");
        accuracy1Text.text = "Accuracy: " + PlayerPrefs.GetFloat("Accuracy1").ToString("F2") + "%"; ;

        grade2Text.text ="Grade: " + PlayerPrefs.GetString("Grade2");
        accuracy2Text.text = "Accuracy: " +  PlayerPrefs.GetFloat("Accuracy2").ToString("F2") + "%"; ;
    }
}
