using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
class SaveGame {
    public Vector3 player_pos;
}

public class CameraTrigger : MonoBehaviour
{
	public Player player;
	public float speed = 1.0f;
	public string room_name = "Default";
	public Camera room_camera;
	public Camera main_camera;

    
    // Start is called before the first frame update
    void Start()
    {
    
    }

    // Update is called once per frame
    void Update()
    {
        
    }   

    public void OnTriggerEnter(Collider collider){
        var player = collider.GetComponent<Player>();
    	if(collider.GetComponent<Player>() != null){
    		this.main_camera.enabled = false;
    		this.room_camera.enabled = true;
            player.Save();
    	

    	// var character_controller = this.GetComponent<CharacterController>();
     //    var direction = new Vector3(

     //        Input.GetAxis("Horizontal"),
     //        0.0f,
     //        Input.GetAxis("Vertical")
     //        );
     //        var delta = direction * this.speed;
     //        character_controller.SimpleMove(delta);
        }
    }

    public void OnTriggerExit(Collider collider){
    	if(collider.GetComponent<Player>() != null){
    		this.main_camera.enabled = true;
    		this.room_camera.enabled = false;
    	}
    }
}
