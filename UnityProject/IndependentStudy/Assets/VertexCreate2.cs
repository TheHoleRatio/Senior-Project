using UnityEngine;
using System.Collections;
using System.IO;
using System.Collections.Generic;

public class VertexCreate2 : MonoBehaviour {
	public static Transform crumb;
	public IndexedSphere sphereFab;
	public static IndexedSphere sphereFab2;
	public Transform crumb2;
	static SkinnedMeshRenderer mf1;
	static Vector3[] vertices;
	public static Transform body;
	public Camera cameraView;
	public List<Vector3> coords = new List<Vector3>();
	public static int faceNum = 0;

	private Mesh m;


	//68 IndexedSphere references
	//Jawline
	public static IndexedSphere v1;
	public static IndexedSphere v2;
	public static IndexedSphere v3;
	public static IndexedSphere v4;
	public static IndexedSphere v5;
	public static IndexedSphere v6;
	public static IndexedSphere v7;
	public static IndexedSphere v8;
	public static IndexedSphere v9;
	public static IndexedSphere v10;
	public static IndexedSphere v11;
	public static IndexedSphere v12;
	public static IndexedSphere v13;
	public static IndexedSphere v14;
	public static IndexedSphere v15;
	public static IndexedSphere v16;
	public static IndexedSphere v17;

	//Left Eyebrow
	public static IndexedSphere v18;
	public static IndexedSphere v19;
	public static IndexedSphere v20;
	public static IndexedSphere v21;
	public static IndexedSphere v22;

	//Right Eyebrow
	public static IndexedSphere v23;
	public static IndexedSphere v24;
	public static IndexedSphere v25;
	public static IndexedSphere v26;
	public static IndexedSphere v27;

	//Nose Bridge
	public static IndexedSphere v28;
	public static IndexedSphere v29;
	public static IndexedSphere v30;
	public static IndexedSphere v31;

	//Nose
	public static IndexedSphere v32;
	public static IndexedSphere v33;
	public static IndexedSphere v34;
	public static IndexedSphere v35;
	public static IndexedSphere v36;

	//Left Eye
	public static IndexedSphere v37;
	public static IndexedSphere v38;
	public static IndexedSphere v39;
	public static IndexedSphere v40;
	public static IndexedSphere v41;
	public static IndexedSphere v42;

	//Right Eye
	public static IndexedSphere v43;
	public static IndexedSphere v44;
	public static IndexedSphere v45;
	public static IndexedSphere v46;
	public static IndexedSphere v47;
	public static IndexedSphere v48;

	//Mouth Outline
	public static IndexedSphere v49;
	public static IndexedSphere v50;
	public static IndexedSphere v51;
	public static IndexedSphere v52;
	public static IndexedSphere v53;
	public static IndexedSphere v54;
	public static IndexedSphere v55;
	public static IndexedSphere v56;
	public static IndexedSphere v57;
	public static IndexedSphere v58;
	public static IndexedSphere v59;
	public static IndexedSphere v60;

	//Mouth Inner
	public static IndexedSphere v61;
	public static IndexedSphere v62;
	public static IndexedSphere v63;
	public static IndexedSphere v64;
	public static IndexedSphere v65;
	public static IndexedSphere v66;
	public static IndexedSphere v67;
	public static IndexedSphere v68;

	// Use this for initialization
	void Start () {
		mf1 = GetComponent<SkinnedMeshRenderer>();
		vertices = mf1.sharedMesh.vertices;
		body = transform;
		crumb = crumb2;
		sphereFab2 = sphereFab;
		Skinned ();
		addCoords ();
	}

	// Update is called once per frame
	public void TransformVerts () {
		Destroy (m);
		m = new Mesh ();
		mf1.BakeMesh (m);
		vertices = m.vertices;
		updateVertexLocs();
	}

