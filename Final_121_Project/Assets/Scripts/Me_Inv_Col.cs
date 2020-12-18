﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Me_Inv_Col : MonoBehaviour
{
    private GameObject word;
    private GameObject door;

    // Start is called before the first frame update
    void Start()
    {
        door = GameObject.Find("MeDoor");
        word = GameObject.Find("MeUI");
    }

    // Update is called once per frame
    void Update()
    {

    }

    void OnTriggerEnter(Collider collider)
    {
        if (collider.gameObject.CompareTag("Player"))
        {

            word.SendMessage("P_up6");
            door.SendMessage("OpenOne");
        }
    }
}
