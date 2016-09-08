using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using System.IO;

public class SetWeights : MonoBehaviour {
	int blendShapeCount;
	SkinnedMeshRenderer skinnedMeshRenderer;
	Mesh skinnedMesh;
	int incrementor = 0;

	//public TextAsset faceTextFile;
	//private string theWholeFileAsOneLongString;
	private List<string> eachLine;
	private List<string> inputs = new List<string>();
	public string directoryPath;

	// Use this for initialization
	void Awake ()
	{
		skinnedMeshRenderer = GetComponent<SkinnedMeshRenderer> ();
		skinnedMesh = GetComponent<SkinnedMeshRenderer> ().sharedMesh;
	}
	// Use this for initialization
	void Start () {
		readFiles ();

		InvokeRepeating ("setBlendShapes", 0, 0.033f); //Time is 0.033 so that it will do 30 faces in 1 second
		/*theWholeFileAsOneLongString = faceTextFile.text;

		eachLine = new List<string>();
		eachLine.AddRange(theWholeFileAsOneLongString.Split("\n"[0]) );

		blendShapeCount = skinnedMesh.blendShapeCount; 

		for (int i = 0; i < blendShapeCount; i++) {
			skinnedMeshRenderer.SetBlendShapeWeight (i, float.Parse(eachLine[i]));
		}*/
	}
	
	// Update is called once per frame
	void Update () {
	
	}
		
	//Reads in all the values into long strings that are saved into the inputs List. 
	private void readFiles()
	{
		var info = new DirectoryInfo (directoryPath);
		var fileInfo = info.GetFiles ();
		foreach (FileInfo file in fileInfo)
		{
			string f = file.FullName;
			if(f.EndsWith(".txt"))
			{
				inputs.Add (File.ReadAllText (f));
			}
		}
	}

	//Uses incrementor, don't change incrementor variable in any other methods.
	//Goes through a single file saved in the inputs List. Will work down input list if called 
	//in succession
	private void setBlendShapes()
	{
		if (incrementor < inputs.Count) {
			eachLine = new List<string> ();
			eachLine.AddRange (inputs [incrementor].Split ("\n" [0]));

			blendShapeCount = skinnedMesh.blendShapeCount; 
			for (int i = 0; i < blendShapeCount; i++) {
				skinnedMeshRenderer.SetBlendShapeWeight (i, float.Parse (eachLine [i]));
			}
			incrementor++;
		}
	}
}