	public void updateVertexLocs()
	{
		//Jawline
		v1.vertexLoc = body.TransformPoint(vertices[v1.vIndex]);
		v2.vertexLoc = body.TransformPoint(vertices[v2.vIndex]);
		v3.vertexLoc = body.TransformPoint(vertices[v3.vIndex]);
		v4.vertexLoc = body.TransformPoint(vertices[v4.vIndex]);
		v5.vertexLoc = body.TransformPoint(vertices[v5.vIndex]);
		v6.vertexLoc = body.TransformPoint(vertices[v6.vIndex]);
		v7.vertexLoc = body.TransformPoint(vertices[v7.vIndex]);
		v8.vertexLoc = body.TransformPoint(vertices[v8.vIndex]);
		v9.vertexLoc = body.TransformPoint(vertices[v9.vIndex]);
		v10.vertexLoc = body.TransformPoint(vertices[v10.vIndex]);
		v11.vertexLoc = body.TransformPoint(vertices[v11.vIndex]);
		v12.vertexLoc = body.TransformPoint(vertices[v12.vIndex]);
		v13.vertexLoc = body.TransformPoint(vertices[v13.vIndex]);
		v14.vertexLoc = body.TransformPoint(vertices[v14.vIndex]);
		v15.vertexLoc = body.TransformPoint(vertices[v15.vIndex]);
		v16.vertexLoc = body.TransformPoint(vertices[v16.vIndex]);
		v17.vertexLoc = body.TransformPoint(vertices[v17.vIndex]);

		//Left Eyebrow
		v18.vertexLoc = body.TransformPoint(vertices[v18.vIndex]);
		v19.vertexLoc = body.TransformPoint(vertices[v19.vIndex]);
		v20.vertexLoc = body.TransformPoint(vertices[v20.vIndex]);
		v21.vertexLoc = body.TransformPoint(vertices[v21.vIndex]);
		v22.vertexLoc = body.TransformPoint(vertices[v22.vIndex]);

		//Right Eyebrow
		v23.vertexLoc = body.TransformPoint(vertices[v23.vIndex]);
		v24.vertexLoc = body.TransformPoint(vertices[v24.vIndex]);
		v25.vertexLoc = body.TransformPoint(vertices[v25.vIndex]);
		v26.vertexLoc = body.TransformPoint(vertices[v26.vIndex]);
		v27.vertexLoc = body.TransformPoint(vertices[v27.vIndex]);

		//Nose Bridge
		v28.vertexLoc = body.TransformPoint(vertices[v28.vIndex]);
		v29.vertexLoc = body.TransformPoint(vertices[v29.vIndex]);
		v30.vertexLoc = body.TransformPoint(vertices[v30.vIndex]);
		v31.vertexLoc = body.TransformPoint(vertices[v31.vIndex]);

		//Nose
		v32.vertexLoc = body.TransformPoint(vertices[v32.vIndex]);
		v33.vertexLoc = body.TransformPoint(vertices[v33.vIndex]);
		v34.vertexLoc = body.TransformPoint(vertices[v34.vIndex]);
		v35.vertexLoc = body.TransformPoint(vertices[v35.vIndex]);
		v36.vertexLoc = body.TransformPoint(vertices[v36.vIndex]);

		//Left Eye
		v37.vertexLoc = body.TransformPoint(vertices[v37.vIndex]);
		v38.vertexLoc = body.TransformPoint(vertices[v38.vIndex]);
		v39.vertexLoc = body.TransformPoint(vertices[v39.vIndex]);
		v40.vertexLoc = body.TransformPoint(vertices[v40.vIndex]);
		v41.vertexLoc = body.TransformPoint(vertices[v41.vIndex]);
		v42.vertexLoc = body.TransformPoint(vertices[v42.vIndex]);

		//Right Eye
		v43.vertexLoc = body.TransformPoint(vertices[v43.vIndex]);
		v44.vertexLoc = body.TransformPoint(vertices[v44.vIndex]);
		v45.vertexLoc = body.TransformPoint(vertices[v45.vIndex]);
		v46.vertexLoc = body.TransformPoint(vertices[v46.vIndex]);
		v47.vertexLoc = body.TransformPoint(vertices[v47.vIndex]);
		v48.vertexLoc = body.TransformPoint(vertices[v48.vIndex]);

		//Mouth Outline
		v49.vertexLoc = body.TransformPoint(vertices[v49.vIndex]);
		v50.vertexLoc = body.TransformPoint(vertices[v50.vIndex]);
		v51.vertexLoc = body.TransformPoint(vertices[v51.vIndex]);
		v52.vertexLoc = body.TransformPoint(vertices[v52.vIndex]);
		v53.vertexLoc = body.TransformPoint(vertices[v53.vIndex]);
		v54.vertexLoc = body.TransformPoint(vertices[v54.vIndex]);
		v55.vertexLoc = body.TransformPoint(vertices[v55.vIndex]);
		v56.vertexLoc = body.TransformPoint(vertices[v56.vIndex]);
		v57.vertexLoc = body.TransformPoint(vertices[v57.vIndex]);
		v58.vertexLoc = body.TransformPoint(vertices[v58.vIndex]);
		v59.vertexLoc = body.TransformPoint(vertices[v59.vIndex]);
		v60.vertexLoc = body.TransformPoint(vertices[v60.vIndex]);

		//Mouth Inner
		v61.vertexLoc = body.TransformPoint(vertices[v61.vIndex]);
		v62.vertexLoc = body.TransformPoint(vertices[v62.vIndex]);
		v63.vertexLoc = body.TransformPoint(vertices[v63.vIndex]);
		v64.vertexLoc = body.TransformPoint(vertices[v64.vIndex]);
		v65.vertexLoc = body.TransformPoint(vertices[v65.vIndex]);
		v66.vertexLoc = body.TransformPoint(vertices[v66.vIndex]);
		v67.vertexLoc = body.TransformPoint(vertices[v67.vIndex]);
		v68.vertexLoc = body.TransformPoint(vertices[v68.vIndex]);

		//2d coordinate writing out
		updateCoords();
		//write2DCoords();
	}

