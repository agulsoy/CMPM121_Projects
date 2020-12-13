using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class First_Inv_Col : MonoBehaviour
{
    private GameObject word;

    // Start is called before the first frame update
    void Start()
    {
        word = GameObject.Find("Find");
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter(Collider collider)
    {
        if (collider.gameObject.CompareTag("Player"))
        {

            word.SendMessage("P_up1");
        }
    }
}
