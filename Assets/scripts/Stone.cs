using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Stone : MonoBehaviour {

	public GameObject explosion;
	private float yDie = -30.0f;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

		if (transform.position.y < this.yDie) {

			Destroy (gameObject);
		}
	}

	void OnMouseDown() {

		Instantiate (this.explosion, transform.position, Quaternion.identity);
		Destroy (gameObject);

		GameManager.numberOfStonesDestroyed++;
	}

}