	public static void Skinned() {
		var matrix = body.localToWorldMatrix;
		//Jawline
		v1 = (Instantiate (sphereFab2, matrix.MultiplyPoint3x4(vertices[5501]), body.rotation) as IndexedSphere);
		v1.vIndex = 5501;
		v1.vertexLoc = matrix.MultiplyPoint3x4(vertices[v1.vIndex]);
		v1.transform.parent = body;
		v2 = (Instantiate (sphereFab2, matrix.MultiplyPoint3x4(vertices[5505]), body.rotation) as IndexedSphere);
		v2.vIndex = 5505;
		v2.vertexLoc = matrix.MultiplyPoint3x4(vertices[v2.vIndex]);
		v2.transform.parent = body;
		v3 = (Instantiate (sphereFab2, matrix.MultiplyPoint3x4(vertices[5723]), body.rotation) as IndexedSphere);
		v3.vIndex = 5723;
		v3.vertexLoc = matrix.MultiplyPoint3x4(vertices[v3.vIndex]);
		v3.transform.parent = body;
		v4 = (Instantiate (sphereFab2, matrix.MultiplyPoint3x4(vertices[5351]), body.rotation) as IndexedSphere);
		v4.vIndex = 5351;
		v4.vertexLoc = matrix.MultiplyPoint3x4(vertices[v4.vIndex]);
		v4.transform.parent = body;
		v5 = (Instantiate (sphereFab2, matrix.MultiplyPoint3x4(vertices[4905]), body.rotation) as IndexedSphere);
		v5.vIndex = 4905;
		v5.vertexLoc = matrix.MultiplyPoint3x4(vertices[v5.vIndex]);
		v5.transform.parent = body;
		v6 = (Instantiate (sphereFab2, matrix.MultiplyPoint3x4(vertices[4553]), body.rotation) as IndexedSphere);
		v6.vIndex = 4553;
		v6.vertexLoc = matrix.MultiplyPoint3x4(vertices[v6.vIndex]);
		v6.transform.parent = body;
		v7 = (Instantiate (sphereFab2, matrix.MultiplyPoint3x4(vertices[4551]), body.rotation) as IndexedSphere);
		v7.vIndex = 4551;
		v7.vertexLoc = matrix.MultiplyPoint3x4(vertices[v7.vIndex]);
		v7.transform.parent = body;
		v8 = (Instantiate (sphereFab2, matrix.MultiplyPoint3x4(vertices[4543]), body.rotation) as IndexedSphere);
		v8.vIndex = 4543;
		v8.vertexLoc = matrix.MultiplyPoint3x4(vertices[v8.vIndex]);
		v8.transform.parent = body;
		v9 = (Instantiate (sphereFab2, matrix.MultiplyPoint3x4(vertices[3168]), body.rotation) as IndexedSphere);
		v9.vIndex = 3168;
		v9.vertexLoc = matrix.MultiplyPoint3x4(vertices[v9.vIndex]);
		v9.transform.parent = body;
		v10 = (Instantiate (sphereFab2, matrix.MultiplyPoint3x4(vertices[4096]), body.rotation) as IndexedSphere);
		v10.vIndex = 4096;
		v10.vertexLoc = matrix.MultiplyPoint3x4(vertices[v10.vIndex]);
		v10.transform.parent = body;
		v11 = (Instantiate (sphereFab2, matrix.MultiplyPoint3x4(vertices[3291]), body.rotation) as IndexedSphere);
		v11.vIndex = 3291;
		v11.vertexLoc = matrix.MultiplyPoint3x4(vertices[v11.vIndex]);
		v11.transform.parent = body;
		v12 = (Instantiate (sphereFab2, matrix.MultiplyPoint3x4(vertices[3570]), body.rotation) as IndexedSphere);
		v12.vIndex = 3570;
		v12.vertexLoc = matrix.MultiplyPoint3x4(vertices[v12.vIndex]);
		v12.transform.parent = body;
		v13 = (Instantiate (sphereFab2, matrix.MultiplyPoint3x4(vertices[3700]), body.rotation) as IndexedSphere);
		v13.vIndex = 3700;
		v13.vertexLoc = matrix.MultiplyPoint3x4(vertices[v13.vIndex]);
		v13.transform.parent = body;
		v14 = (Instantiate (sphereFab2, matrix.MultiplyPoint3x4(vertices[3971]), body.rotation) as IndexedSphere);
		v14.vIndex = 3971;
		v14.vertexLoc = matrix.MultiplyPoint3x4(vertices[v14.vIndex]);
		v14.transform.parent = body;
		v15 = (Instantiate (sphereFab2, matrix.MultiplyPoint3x4(vertices[5739]), body.rotation) as IndexedSphere);
		v15.vIndex = 5739;
		v15.vertexLoc = matrix.MultiplyPoint3x4(vertices[v15.vIndex]);
		v15.transform.parent = body;
		v16 = (Instantiate (sphereFab2, matrix.MultiplyPoint3x4(vertices[4101]), body.rotation) as IndexedSphere);
		v16.vIndex = 4101;
		v16.vertexLoc = matrix.MultiplyPoint3x4(vertices[v16.vIndex]);
		v16.transform.parent = body;
		v17 = (Instantiate (sphereFab2, matrix.MultiplyPoint3x4(vertices[4123]), body.rotation) as IndexedSphere);
		v17.vIndex = 4123;
		v17.vertexLoc = matrix.MultiplyPoint3x4(vertices[v17.vIndex]);
		v17.transform.parent = body;

		//Left Eyebrow
		v18 = (Instantiate (sphereFab2, body.TransformPoint(vertices[4668]), body.rotation) as IndexedSphere);
		v18.vIndex = 4668;
		v18.vertexLoc = matrix.MultiplyPoint3x4(vertices[v18.vIndex]);
		v18.transform.parent = body;
		v19 = (Instantiate (sphereFab2, matrix.MultiplyPoint3x4(vertices[4774]), body.rotation) as IndexedSphere);
		v19.vIndex = 4774;
		v19.vertexLoc = matrix.MultiplyPoint3x4(vertices[v19.vIndex]);
		v19.transform.parent = body;
		v20 = (Instantiate (sphereFab2, matrix.MultiplyPoint3x4(vertices[4869]), body.rotation) as IndexedSphere);
		v20.vIndex = 4869;
		v20.vertexLoc = matrix.MultiplyPoint3x4(vertices[v20.vIndex]);
		v20.transform.parent = body;
		v21 = (Instantiate (sphereFab2, matrix.MultiplyPoint3x4(vertices[4962]), body.rotation) as IndexedSphere);
		v21.vIndex = 4962;
		v21.vertexLoc = matrix.MultiplyPoint3x4(vertices[v21.vIndex]);
		v21.transform.parent = body;
		v22 = (Instantiate (sphereFab2, matrix.MultiplyPoint3x4(vertices[6212]), body.rotation) as IndexedSphere);
		v22.vIndex = 6212;
		v22.vertexLoc = matrix.MultiplyPoint3x4(vertices[v22.vIndex]);
		v22.transform.parent = body;

		//Right Eyebrow
		v23 = (Instantiate (sphereFab2, matrix.MultiplyPoint3x4(vertices[6146]), body.rotation) as IndexedSphere);
		v23.vIndex = 6146;
		v23.vertexLoc = matrix.MultiplyPoint3x4(vertices[v23.vIndex]);
		v23.transform.parent = body;
		v24 = (Instantiate (sphereFab2, matrix.MultiplyPoint3x4(vertices[4111]), body.rotation) as IndexedSphere);
		v24.vIndex = 4111;
		v24.vertexLoc = matrix.MultiplyPoint3x4(vertices[v24.vIndex]);
		v24.transform.parent = body;
		v25 = (Instantiate (sphereFab2, matrix.MultiplyPoint3x4(vertices[3380]), body.rotation) as IndexedSphere);
		v25.vIndex = 3380;
		v25.vertexLoc = matrix.MultiplyPoint3x4(vertices[v25.vIndex]);
		v25.transform.parent = body;
		v26 = (Instantiate (sphereFab2, matrix.MultiplyPoint3x4(vertices[3544]), body.rotation) as IndexedSphere);
		v26.vIndex = 3544;
		v26.vertexLoc = matrix.MultiplyPoint3x4(vertices[v26.vIndex]);
		v26.transform.parent = body;
		v27 = (Instantiate (sphereFab2, matrix.MultiplyPoint3x4(vertices[3379]), body.rotation) as IndexedSphere);
		v27.vIndex = 3379;
		v27.vertexLoc = matrix.MultiplyPoint3x4(vertices[v27.vIndex]);
		v27.transform.parent = body;

		//Nose Bridge
		v28 = (Instantiate (sphereFab2, matrix.MultiplyPoint3x4(vertices[4053]), body.rotation) as IndexedSphere);
		v28.vIndex = 4053;
		v28.vertexLoc = matrix.MultiplyPoint3x4(vertices[v28.vIndex]);
		v28.transform.parent = body;
		v29 = (Instantiate (sphereFab2, matrix.MultiplyPoint3x4(vertices[4162]), body.rotation) as IndexedSphere);
		v29.vIndex = 4162;
		v29.vertexLoc = matrix.MultiplyPoint3x4(vertices[v29.vIndex]);
		v29.transform.parent = body;
		v30 = (Instantiate (sphereFab2, matrix.MultiplyPoint3x4(vertices[3180]), body.rotation) as IndexedSphere);
		v30.vIndex = 3180;
		v30.vertexLoc = matrix.MultiplyPoint3x4(vertices[v30.vIndex]);
		v30.transform.parent = body;
		v31 = (Instantiate (sphereFab2, matrix.MultiplyPoint3x4(vertices[5958]), body.rotation) as IndexedSphere);
		v31.vIndex = 5958;
		v31.vertexLoc = matrix.MultiplyPoint3x4(vertices[v31.vIndex]);
		v31.transform.parent = body;

		//Nose
		v32 = (Instantiate (sphereFab2, matrix.MultiplyPoint3x4(vertices[5988]), body.rotation) as IndexedSphere);
		v32.vIndex = 5988;
		v32.vertexLoc = matrix.MultiplyPoint3x4(vertices[v32.vIndex]);
		v32.transform.parent = body;
		v33 = (Instantiate (sphereFab2, matrix.MultiplyPoint3x4(vertices[4742]), body.rotation) as IndexedSphere);
		v33.vIndex = 4742;
		v33.vertexLoc = matrix.MultiplyPoint3x4(vertices[v33.vIndex]);
		v33.transform.parent = body;
		v34 = (Instantiate (sphereFab2, matrix.MultiplyPoint3x4(vertices[3176]), body.rotation) as IndexedSphere);
		v34.vIndex = 3176;
		v34.vertexLoc = matrix.MultiplyPoint3x4(vertices[v34.vIndex]);
		v34.transform.parent = body;
		v35 = (Instantiate (sphereFab2, matrix.MultiplyPoint3x4(vertices[3353]), body.rotation) as IndexedSphere);
		v35.vIndex = 3353;
		v35.vertexLoc = matrix.MultiplyPoint3x4(vertices[v35.vIndex]);
		v35.transform.parent = body;
		v36 = (Instantiate (sphereFab2, matrix.MultiplyPoint3x4(vertices[5986]), body.rotation) as IndexedSphere);
		v36.vIndex = 5986;
		v36.vertexLoc = matrix.MultiplyPoint3x4(vertices[v36.vIndex]);
		v36.transform.parent = body;

		//Left Eye
		v37 = (Instantiate (sphereFab2, matrix.MultiplyPoint3x4(vertices[4824]), body.rotation) as IndexedSphere);
		v37.vIndex = 4824;
		v37.vertexLoc = matrix.MultiplyPoint3x4(vertices[v37.vIndex]);
		v37.transform.parent = body;
		v38 = (Instantiate (sphereFab2, matrix.MultiplyPoint3x4(vertices[6035]), body.rotation) as IndexedSphere);
		v38.vIndex = 6035;
		v38.vertexLoc = matrix.MultiplyPoint3x4(vertices[v38.vIndex]);
		v38.transform.parent = body;
		v39 = (Instantiate (sphereFab2, matrix.MultiplyPoint3x4(vertices[4830]), body.rotation) as IndexedSphere);
		v39.vIndex = 4830;
		v39.vertexLoc = matrix.MultiplyPoint3x4(vertices[v39.vIndex]);
		v39.transform.parent = body;
		v40 = (Instantiate (sphereFab2, matrix.MultiplyPoint3x4(vertices[4930]), body.rotation) as IndexedSphere);
		v40.vIndex = 4930;
		v40.vertexLoc = matrix.MultiplyPoint3x4(vertices[v40.vIndex]);
		v40.transform.parent = body;
		v41 = (Instantiate (sphereFab2, matrix.MultiplyPoint3x4(vertices[5314]), body.rotation) as IndexedSphere);
		v41.vIndex = 5314;
		v41.vertexLoc = matrix.MultiplyPoint3x4(vertices[v41.vIndex]);
		v41.transform.parent = body;
		v42 = (Instantiate (sphereFab2, matrix.MultiplyPoint3x4(vertices[7081]), body.rotation) as IndexedSphere);
		v42.vIndex = 7081;
		v42.vertexLoc = matrix.MultiplyPoint3x4(vertices[v42.vIndex]);
		v42.transform.parent = body;

		//Right Eye
		v43 = (Instantiate (sphereFab2, matrix.MultiplyPoint3x4(vertices[6276]), body.rotation) as IndexedSphere);
		v43.vIndex = 6276;
		v43.vertexLoc = matrix.MultiplyPoint3x4(vertices[v43.vIndex]);
		v43.transform.parent = body;
		v44 = (Instantiate (sphereFab2, matrix.MultiplyPoint3x4(vertices[4132]), body.rotation) as IndexedSphere);
		v44.vIndex = 4132;
		v44.vertexLoc = matrix.MultiplyPoint3x4(vertices[v44.vIndex]);
		v44.transform.parent = body;
		v45 = (Instantiate (sphereFab2, matrix.MultiplyPoint3x4(vertices[4134]), body.rotation) as IndexedSphere);
		v45.vIndex = 4134;
		v45.vertexLoc = matrix.MultiplyPoint3x4(vertices[v45.vIndex]);
		v45.transform.parent = body;
		v46 = (Instantiate (sphereFab2, matrix.MultiplyPoint3x4(vertices[3500]), body.rotation) as IndexedSphere);
		v46.vIndex = 3500;
		v46.vertexLoc = matrix.MultiplyPoint3x4(vertices[v46.vIndex]);
		v46.transform.parent = body;
		v47 = (Instantiate (sphereFab2, matrix.MultiplyPoint3x4(vertices[3496]), body.rotation) as IndexedSphere);
		v47.vIndex = 3496;
		v47.vertexLoc = matrix.MultiplyPoint3x4(vertices[v47.vIndex]);
		v47.transform.parent = body;
		v48 = (Instantiate (sphereFab2, matrix.MultiplyPoint3x4(vertices[3911]), body.rotation) as IndexedSphere);
		v48.vIndex = 3911;
		v48.vertexLoc = matrix.MultiplyPoint3x4(vertices[v48.vIndex]);
		v48.transform.parent = body;

		//Mouth Outline
		v49 = (Instantiate (sphereFab2, matrix.MultiplyPoint3x4(vertices[5319]), body.rotation) as IndexedSphere);
		v49.vIndex = 5319;
		v49.vertexLoc = matrix.MultiplyPoint3x4(vertices[v49.vIndex]);
		v49.transform.parent = body;
		v50 = (Instantiate (sphereFab2, matrix.MultiplyPoint3x4(vertices[4710]), body.rotation) as IndexedSphere);
		v50.vIndex = 4710;
		v50.vertexLoc = matrix.MultiplyPoint3x4(vertices[v50.vIndex]);
		v50.transform.parent = body;
		v51 = (Instantiate (sphereFab2, matrix.MultiplyPoint3x4(vertices[6071]), body.rotation) as IndexedSphere);
		v51.vIndex = 6071;
		v51.vertexLoc = matrix.MultiplyPoint3x4(vertices[v51.vIndex]);
		v51.transform.parent = body;
		v52 = (Instantiate (sphereFab2, matrix.MultiplyPoint3x4(vertices[3173]), body.rotation) as IndexedSphere);
		v52.vIndex = 3173;
		v52.vertexLoc = matrix.MultiplyPoint3x4(vertices[v52.vIndex]);
		v52.transform.parent = body;
		v53 = (Instantiate (sphereFab2, matrix.MultiplyPoint3x4(vertices[6085]), body.rotation) as IndexedSphere);
		v53.vIndex = 6085;
		v53.vertexLoc = matrix.MultiplyPoint3x4(vertices[v53.vIndex]);
		v53.transform.parent = body;
		v54 = (Instantiate (sphereFab2, matrix.MultiplyPoint3x4(vertices[3323]), body.rotation) as IndexedSphere);
		v54.vIndex = 3323;
		v54.vertexLoc = matrix.MultiplyPoint3x4(vertices[v54.vIndex]);
		v54.transform.parent = body;
		v55 = (Instantiate (sphereFab2, matrix.MultiplyPoint3x4(vertices[4063]), body.rotation) as IndexedSphere);
		v55.vIndex = 4063;
		v55.vertexLoc = matrix.MultiplyPoint3x4(vertices[v55.vIndex]);
		v55.transform.parent = body;
		v56 = (Instantiate (sphereFab2, matrix.MultiplyPoint3x4(vertices[3317]), body.rotation) as IndexedSphere);
		v56.vIndex = 3317;
		v56.vertexLoc = matrix.MultiplyPoint3x4(vertices[v56.vIndex]);
		v56.transform.parent = body;
		v57 = (Instantiate (sphereFab2, matrix.MultiplyPoint3x4(vertices[3409]), body.rotation) as IndexedSphere);
		v57.vIndex = 3409;
		v57.vertexLoc = matrix.MultiplyPoint3x4(vertices[v57.vIndex]);
		v57.transform.parent = body;
		v58 = (Instantiate (sphereFab2, matrix.MultiplyPoint3x4(vertices[3184]), body.rotation) as IndexedSphere);
		v58.vIndex = 3184;
		v58.vertexLoc = matrix.MultiplyPoint3x4(vertices[v58.vIndex]);
		v58.transform.parent = body;
		v59 = (Instantiate (sphereFab2, matrix.MultiplyPoint3x4(vertices[4702]), body.rotation) as IndexedSphere);
		v59.vIndex = 4702;
		v59.vertexLoc = matrix.MultiplyPoint3x4(vertices[v59.vIndex]);
		v59.transform.parent = body;
		v60 = (Instantiate (sphereFab2, matrix.MultiplyPoint3x4(vertices[4704]), body.rotation) as IndexedSphere);
		v60.vIndex = 4704;
		v60.vertexLoc = matrix.MultiplyPoint3x4(vertices[v60.vIndex]);
		v60.transform.parent = body;

		//Mouth Inner
		v61 = (Instantiate (sphereFab2, matrix.MultiplyPoint3x4(vertices[5107]), body.rotation) as IndexedSphere);
		v61.vIndex = 5107;
		v61.vertexLoc = matrix.MultiplyPoint3x4(vertices[v61.vIndex]);
		v61.transform.parent = body;
		v62 = (Instantiate (sphereFab2, matrix.MultiplyPoint3x4(vertices[4589]), body.rotation) as IndexedSphere);
		v62.vIndex = 4589;
		v62.vertexLoc = matrix.MultiplyPoint3x4(vertices[v62.vIndex]);
		v62.transform.parent = body;
		v63 = (Instantiate (sphereFab2, matrix.MultiplyPoint3x4(vertices[3727]), body.rotation) as IndexedSphere);
		v63.vIndex = 3727;
		v63.vertexLoc = matrix.MultiplyPoint3x4(vertices[v63.vIndex]);
		v63.transform.parent = body;
		v64 = (Instantiate (sphereFab2, matrix.MultiplyPoint3x4(vertices[3325]), body.rotation) as IndexedSphere);
		v64.vIndex = 3325;
		v64.vertexLoc = matrix.MultiplyPoint3x4(vertices[v64.vIndex]);
		v64.transform.parent = body;
		v65 = (Instantiate (sphereFab2, matrix.MultiplyPoint3x4(vertices[3722]), body.rotation) as IndexedSphere);
		v65.vIndex = 3722;
		v65.vertexLoc = matrix.MultiplyPoint3x4(vertices[v65.vIndex]);
		v65.transform.parent = body;
		v66 = (Instantiate (sphereFab2, matrix.MultiplyPoint3x4(vertices[3321]), body.rotation) as IndexedSphere);
		v66.vIndex = 3321;
		v66.vertexLoc = matrix.MultiplyPoint3x4(vertices[v66.vIndex]);
		v66.transform.parent = body;
		v67 = (Instantiate (sphereFab2, matrix.MultiplyPoint3x4(vertices[3171]), body.rotation) as IndexedSphere);
		v67.vIndex = 3171;
		v67.vertexLoc = matrix.MultiplyPoint3x4(vertices[v67.vIndex]);
		v67.transform.parent = body;
		v68 = (Instantiate (sphereFab2, matrix.MultiplyPoint3x4(vertices[4577]), body.rotation) as IndexedSphere);
		v68.vIndex = 4577;
		v68.vertexLoc = matrix.MultiplyPoint3x4(vertices[v68.vIndex]);
		v68.transform.parent = body;
	}

