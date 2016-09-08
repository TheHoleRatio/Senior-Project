using UnityEngine;
using System.Collections;

public class VertexCreate : MonoBehaviour {
	public static Transform crumb;
	public IndexedSphere sphereFab;
	public static IndexedSphere sphereFab2;
	public Transform crumb2;
	static SkinnedMeshRenderer mf1;
	static Vector3[] vertices;
	public static Transform body;
	// Use this for initialization
	void Start () {
		mf1 = GetComponent<SkinnedMeshRenderer>();
		vertices = mf1.sharedMesh.vertices;
		print (mf1.sharedMesh.vertexCount);
		body = transform;
		crumb = crumb2;
		sphereFab2 = sphereFab;
		Skinned ();
	}

	// Update is called once per frame
	void Update () {
		Mesh m = new Mesh ();
		mf1.BakeMesh (m);
		vertices = m.vertices;
	}

	public static void Skinned() {
		var matrix = body.localToWorldMatrix;
		for (int i = 0; i < vertices.Length; i++) {
			Instantiate (sphereFab2, body.transform.TransformPoint(vertices [i]), body.rotation);
		}
		/**
		//Jawline Instantiation
		Instantiate (sphereFab2, matrix.MultiplyPoint3x4(vertices[5907]), body.rotation);
		Instantiate (sphereFab2, matrix.MultiplyPoint3x4(vertices[5872]), body.rotation);
		Instantiate (sphereFab2, matrix.MultiplyPoint3x4(vertices[5858]), body.rotation);
		Instantiate (sphereFab2, matrix.MultiplyPoint3x4(vertices[5864]), body.rotation);
		Instantiate (sphereFab2, matrix.MultiplyPoint3x4(vertices[5807]), body.rotation);
		Instantiate (sphereFab2, matrix.MultiplyPoint3x4(vertices[8403]), body.rotation);
		Instantiate (sphereFab2, matrix.MultiplyPoint3x4(vertices[7493]), body.rotation);
		Instantiate (sphereFab2, matrix.MultiplyPoint3x4(vertices[7494]), body.rotation);
		Instantiate (sphereFab2, matrix.MultiplyPoint3x4(vertices[7499]), body.rotation);
		Instantiate (sphereFab2, matrix.MultiplyPoint3x4(vertices[7500]), body.rotation);
		Instantiate (sphereFab2, matrix.MultiplyPoint3x4(vertices[4025]), body.rotation);
		Instantiate (sphereFab2, matrix.MultiplyPoint3x4(vertices[5755]), body.rotation);
		Instantiate (sphereFab2, matrix.MultiplyPoint3x4(vertices[5742]), body.rotation);
		Instantiate (sphereFab2, matrix.MultiplyPoint3x4(vertices[5743]), body.rotation);
		Instantiate (sphereFab2, matrix.MultiplyPoint3x4(vertices[4492]), body.rotation);
		Instantiate (sphereFab2, matrix.MultiplyPoint3x4(vertices[5587]), body.rotation);
		Instantiate (sphereFab2, matrix.MultiplyPoint3x4(vertices[4624]), body.rotation);

		//Left Eyebrow
		Instantiate (sphereFab2, matrix.MultiplyPoint3x4(vertices[5302]), body.rotation);
		Instantiate (sphereFab2, matrix.MultiplyPoint3x4(vertices[7906]), body.rotation);
		Instantiate (sphereFab2, matrix.MultiplyPoint3x4(vertices[7911]), body.rotation);
		Instantiate (sphereFab2, matrix.MultiplyPoint3x4(vertices[7917]), body.rotation);
		Instantiate (sphereFab2, matrix.MultiplyPoint3x4(vertices[5347]), body.rotation);

		//Right Eyebrow
		Instantiate (sphereFab2, matrix.MultiplyPoint3x4(vertices[5376]), body.rotation);
		Instantiate (sphereFab2, matrix.MultiplyPoint3x4(vertices[5389]), body.rotation);
		Instantiate (sphereFab2, matrix.MultiplyPoint3x4(vertices[6529]), body.rotation);
		Instantiate (sphereFab2, matrix.MultiplyPoint3x4(vertices[4598]), body.rotation);
		Instantiate (sphereFab2, matrix.MultiplyPoint3x4(vertices[4602]), body.rotation);

		//Nose Bridge
		Instantiate (sphereFab2, matrix.MultiplyPoint3x4(vertices[5403]), body.rotation);
		Instantiate (sphereFab2, matrix.MultiplyPoint3x4(vertices[5491]), body.rotation);
		Instantiate (sphereFab2, matrix.MultiplyPoint3x4(vertices[5441]), body.rotation);
		Instantiate (sphereFab2, matrix.MultiplyPoint3x4(vertices[5447]), body.rotation);

		//Nose
		Instantiate (sphereFab2, matrix.MultiplyPoint3x4(vertices[4946]), body.rotation);
		Instantiate (sphereFab2, matrix.MultiplyPoint3x4(vertices[4942]), body.rotation);
		Instantiate (sphereFab2, matrix.MultiplyPoint3x4(vertices[4939]), body.rotation);
		Instantiate (sphereFab2, matrix.MultiplyPoint3x4(vertices[4941]), body.rotation);
		Instantiate (sphereFab2, matrix.MultiplyPoint3x4(vertices[4927]), body.rotation);

		//Left Eye
		Instantiate (sphereFab2, matrix.MultiplyPoint3x4(vertices[5259]), body.rotation);
		Instantiate (sphereFab2, matrix.MultiplyPoint3x4(vertices[5252]), body.rotation);
		Instantiate (sphereFab2, matrix.MultiplyPoint3x4(vertices[5191]), body.rotation);
		Instantiate (sphereFab2, matrix.MultiplyPoint3x4(vertices[5187]), body.rotation);
		Instantiate (sphereFab2, matrix.MultiplyPoint3x4(vertices[5136]), body.rotation);
		Instantiate (sphereFab2, matrix.MultiplyPoint3x4(vertices[5287]), body.rotation);

		//Right Eye
		Instantiate (sphereFab2, matrix.MultiplyPoint3x4(vertices[4745]), body.rotation);
		Instantiate (sphereFab2, matrix.MultiplyPoint3x4(vertices[4748]), body.rotation);
		Instantiate (sphereFab2, matrix.MultiplyPoint3x4(vertices[4661]), body.rotation);
		Instantiate (sphereFab2, matrix.MultiplyPoint3x4(vertices[4685]), body.rotation);
		Instantiate (sphereFab2, matrix.MultiplyPoint3x4(vertices[4693]), body.rotation);
		Instantiate (sphereFab2, matrix.MultiplyPoint3x4(vertices[4701]), body.rotation);

		//Mouth Outline
		Instantiate (sphereFab2, matrix.MultiplyPoint3x4(vertices[7731]), body.rotation);
		Instantiate (sphereFab2, matrix.MultiplyPoint3x4(vertices[7538]), body.rotation);
		Instantiate (sphereFab2, matrix.MultiplyPoint3x4(vertices[4461]), body.rotation);
		Instantiate (sphereFab2, matrix.MultiplyPoint3x4(vertices[4441]), body.rotation);
		Instantiate (sphereFab2, matrix.MultiplyPoint3x4(vertices[4404]), body.rotation);
		Instantiate (sphereFab2, matrix.MultiplyPoint3x4(vertices[4397]), body.rotation);
		Instantiate (sphereFab2, matrix.MultiplyPoint3x4(vertices[4352]), body.rotation);
		Instantiate (sphereFab2, matrix.MultiplyPoint3x4(vertices[4254]), body.rotation);
		Instantiate (sphereFab2, matrix.MultiplyPoint3x4(vertices[4260]), body.rotation);
		Instantiate (sphereFab2, matrix.MultiplyPoint3x4(vertices[7398]), body.rotation);
		Instantiate (sphereFab2, matrix.MultiplyPoint3x4(vertices[7440]), body.rotation);
		Instantiate (sphereFab2, matrix.MultiplyPoint3x4(vertices[7444]), body.rotation);

		//Mouth Inner
		Instantiate (sphereFab2, matrix.MultiplyPoint3x4(vertices[7555]), body.rotation);
		Instantiate (sphereFab2, matrix.MultiplyPoint3x4(vertices[4482]), body.rotation);
		Instantiate (sphereFab2, matrix.MultiplyPoint3x4(vertices[4445]), body.rotation);
		Instantiate (sphereFab2, matrix.MultiplyPoint3x4(vertices[4413]), body.rotation);
		Instantiate (sphereFab2, matrix.MultiplyPoint3x4(vertices[4268]), body.rotation);
		Instantiate (sphereFab2, matrix.MultiplyPoint3x4(vertices[7387]), body.rotation);
		Instantiate (sphereFab2, matrix.MultiplyPoint3x4(vertices[7396]), body.rotation);
		Instantiate (sphereFab2, matrix.MultiplyPoint3x4(vertices[7488]), body.rotation);
		**/

		}
	}
