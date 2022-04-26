using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class RGB_Cycle : MonoBehaviour
{
    [SerializeField] float seconds;
    float timer = 0.0f;
    bool blueToGreen = true;
    bool greenToRed = false;
    bool redToBlue = false;

    // Update is called once per frame
    void Update()
    {

        timer += Time.deltaTime / seconds;

        if (blueToGreen == true && greenToRed == false && redToBlue == false)
        {
            if (this.GetComponent<Image>() != null)
            {
                this.GetComponent<Image>().color = Color.Lerp(Color.blue, Color.green, timer);
            }
            if (this.GetComponent<Text>() != null)
            {
                this.GetComponent<Text>().color = Color.Lerp(Color.blue, Color.green, timer);
            }
            if (timer >= 1.0f)
            {
                timer = 0.0f;
                blueToGreen = false;
                greenToRed = true;
            }
        }

        if (greenToRed == true && blueToGreen == false && redToBlue == false)
        {
            if (this.GetComponent<Image>() != null)
            {
                this.GetComponent<Image>().color = Color.Lerp(Color.green, Color.red, timer);
            }
            if (this.GetComponent<Text>() != null)
            {
                this.GetComponent<Text>().color = Color.Lerp(Color.green, Color.red, timer);
            }
            if (timer >= 1.0f)
            {
                timer = 0.0f;
                greenToRed = false;
                redToBlue = true;
            }
        }

        if (redToBlue == true && greenToRed == false && blueToGreen == false)
        {
            if (this.GetComponent<Image>() != null)
            {
                this.GetComponent<Image>().color = Color.Lerp(Color.red, Color.blue, timer);
            }
            if (this.GetComponent<Text>() != null)
            {
                this.GetComponent<Text>().color = Color.Lerp(Color.red, Color.blue, timer);
            }
            if (timer >= 1.0f)
            {
                timer = 0.0f;
                redToBlue = false;
                blueToGreen = true;
            }
        }
    }
}
