using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraSwitch : MonoBehaviour
{
	public Camera[] cams;

	public void mainSwitch(){
		cams[0].enabled = true;
		cams[1].enabled = false;
		cams[2].enabled = false;
	}

	public void firstSwitch(){
		cams[0].enabled = false;
		cams[1].enabled = true;
		cams[2].enabled = false;
	}

	public void thirdSwitch(){
		cams[0].enabled = false;
		cams[1].enabled = false;
		cams[2].enabled = true;
	}
}