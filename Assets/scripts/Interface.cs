using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class Interface : MonoBehaviour {

	public Text textThrown;
	public Text textDestroyed;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
		this.textThrown.text = "Number of stones: " + GameManager.numberOfStonesThrowed;
		this.textDestroyed.text = "Score: " + GameManager.numberOfStonesDestroyed;
	}
}
