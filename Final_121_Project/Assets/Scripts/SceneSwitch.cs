using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneSwitch : MonoBehaviour
{
    public static int activate;

    void OnTriggerEnter(Collider collider)
    {
        if (activate.Equals(1))
        {
            SceneManager.LoadScene(3);
        }
        else
        {
            SceneManager.LoadScene(2);
        }
    }

    void Update()
    {
        activate = ImgControl.activated;
        Debug.Log("activate's value " + activate);
    }
}
