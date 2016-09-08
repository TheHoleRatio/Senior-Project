using UnityEngine;
using System.Collections;

public class GetWeights : MonoBehaviour {
	int blendShapeCount;
	SkinnedMeshRenderer skinnedMeshRenderer;
	Mesh skinnedMesh;
	// Use this for initialization
	void Awake ()
	{
		skinnedMeshRenderer = GetComponent<SkinnedMeshRenderer> ();
		skinnedMesh = GetComponent<SkinnedMeshRenderer> ().sharedMesh;
	}

	void Start () {
		blendShapeCount = skinnedMesh.blendShapeCount; 
		string weights = "";
		for (int i = 0; i < blendShapeCount; i++) {
			weights = weights + skinnedMeshRenderer.GetBlendShapeWeight (i)+"\n";
		}
		Debug.Log (weights);
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
