using UnityEngine;
using System.IO;
using System.Collections;
using System.Collections.Generic;

public class SetWeights_Random : MonoBehaviour {
	int blendShapeCount;
	SkinnedMeshRenderer skinnedMeshRenderer;
	Mesh skinnedMesh;
	static int faceNum = 0;
	static int photoNum = 0;
	VertexCreate2 coords;

	public TextAsset faceTextFile;
	private string theWholeFileAsOneLongString;
	private List<string> eachLine;

	// Use this for initialization
	void Awake ()
	{
		skinnedMeshRenderer = GetComponent<SkinnedMeshRenderer> ();
		skinnedMesh = GetComponent<SkinnedMeshRenderer> ().sharedMesh;
		coords = GetComponent<VertexCreate2> ();
	}

	// Use this for initialization
	void Start () {

		/**
		 * Unnecessary old code.
		 * */
		//theWholeFileAsOneLongString = faceTextFile.text;

		//eachLine = new List<string>();
		//eachLine.AddRange(theWholeFileAsOneLongString.Split("\n"[0]) );

		blendShapeCount = skinnedMesh.blendShapeCount;
		InvokeRepeating ("RandomFace2", 1f, 1f);
		InvokeRepeating ("takeSnapshot", 1.1f, 1f);
	}
	
	// Update is called once per frame
	void Update () {
	}

	/*
	 * Old randomization technique with no real bias
	 * Use Random Face 2 for more realistic expressions
	 * */
	//Randomize all values without expression bias
	void RandomFace() {
		for (int i = 0; i < blendShapeCount; i++) {
			float dochange = Random.Range (0f, 100f);
			if (dochange > 60f) {
				float r = Random.Range (0f, 35f);
				skinnedMeshRenderer.SetBlendShapeWeight (i, r);
			} else {
				skinnedMeshRenderer.SetBlendShapeWeight (i, 0.0f);
			}
		}
	}

