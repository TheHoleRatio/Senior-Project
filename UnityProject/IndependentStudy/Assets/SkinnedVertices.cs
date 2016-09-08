﻿/**using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class SkinnedVertices : MonoBehaviour
{
	Mesh mesh;

	class Bone
	{
		internal Transform bone;
		internal float weight;
		internal Vector3 delta;
	}
	List<Bone> allBones = new List<Bone>();

	void Start()
	{
		SkinnedMeshRenderer skin = GetComponent(typeof(SkinnedMeshRenderer)) as SkinnedMeshRenderer;
		mesh = skin.sharedMesh;

		Debug.Log("{0} vertices, {1} weights, {2} bones",
			mesh.vertexCount, mesh.boneWeights.Length, skin.bones.Length);

		for (int i = 0; i < mesh.vertexCount; i++)
		{
			Vector3 position = mesh.vertices;
			position = transform.TransformPoint(position);

			BoneWeight weights = mesh.boneWeights;
			int[] boneIndices = new int[] { weights.boneIndex0, weights.boneIndex1, weights.boneIndex2, weights.boneIndex3 };
			float[] boneWeights = new float[] { weights.weight0, weights.weight1, weights.weight2, weights.weight3 };

			List<Bone> bones = new List<Bone>();
			allBones.Add(bones);

			for (int j = 0; j < 4; j++)
			{
				if (boneWeights > 0)
				{
					Bone bone = new Bone();
					bones.Add(bone);

					bone.bone = skin.bones[boneIndices];
					bone.weight = boneWeights;
					bone.delta = bone.bone.InverseTransformPoint(position);
				}
			}

			//if (bones.Count > 1)
			//{
			//    string msg = string.Format("vertex {0}, {1} bones", i, bones.Count);

			//    foreach (Bone bone in bones)
			//        msg += string.Format("\n\t{0} => {1} => {2}", bone.bone.name, bone.weight, bone.delta);

			//    Debug.Log(msg);
			//}
		}
	}

	void OnDrawGizmos()
	{
		if (Application.isPlaying)
		{
			for (int i = 0; i < mesh.vertexCount; i++)
			{
				List bones = allBones;

				Vector3 position = Vector3.zero;
				foreach (Bone bone in bones)
					position += bone.bone.TransformPoint(bone.delta) * bone.weight;

				int boneCount = bones.Count;
				Gizmos.color = (boneCount == 4) ? Color.red :
					(boneCount == 3) ? Color.blue :
					(boneCount == 2) ? Color.green : Color.black;

				Gizmos.DrawWireCube(position, boneCount * 0.05f * Vector3.one);

				Vector3 normal = Vector3.zero;
				foreach (Bone bone in bones)
					normal += bone.bone.TransformDirection(mesh.normals) * bone.weight;

				Gizmos.DrawRay(position, normal);
			}
		}
	}
}
**/