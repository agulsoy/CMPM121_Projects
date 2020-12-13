using System.Collections;
//using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ImgControl : MonoBehaviour
{
    //substitute this with the variable for the stage when it is implemented
    public float stage = 1.0f;
    //the stage indicator image
    public Image img1;

    // Start is called before the first frame update
    void Start()
    {
        //Find the game objects and get the image component
        img1 = GameObject.Find("Find").GetComponent<Image>();

        //default to stage 1 being rendered
        img1.enabled = false;
    }

    // Update is called once per frame
    /*
    void Update()
    {
        //if we are at the first stage enable the image, else disable it 
        if (stage == 1.0f)
        {
            img1.enabled = true;
        }
        else
        {
            img1.enabled = false;
        }
    }
    */

    void P_up()
    {
        img1.enabled = true;
    }
}