	void addCoords()
	{
		//Finish next week
		//Jawline (x,y) coord conversion
		coords.Add(cameraView.WorldToScreenPoint(v1.vertexLoc));
		coords.Add(cameraView.WorldToScreenPoint(v2.vertexLoc));
		coords.Add(cameraView.WorldToScreenPoint(v3.vertexLoc));
		coords.Add(cameraView.WorldToScreenPoint(v4.vertexLoc));
		coords.Add(cameraView.WorldToScreenPoint(v5.vertexLoc));
		coords.Add(cameraView.WorldToScreenPoint(v6.vertexLoc));
		coords.Add(cameraView.WorldToScreenPoint(v7.vertexLoc));
		coords.Add(cameraView.WorldToScreenPoint(v8.vertexLoc));
		coords.Add(cameraView.WorldToScreenPoint(v9.vertexLoc));
		coords.Add(cameraView.WorldToScreenPoint(v10.vertexLoc));
		coords.Add(cameraView.WorldToScreenPoint(v11.vertexLoc));
		coords.Add(cameraView.WorldToScreenPoint(v12.vertexLoc));
		coords.Add(cameraView.WorldToScreenPoint(v13.vertexLoc));
		coords.Add(cameraView.WorldToScreenPoint(v14.vertexLoc));
		coords.Add(cameraView.WorldToScreenPoint(v15.vertexLoc));
		coords.Add(cameraView.WorldToScreenPoint(v16.vertexLoc));
		coords.Add(cameraView.WorldToScreenPoint(v17.vertexLoc));

		//Left Eyebrow
		coords.Add(cameraView.WorldToScreenPoint(v18.vertexLoc));
		coords.Add(cameraView.WorldToScreenPoint(v19.vertexLoc));
		coords.Add(cameraView.WorldToScreenPoint(v20.vertexLoc));
		coords.Add(cameraView.WorldToScreenPoint(v21.vertexLoc));
		coords.Add(cameraView.WorldToScreenPoint(v22.vertexLoc));

		//Right Eyebrow
		coords.Add(cameraView.WorldToScreenPoint(v23.vertexLoc));
		coords.Add(cameraView.WorldToScreenPoint(v24.vertexLoc));
		coords.Add(cameraView.WorldToScreenPoint(v25.vertexLoc));
		coords.Add(cameraView.WorldToScreenPoint(v26.vertexLoc));
		coords.Add(cameraView.WorldToScreenPoint(v27.vertexLoc));

		//Nose Bridge
		coords.Add(cameraView.WorldToScreenPoint(v28.vertexLoc));
		coords.Add(cameraView.WorldToScreenPoint(v29.vertexLoc));
		coords.Add(cameraView.WorldToScreenPoint(v30.vertexLoc));
		coords.Add(cameraView.WorldToScreenPoint(v31.vertexLoc));

		//Nose
		coords.Add(cameraView.WorldToScreenPoint(v32.vertexLoc));
		coords.Add(cameraView.WorldToScreenPoint(v33.vertexLoc));
		coords.Add(cameraView.WorldToScreenPoint(v34.vertexLoc));
		coords.Add(cameraView.WorldToScreenPoint(v35.vertexLoc));
		coords.Add(cameraView.WorldToScreenPoint(v36.vertexLoc));

		//Left Eye
		coords.Add(cameraView.WorldToScreenPoint(v37.vertexLoc));
		coords.Add(cameraView.WorldToScreenPoint(v38.vertexLoc));
		coords.Add(cameraView.WorldToScreenPoint(v39.vertexLoc));
		coords.Add(cameraView.WorldToScreenPoint(v40.vertexLoc));
		coords.Add(cameraView.WorldToScreenPoint(v41.vertexLoc));
		coords.Add(cameraView.WorldToScreenPoint(v42.vertexLoc));

		//Right Eye
		coords.Add(cameraView.WorldToScreenPoint(v43.vertexLoc));
		coords.Add(cameraView.WorldToScreenPoint(v44.vertexLoc));
		coords.Add(cameraView.WorldToScreenPoint(v45.vertexLoc));
		coords.Add(cameraView.WorldToScreenPoint(v46.vertexLoc));
		coords.Add(cameraView.WorldToScreenPoint(v47.vertexLoc));
		coords.Add(cameraView.WorldToScreenPoint(v48.vertexLoc));

		//Mouth Outline
		coords.Add(cameraView.WorldToScreenPoint(v49.vertexLoc));
		coords.Add(cameraView.WorldToScreenPoint(v50.vertexLoc));
		coords.Add(cameraView.WorldToScreenPoint(v51.vertexLoc));
		coords.Add(cameraView.WorldToScreenPoint(v52.vertexLoc));
		coords.Add(cameraView.WorldToScreenPoint(v53.vertexLoc));
		coords.Add(cameraView.WorldToScreenPoint(v54.vertexLoc));
		coords.Add(cameraView.WorldToScreenPoint(v55.vertexLoc));
		coords.Add(cameraView.WorldToScreenPoint(v56.vertexLoc));
		coords.Add(cameraView.WorldToScreenPoint(v57.vertexLoc));
		coords.Add(cameraView.WorldToScreenPoint(v58.vertexLoc));
		coords.Add(cameraView.WorldToScreenPoint(v59.vertexLoc));
		coords.Add(cameraView.WorldToScreenPoint(v60.vertexLoc));

		//Inner Mouth
		coords.Add(cameraView.WorldToScreenPoint(v61.vertexLoc));
		coords.Add(cameraView.WorldToScreenPoint(v62.vertexLoc));
		coords.Add(cameraView.WorldToScreenPoint(v63.vertexLoc));
		coords.Add(cameraView.WorldToScreenPoint(v64.vertexLoc));
		coords.Add(cameraView.WorldToScreenPoint(v65.vertexLoc));
		coords.Add(cameraView.WorldToScreenPoint(v66.vertexLoc));
		coords.Add(cameraView.WorldToScreenPoint(v67.vertexLoc));
		coords.Add(cameraView.WorldToScreenPoint(v68.vertexLoc));
	}

