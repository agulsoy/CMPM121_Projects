using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MyNewCubeComponent : MonoBehaviour
{
	[Header("SPEED")]
	[Range(0.0f, 1.0f)]
	public float speed = 10f;

	public float scale;

	public Button button;

	int score_number = 0;

	public Text score;

	public float color_direction = -1.0f;

	public Slider slider;

	Transform transform;
    // Start is called before the first frame update
    void Start()
    {
        this.transform = this.GetComponent<Transform>();

        this.button.onClick.AddListener(this.GoFaster);

        this.scale = transform.localScale.x / 2;
    }

    public void GoFaster(){
    	this.speed += 3.071376f;
    }

    public void SetSpeed(float new_speed){
    	this.speed = new_speed;
    }

    // Update is called once per frame
    void Update()
    {
    	this.score_number += 1;
    	this.score.text = "<b>SCORE: </b>" + this.score_number.ToString();

    	//position
    	transform.position = new Vector3 (Mathf.PingPong (Time.time * 3, 5), transform.position.y, transform.position.x);
        // var new_position = this.transform.position;
        // new_position.x = this.speed;

        // if(new_position.x <= 0.0f){
        // 	new_position.x = 10.0f;	
        // }else if(new_position.x >= 10.0){
        // 	new_position.x = -10.0f;
        // }
        
        // this.transform.position = new_position;

    	//scale
    	transform.localScale = new Vector3 (Mathf.PingPong (Time.time * 3, 4), transform.localScale.y, transform.localScale.z);
        // var new_scale = this.transform.localScale;
        // new_scale.x += this.speed;
        // this.transform.localScale = new_scale;

    	//rotation
        var new_rotation = this.transform.localRotation;
        new_rotation = Quaternion.Euler(speed * Time.deltaTime, 1.0f, 1.0f) * new_rotation;
        this.transform.localRotation = new_rotation;

        var mesh_renderer = this.GetComponent<MeshRenderer>();
        var material = mesh_renderer.materials[0];
        var color = material.color;

        color.r += 0.001f * this.color_direction;
        color.g += 0.001f * this.color_direction;
        color.b += 0.001f * this.color_direction;

        if(color.r <= 0.0f){
        	this.color_direction = 2.0f;
        }else if(color.r >= 1.0f){
        	this.color_direction = -2.0f;
        }

        material.color = color;
	}

	public void Save(){
		Debug.Log("Saved");
		PlayerPrefs.SetFloat("cube-speed", this.speed);
	}

	public void Load(){
		Debug.Log("Loaded");
		this.speed = PlayerPrefs.GetFloat("cube-speed", 0.0f);
	}

}
