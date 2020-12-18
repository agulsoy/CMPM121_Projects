using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AlertTracker : MonoBehaviour
{
    public Text alertOne;
    // Start is called before the first frame update
    void Start()
    {
        alertOne = GameObject.Find("ShiftedMazeNotice").GetComponent<Text>();
        alertOne.gameObject.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void AlertOne()
    {
        //Debug.Log("!!!!!ALERTONE!!!!!");
        //alertOne.gameObject.SetActive(true);
        /*float i = 0.0f;

        while (i < 10.0f)
        {
            i = i + (1.0f * Time.deltaTime);
        }
        alertOne.gameObject.SetActive(false);
        i = 0.0f;*/
    }
}