	void updateCoords()
	{
		//Finish Next week
		//Jawline update
		coords [0] = cameraView.WorldToScreenPoint(v1.vertexLoc);
		coords [1] = cameraView.WorldToScreenPoint(v2.vertexLoc);
		coords [2] = cameraView.WorldToScreenPoint(v3.vertexLoc);
		coords [3] = cameraView.WorldToScreenPoint(v4.vertexLoc);
		coords [4] = cameraView.WorldToScreenPoint(v5.vertexLoc);
		coords [5] = cameraView.WorldToScreenPoint(v6.vertexLoc);
		coords [6] = cameraView.WorldToScreenPoint(v7.vertexLoc);
		coords [7] = cameraView.WorldToScreenPoint(v8.vertexLoc);
		coords [8] = cameraView.WorldToScreenPoint(v9.vertexLoc);
		coords [9] = cameraView.WorldToScreenPoint(v10.vertexLoc);
		coords [10] = cameraView.WorldToScreenPoint(v11.vertexLoc);
		coords [11] = cameraView.WorldToScreenPoint(v12.vertexLoc);
		coords [12] = cameraView.WorldToScreenPoint(v13.vertexLoc);
		coords [13] = cameraView.WorldToScreenPoint(v14.vertexLoc);
		coords [14] = cameraView.WorldToScreenPoint(v15.vertexLoc);
		coords [15] = cameraView.WorldToScreenPoint(v16.vertexLoc);
		coords [16] = cameraView.WorldToScreenPoint(v17.vertexLoc);

		//Left Eyebrow
		coords [17] = cameraView.WorldToScreenPoint(v18.vertexLoc);
		coords [18] = cameraView.WorldToScreenPoint(v19.vertexLoc);
		coords [19] = cameraView.WorldToScreenPoint(v20.vertexLoc);
		coords [20] = cameraView.WorldToScreenPoint(v21.vertexLoc);
		coords [21] = cameraView.WorldToScreenPoint(v22.vertexLoc);

		//Right Eyebrow
		coords [22] = cameraView.WorldToScreenPoint(v23.vertexLoc);
		coords [23] = cameraView.WorldToScreenPoint(v24.vertexLoc);
		coords [24] = cameraView.WorldToScreenPoint(v25.vertexLoc);
		coords [25] = cameraView.WorldToScreenPoint(v26.vertexLoc);
		coords [26] = cameraView.WorldToScreenPoint(v27.vertexLoc);

		//Nose Bridge
		coords [27] = cameraView.WorldToScreenPoint(v28.vertexLoc);
		coords [28] = cameraView.WorldToScreenPoint(v29.vertexLoc);
		coords [29] = cameraView.WorldToScreenPoint(v30.vertexLoc);
		coords [30] = cameraView.WorldToScreenPoint(v31.vertexLoc);

		//Nose
		coords [31] = cameraView.WorldToScreenPoint(v32.vertexLoc);
		coords [32] = cameraView.WorldToScreenPoint(v33.vertexLoc);
		coords [33] = cameraView.WorldToScreenPoint(v34.vertexLoc);
		coords [34] = cameraView.WorldToScreenPoint(v35.vertexLoc);
		coords [35] = cameraView.WorldToScreenPoint(v36.vertexLoc);

		//Left Eye
		coords [36] = cameraView.WorldToScreenPoint(v37.vertexLoc);
		coords [37] = cameraView.WorldToScreenPoint(v38.vertexLoc);
		coords [38] = cameraView.WorldToScreenPoint(v39.vertexLoc);
		coords [39] = cameraView.WorldToScreenPoint(v40.vertexLoc);
		coords [40] = cameraView.WorldToScreenPoint(v41.vertexLoc);
		coords [41] = cameraView.WorldToScreenPoint(v42.vertexLoc);

		//Right Eye
		coords [42] = cameraView.WorldToScreenPoint(v43.vertexLoc);
		coords [43] = cameraView.WorldToScreenPoint(v44.vertexLoc);
		coords [44] = cameraView.WorldToScreenPoint(v45.vertexLoc);
		coords [45] = cameraView.WorldToScreenPoint(v46.vertexLoc);
		coords [46] = cameraView.WorldToScreenPoint(v47.vertexLoc);
		coords [47] = cameraView.WorldToScreenPoint(v48.vertexLoc);

		//Mouth Outline
		coords [48] = cameraView.WorldToScreenPoint(v49.vertexLoc);
		coords [49] = cameraView.WorldToScreenPoint(v50.vertexLoc);
		coords [50] = cameraView.WorldToScreenPoint(v51.vertexLoc);
		coords [51] = cameraView.WorldToScreenPoint(v52.vertexLoc);
		coords [52] = cameraView.WorldToScreenPoint(v53.vertexLoc);
		coords [53] = cameraView.WorldToScreenPoint(v54.vertexLoc);
		coords [54] = cameraView.WorldToScreenPoint(v55.vertexLoc);
		coords [55] = cameraView.WorldToScreenPoint(v56.vertexLoc);
		coords [56] = cameraView.WorldToScreenPoint(v57.vertexLoc);
		coords [57] = cameraView.WorldToScreenPoint(v58.vertexLoc);
		coords [58] = cameraView.WorldToScreenPoint(v59.vertexLoc);
		coords [59] = cameraView.WorldToScreenPoint(v60.vertexLoc);

		//Inner Mouth
		coords [60] = cameraView.WorldToScreenPoint(v61.vertexLoc);
		coords [61] = cameraView.WorldToScreenPoint(v62.vertexLoc);
		coords [62] = cameraView.WorldToScreenPoint(v63.vertexLoc);
		coords [63] = cameraView.WorldToScreenPoint(v64.vertexLoc);
		coords [64] = cameraView.WorldToScreenPoint(v65.vertexLoc);
		coords [65] = cameraView.WorldToScreenPoint(v66.vertexLoc);
		coords [66] = cameraView.WorldToScreenPoint(v67.vertexLoc);
		coords [67] = cameraView.WorldToScreenPoint(v68.vertexLoc);
	}

	public void write2DCoords(string fname)
	{
		string fileName = fname;
		string contents = "";

		//Get the contents of the x and y coord.
		for (int i = 0; i < coords.Count; i++) {
			contents += coords[i].x.ToString() + " " + (Screen.height - coords[i].y).ToString() + "\n";
		}

		//Get appropriate file name
		while(File.Exists("/Users/crmbuddy/Desktop/Work/Coords/" + fileName))
		{
			faceNum++;
			fileName = "Face" + faceNum + ".txt";
		}
		//Write to file
		File.WriteAllText ("/Users/crmbuddy/Desktop/Work/Coords/" + fileName, contents);
	}
}