using UnityEngine;
using System.Collections;

public class MouseLoc : MonoBehaviour {
	private Vector2 mousePosition;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		mousePosition = new Vector2 (Input.mousePosition.x, Input.mousePosition.y);
		print (mousePosition.ToString ());
	}
}