	void RandomFace2() {
		clearFace(); //Reset blendspace weights
		float faceIndex = Random.Range(0, 8); //Generate random expression index
		if (faceIndex == 0) {
			//Surprised
			skinnedMeshRenderer.SetBlendShapeWeight (8, Random.Range (50f, 100f));
			skinnedMeshRenderer.SetBlendShapeWeight (9, Random.Range (50f, 100f));
			skinnedMeshRenderer.SetBlendShapeWeight (12, Random.Range (50f, 100f));
			skinnedMeshRenderer.SetBlendShapeWeight (13, Random.Range (50f, 100f));
			skinnedMeshRenderer.SetBlendShapeWeight (22, Random.Range (25f, 75f));
			skinnedMeshRenderer.SetBlendShapeWeight (32, Random.Range (0f, 25f));
			skinnedMeshRenderer.SetBlendShapeWeight (33, Random.Range (0f, 25f));
			skinnedMeshRenderer.SetBlendShapeWeight (34, Random.Range (25f, 75f));
			skinnedMeshRenderer.SetBlendShapeWeight (35, Random.Range (75f, 100f));
		} else if (faceIndex == 1) {
			//Silly
			if (Random.Range (0, 2) == 0) {
				skinnedMeshRenderer.SetBlendShapeWeight (0, Random.Range (50f, 100f));
				skinnedMeshRenderer.SetBlendShapeWeight (2, Random.Range (50f, 100f));
				skinnedMeshRenderer.SetBlendShapeWeight (9, Random.Range (50f, 100f));
				skinnedMeshRenderer.SetBlendShapeWeight (13, Random.Range (50f, 100f));
			} else {
				skinnedMeshRenderer.SetBlendShapeWeight (1, Random.Range (50f, 100f));
				skinnedMeshRenderer.SetBlendShapeWeight (3, Random.Range (50f, 100f));
				skinnedMeshRenderer.SetBlendShapeWeight (8, Random.Range (50f, 100f));
				skinnedMeshRenderer.SetBlendShapeWeight (12, Random.Range (50f, 100f));
			}
			skinnedMeshRenderer.SetBlendShapeWeight (17, Random.Range (25f, 75f));
			skinnedMeshRenderer.SetBlendShapeWeight (26, Random.Range (15f, 75f));
			skinnedMeshRenderer.SetBlendShapeWeight (27, Random.Range (25f, 75f));
			skinnedMeshRenderer.SetBlendShapeWeight (35, Random.Range (50f, 100f));
			skinnedMeshRenderer.SetBlendShapeWeight (36, Random.Range (0f, 50f));
			skinnedMeshRenderer.SetBlendShapeWeight (41, Random.Range (50f, 100f));
			skinnedMeshRenderer.SetBlendShapeWeight (42, Random.Range (50f, 100f));
			skinnedMeshRenderer.SetBlendShapeWeight (45, Random.Range (50f, 100f));
		} else if (faceIndex == 2) {
			//Angry
			skinnedMeshRenderer.SetBlendShapeWeight (2, Random.Range (50f, 100f));
			skinnedMeshRenderer.SetBlendShapeWeight (3, Random.Range (50f, 100f));
			skinnedMeshRenderer.SetBlendShapeWeight (4, Random.Range (50f, 100f));
			skinnedMeshRenderer.SetBlendShapeWeight (5, Random.Range (50f, 100f));
			skinnedMeshRenderer.SetBlendShapeWeight (12, Random.Range (50f, 100f));
			skinnedMeshRenderer.SetBlendShapeWeight (13, Random.Range (50f, 100f));
			skinnedMeshRenderer.SetBlendShapeWeight (14, Random.Range (25f, 75f));
			skinnedMeshRenderer.SetBlendShapeWeight (15, Random.Range (25f, 75f));
			skinnedMeshRenderer.SetBlendShapeWeight (25, Random.Range (25f, 75f));
			skinnedMeshRenderer.SetBlendShapeWeight (28, Random.Range (50f, 100f));
			skinnedMeshRenderer.SetBlendShapeWeight (33, Random.Range (0f, 45f));
			skinnedMeshRenderer.SetBlendShapeWeight (34, Random.Range (0f, 45f));
			skinnedMeshRenderer.SetBlendShapeWeight (39, Random.Range (25f, 50f));
			skinnedMeshRenderer.SetBlendShapeWeight (40, Random.Range (25f, 50f));
			skinnedMeshRenderer.SetBlendShapeWeight (46, Random.Range (50f, 100f));
		} else if (faceIndex == 3) {
			//Happy
			skinnedMeshRenderer.SetBlendShapeWeight (6, Random.Range (50f, 100f));
			skinnedMeshRenderer.SetBlendShapeWeight (7, Random.Range (50f, 100f));
			skinnedMeshRenderer.SetBlendShapeWeight (8, Random.Range (25f, 75f));
			skinnedMeshRenderer.SetBlendShapeWeight (9, Random.Range (25f, 75f));
			skinnedMeshRenderer.SetBlendShapeWeight (10, Random.Range (25f, 50f));
			skinnedMeshRenderer.SetBlendShapeWeight (11, Random.Range (25f, 50f));
			skinnedMeshRenderer.SetBlendShapeWeight (12, Random.Range (50f, 100f));
			skinnedMeshRenderer.SetBlendShapeWeight (13, Random.Range (50f, 100f));
			skinnedMeshRenderer.SetBlendShapeWeight (5, Random.Range (50f, 100f));
			skinnedMeshRenderer.SetBlendShapeWeight (17, Random.Range (0f, 50f));
			skinnedMeshRenderer.SetBlendShapeWeight (28, Random.Range (0f, 45f));
			skinnedMeshRenderer.SetBlendShapeWeight (36, Random.Range (50f, 100f));
			skinnedMeshRenderer.SetBlendShapeWeight (41, Random.Range (50f, 100f));
			skinnedMeshRenderer.SetBlendShapeWeight (42, Random.Range (50f, 100f));
		} else if (faceIndex == 4) {
			//Sad
			skinnedMeshRenderer.SetBlendShapeWeight (0, Random.Range (0f, 20f));
			skinnedMeshRenderer.SetBlendShapeWeight (1, Random.Range (0f, 20f));
			skinnedMeshRenderer.SetBlendShapeWeight (4, Random.Range (50f, 100f));
			skinnedMeshRenderer.SetBlendShapeWeight (5, Random.Range (50f, 100f));
			skinnedMeshRenderer.SetBlendShapeWeight (6, Random.Range (50f, 100f));
			skinnedMeshRenderer.SetBlendShapeWeight (7, Random.Range (50f, 100f));
			skinnedMeshRenderer.SetBlendShapeWeight (8, Random.Range (25f, 75f));
			skinnedMeshRenderer.SetBlendShapeWeight (9, Random.Range (25f, 75f));
			skinnedMeshRenderer.SetBlendShapeWeight (14, Random.Range (50f, 100f));
			skinnedMeshRenderer.SetBlendShapeWeight (15, Random.Range (50f, 100f));
			skinnedMeshRenderer.SetBlendShapeWeight (16, Random.Range (25f, 75f));
			skinnedMeshRenderer.SetBlendShapeWeight (25, Random.Range (0f, 50f));
			skinnedMeshRenderer.SetBlendShapeWeight (29, Random.Range (50f, 100f));
			skinnedMeshRenderer.SetBlendShapeWeight (36, Random.Range (0f, 45f));
			skinnedMeshRenderer.SetBlendShapeWeight (46, Random.Range (0f, 50f));
		} else if (faceIndex == 5) {
			//Disgusted
			skinnedMeshRenderer.SetBlendShapeWeight (2, Random.Range (50f, 100f));
			skinnedMeshRenderer.SetBlendShapeWeight (3, Random.Range (50f, 100f));
			skinnedMeshRenderer.SetBlendShapeWeight (4, Random.Range (50f, 100f));
			skinnedMeshRenderer.SetBlendShapeWeight (5, Random.Range (50f, 100f));
			skinnedMeshRenderer.SetBlendShapeWeight (6, Random.Range (50f, 100f));
			skinnedMeshRenderer.SetBlendShapeWeight (7, Random.Range (50f, 100f));
			skinnedMeshRenderer.SetBlendShapeWeight (14, Random.Range (50f, 100f));
			skinnedMeshRenderer.SetBlendShapeWeight (15, Random.Range (50f, 100f));
			skinnedMeshRenderer.SetBlendShapeWeight (35, Random.Range (10f, 50f));
			skinnedMeshRenderer.SetBlendShapeWeight (39, Random.Range (50f, 100f));
			skinnedMeshRenderer.SetBlendShapeWeight (40, Random.Range (50f, 100f));
		} else if (faceIndex == 6) {
			//Nervous
			skinnedMeshRenderer.SetBlendShapeWeight (6, Random.Range (50f, 100f));
			skinnedMeshRenderer.SetBlendShapeWeight (7, Random.Range (50f, 100f));
			skinnedMeshRenderer.SetBlendShapeWeight (8, Random.Range (25f, 50f));
			skinnedMeshRenderer.SetBlendShapeWeight (9, Random.Range (25f, 50f));
			skinnedMeshRenderer.SetBlendShapeWeight (12, Random.Range (50f, 100f));
			skinnedMeshRenderer.SetBlendShapeWeight (13, Random.Range (50f, 100f));
			skinnedMeshRenderer.SetBlendShapeWeight (14, Random.Range (25f, 50f));
			skinnedMeshRenderer.SetBlendShapeWeight (15, Random.Range (25f, 50f));
			skinnedMeshRenderer.SetBlendShapeWeight (25, Random.Range (50f, 100f));
			skinnedMeshRenderer.SetBlendShapeWeight (28, Random.Range (50f, 100f));
			skinnedMeshRenderer.SetBlendShapeWeight (33, Random.Range (25f, 50f));
			skinnedMeshRenderer.SetBlendShapeWeight (34, Random.Range (25f, 50f));
			skinnedMeshRenderer.SetBlendShapeWeight (46, Random.Range (50f, 100f));
		} else if (faceIndex == 7) {
			//Jawline adjustment
			if (Random.Range (0, 2) == 0) {
				skinnedMeshRenderer.SetBlendShapeWeight (2, Random.Range (10f, 40f));
				skinnedMeshRenderer.SetBlendShapeWeight (9, Random.Range (50f, 100f));
				skinnedMeshRenderer.SetBlendShapeWeight (13, Random.Range (50f, 100f));
				skinnedMeshRenderer.SetBlendShapeWeight (18, Random.Range (20f, 60f));
				skinnedMeshRenderer.SetBlendShapeWeight (21, Random.Range (50f, 100f));
				skinnedMeshRenderer.SetBlendShapeWeight (33, Random.Range (25f, 50f));
				skinnedMeshRenderer.SetBlendShapeWeight (34, Random.Range (25f, 50f));
				skinnedMeshRenderer.SetBlendShapeWeight (35, Random.Range (50f, 100f));
				skinnedMeshRenderer.SetBlendShapeWeight (43, Random.Range (10f, 30f));
			} else {
				skinnedMeshRenderer.SetBlendShapeWeight (3, Random.Range (10f, 40f));
				skinnedMeshRenderer.SetBlendShapeWeight (8, Random.Range (50f, 100f));
				skinnedMeshRenderer.SetBlendShapeWeight (12, Random.Range (50f, 100f));
				skinnedMeshRenderer.SetBlendShapeWeight (17, Random.Range (20f, 60f));
				skinnedMeshRenderer.SetBlendShapeWeight (20, Random.Range (50f, 100f));
				skinnedMeshRenderer.SetBlendShapeWeight (33, Random.Range (50f, 100f));
				skinnedMeshRenderer.SetBlendShapeWeight (34, Random.Range (25f, 50f));
				skinnedMeshRenderer.SetBlendShapeWeight (35, Random.Range (50f, 100f));
				skinnedMeshRenderer.SetBlendShapeWeight (44, Random.Range (10f, 30f));
			}
		}
		writeWeightsToFile ();
	}

