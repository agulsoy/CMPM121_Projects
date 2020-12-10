using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RoomRotate : MonoBehaviour
{
	public Transform player;
	public float RotateSpeed;

	private Quaternion lookRotate;
	private Vector3 direction;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
       	direction = (player.position - transform.position);
    	lookRotate = Quaternion.LookRotation(direction);
    	transform.rotation = Quaternion.Slerp(transform.rotation, lookRotate, Time.deltaTime *RotateSpeed);
    }
}
