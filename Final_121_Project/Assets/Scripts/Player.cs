using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    // public CameraTrigger trig;
    public float speed = 1.0f;
    public float rotateSpeed = 1.0f;
    public float gravity = 20.0f;
    //public Collider collider;
    public Inventory2 inventory;
    private Vector3 move = Vector3.zero;
    private Vector3 rotation;
        //Vector3 facing_direction = new Vector3(0.0f, 0.0f, 1.0f);
    // string save_path;
    // Start is called before the first frame update
    void Start()
    {
        // this.save_path = Application.persistentDataPath + "/save.json";

        // if(System.IO.File.Exists(save_path)){
        //     var serialized = System.IO.File.ReadAllText(this.save_path);
        //     var save_game = JsonUtility.FromJson<SaveGame>(serialized);
        //     this.GetComponent<Transform>().position = save_game.player_pos;

        // }
        
    }

    // Update is called once per frame
    void Update()
    {
        CharacterController character_controller = this.GetComponent<CharacterController>();

        

        this.rotation = new Vector3(0, Input.GetAxisRaw("Horizontal") * rotateSpeed * Time.deltaTime, 0);

        this.move = new Vector3(0, 0, Input.GetAxisRaw("Vertical") * Time.deltaTime);
        move = transform.TransformDirection(move);


            character_controller.Move(move * speed);
            this.transform.Rotate(this.rotation);
        
        /*CharacterController character_controller = this.GetComponent<CharacterController>();

        var transform = this.GetComponent<Transform>();

        transform.Rotate(0, Input.GetAxis("Horizontal") * rotateSpeed, 0);

        Vector3 forward = transform.TransformDirection(Vector3.forward);
        float currSpeed = speed * Input.GetAxis("Vertical");
        character_controller.SimpleMove(forward * currSpeed);

        var direction = new Vector3(

            Input.GetAxis("Horizontal"),
            0.0f,
            Input.GetAxis("Vertical")
            ).normalized;
           
            /*facing_direction = transform.TransformDirection(Vector3.Lerp(direction, this.facing_direction, 0.96f));
            var target = transform.position + facing_direction;
            transform.LookAt(target);*/
        	
    }

    private void OnControllerColliderHit(ControllerColliderHit hit)
    {
        IInventoryItem item = hit.collider.GetComponent<IInventoryItem>();
        if (item != null)
        {
            inventory.AddItem(item);
        }
    }

    // public void Save(){
    //     SaveGame save = new SaveGame();
    //     save.player_pos = this.GetComponent<Transform>().position;
    //     string serialized = JsonUtility.ToJson(save, true);

    //     using (var file = new System.IO.StreamWriter(save_path)){
    //         file.Write(serialized);    
    //     }
    //     Debug.Log("Autosave to " + save_path);
    // }
}