	void clearFace()
	{
		for (int i = 0; i < blendShapeCount; i++) {
			skinnedMeshRenderer.SetBlendShapeWeight (i, 0);
		}
	}

	public void writeWeightsToFile()
	{
		string fileName = "Face" + faceNum + ".txt";
		string contents = "";

		//Get weights and have one per line
		for (int i = 0; i < 50; i++) {
			contents += skinnedMeshRenderer.GetBlendShapeWeight (i) + "\n";
		}
		//Get appropriate file name
		while(File.Exists("/Users/crmbuddy/Desktop/Work/Values/" + fileName))
			{
				faceNum++;
				fileName = "Face" + faceNum + ".txt";
			}
		//Write to file
		File.WriteAllText ("/Users/crmbuddy/Desktop/Work/Values/" + fileName, contents);
		writeCoords (fileName);
		faceNum++;
	}

	void takeSnapshot()
	{
		string fileName = "Faceshot" + photoNum + ".png";
		//Get appropriate file name
		while(File.Exists("/Users/crmbuddy/Desktop/Work/Images/" + fileName))
		{
			photoNum++;
			fileName = "Faceshot" + photoNum + ".png";
		}
		string path = "/Users/crmbuddy/Desktop/Work/Images/" + fileName;
		print (path);
		Application.CaptureScreenshot(path);
	}

	void writeCoords(string name)
	{
		coords.write2DCoords(name);
		coords.TransformVerts ();
	}
		
}