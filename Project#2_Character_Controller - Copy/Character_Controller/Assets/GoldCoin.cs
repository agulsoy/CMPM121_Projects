using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GoldCoin : MonoBehaviour
{
	bool wasPickedUp = false;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        var transform = this.GetComponent<Transform>();
    	transform.localRotation *= Quaternion.Euler(0.0f, 0.0f * Time.deltaTime, 2.0f); 
    	if(this.wasPickedUp){
    		transform.localScale *= 0.8f;
    	}
    }

    void OnTriggerEnter(Collider collider) {
    
    	if(collider.gameObject.CompareTag("Player")){
    		
    		ScoreScript.coinAmount += 1;
    		Object.Destroy(this.gameObject, 0.0f);
    		this.wasPickedUp = true;
    	}
    } 
    // for (int i  = 0; i<coinAmount; i++){

    // }
}
