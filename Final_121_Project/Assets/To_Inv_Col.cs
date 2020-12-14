using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class To_Inv_Col : MonoBehaviour
{
    private GameObject word4;

    // Start is called before the first frame update
    void Start()
    {
        word4 = GameObject.Find("ToUI");
    }

    // Update is called once per frame
    void Update()
    {

    }

    void OnTriggerEnter(Collider collider)
    {
        if (collider.gameObject.CompareTag("Player"))
        {
            //Debug.Log("collide");
            word4.SendMessage("P_up4");
        }
    }
}
