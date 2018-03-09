using Vuforia;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;




public class VirtualButton : MonoBehaviour, IVirtualButtonEventHandler {
	private GameObject VBButtonObject;
	private GameObject zombie;
	// Use this for initialization
	void Start () {
		VBButtonObject = GameObject.Find ("RotateZombieButton");
		VBButtonObject.GetComponent<VirtualButtonBehaviour> ().RegisterEventHandler (this);
		zombie = GameObject.Find ("zombie");
	}

	public void OnButtonPressed(VirtualButtonBehaviour vb){
		Debug.Log ("Presses");
		zombie.transform.Rotate(new Vector3(0,Time.deltaTime*1000,0));
	}


	public void OnButtonReleased(VirtualButtonBehaviour vb){
		Debug.Log ("Releases");
	}

	// Update is called once per frame

}
