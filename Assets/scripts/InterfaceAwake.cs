using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class InterfaceAwake : MonoBehaviour {

	// Use this for initialization
	void Start () {

		GameManager.numberOfStonesDestroyed = 0;
		GameManager.numberOfStonesThrowed = 0;
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void Click() {

		SceneManager.LoadScene ("StoneGame");
	}

}
