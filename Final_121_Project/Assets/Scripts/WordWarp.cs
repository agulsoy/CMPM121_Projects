using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class WordWarp : MonoBehaviour
{
	bool wasPickedUp = false;
    private GameObject word;

    // Start is called before the first frame update
    void Start()
    {
        word = GameObject.Find("Find");
    }

    // Update is called once per frame
    void Update()
    {
        var transform = this.GetComponent<Transform>();
    	var scale = transform.localScale; 
    	if(this.wasPickedUp){
    		transform.localScale *= 0.1f;
    	}
    }

    void OnTriggerEnter(Collider collider) {
    
    	if(collider.gameObject.CompareTag("Player")){

            word.SendMessage("P_up");
            //ScoreScript.coinAmount += 1;
            Object.Destroy(this.gameObject, 0.3f);
    		this.wasPickedUp = true;
    	}
    }
}
