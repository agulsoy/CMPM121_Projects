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
    public Image img2;
    public Image img4;

    // Start is called before the first frame update
    void Start()
    {
        //Find the game objects and get the image component
        img1 = GameObject.Find("FirstUI").GetComponent<Image>();
        img2 = GameObject.Find("YouUI").GetComponent<Image>();
        img4 = GameObject.Find("ToUI").GetComponent<Image>();

        //default to stage 1 being rendered
        img1.enabled = false;
        img2.enabled = false;
        img4.enabled = false;
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

    void P_up1()
    {
        img1.enabled = true;
    }

    void P_up2()
    {
        img2.enabled = true;
    }

    void P_up4()
    {
        img4.enabled = true;
    }
}
