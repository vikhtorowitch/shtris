using UnityEngine;
using System.Collections;

public class SceneInit : MonoBehaviour {

	public GameObject drawcube;

	// Use this for initialization
	void Start () {
		Vector3 vec;
		Quaternion rot;
		rot.w = 0;
		rot.x = 0;
		rot.y = 0;
		rot.z = 0;

		for (int y=1; y<31; y++)
			for (int x=1; x<16; x++) {
				vec.x = x*0.7f;
				vec.y = 2;
				vec.z = y*0.7f;
				Instantiate(drawcube, vec, rot);
			}
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
