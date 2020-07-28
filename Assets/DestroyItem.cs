using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyItem : MonoBehaviour {
	private GameObject maincamera;

	// Use this for initialization
	void Start () {
		this.maincamera = GameObject.Find("Main Camera");
	}
	
	// Update is called once per frame
	void Update () {
		if(this.transform.position.z  <= maincamera.transform.position.z)
		{
			Destroy(this.gameObject);
		}
	}
}
