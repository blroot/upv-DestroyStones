using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class InterfaceFinal : MonoBehaviour {

	public Text textThrown;
	public Text textDestroyed;

	// Use this for initialization
	void Start () {
		
		this.textThrown.text = "Number of stones: " + GameManager.numberOfStonesThrowed;
		this.textDestroyed.text = "Score: " + GameManager.numberOfStonesDestroyed;
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void Click() {

		GameManager.numberOfStonesDestroyed = 0;
		GameManager.numberOfStonesThrowed = 0;
		SceneManager.LoadScene ("StoneGame");
	}

}
