using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Player : MonoBehaviour
{
	public float speed = 1.0f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
    	// var transform = this.GetComponent<Transform>();
    	// var position = transform.position;
    	// position.x += this.speed * Input.GetAxis("Horizontal") * Time.deltaTime;
    	// position.z += this.speed * Input.GetAxis("Vertical") * Time.deltaTime;
    	// transform.position = position

    	var characterController = this.GetComponent<CharacterController>();
    	characterController.SimpleMove(new Vector3(
    		this.speed * Input.GetAxis("Horizontal"),
    		0.0f,
    		this.speed * Input.GetAxis("Vertical")
    	));
    }
}
