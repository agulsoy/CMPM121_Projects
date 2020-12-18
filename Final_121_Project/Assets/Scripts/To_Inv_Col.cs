using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class To_Inv_Col : MonoBehaviour
{
    private GameObject word4;
    private GameObject door;

    // Start is called before the first frame update
    void Start()
    {
        door = GameObject.Find("ToDoor");
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
            word4.SendMessage("P_up4");
            door.SendMessage("OpenTwo");
        }
    }
}
