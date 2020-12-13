using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class You_Inv_Col : MonoBehaviour
{
    private GameObject word2;

    // Start is called before the first frame update
    void Start()
    {
        word2 = GameObject.Find("YouUI");
    }

    // Update is called once per frame
    void Update()
    {

    }

    void OnTriggerEnter(Collider collider)
    {
        if (collider.gameObject.CompareTag("Player"))
        {
            Debug.Log("collide");
            word2.SendMessage("P_up2");
        }
    }
}
