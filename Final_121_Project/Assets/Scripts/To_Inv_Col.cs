using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class To_Inv_Col : MonoBehaviour
{
    private GameObject word;
    private GameObject door;
    private GameObject notice;

    // Start is called before the first frame update
    void Start()
    {
        door = GameObject.Find("ToDoor");
        word = GameObject.Find("ToUI");
        notice = GameObject.Find("ShiftedMazeNotice");
    }

    // Update is called once per frame
    void Update()
    {

    }

    void OnTriggerEnter(Collider collider)
    {
        if (collider.gameObject.CompareTag("Player"))
        {
            word.SendMessage("P_up4");
            door.SendMessage("OpenTwo");
            notice.SendMessage("AlertOne");
        }
    }
}
