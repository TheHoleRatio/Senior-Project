using UnityEngine;
using System.Collections;

public class IndexedSphere : MonoBehaviour {

	public static int sphereIndex = 0;
	public int sphereIndex2;
	public int vIndex = 0;
	public Vector3 vertexLoc;


	// Use this for initialization
	void Start () {
		sphereIndex2 = sphereIndex;
		sphereIndex++;
	}
	
	// Update is called once per frame
	void Update () {
		transform.position = vertexLoc;
	}
}
