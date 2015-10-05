using UnityEngine;
using System.Collections;

public class GridCubeEvents : MonoBehaviour {

	Transform cube;
	Animator anim;

	// Use this for initialization
	void Start () {
		cube = GetComponent<Transform> ();
		anim = GetComponent<Animator> ();
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnMouseEnter () {
		//Debug.Log ("Mouse on");
		//DestroyObject (this.gameObject);
		//StartCoroutine (CubeRotateCoroutine (180f));

	}


	IEnumerator CubeRotateCoroutine(float _angle) {
		float cr = cube.rotation.z;
		if (cr < _angle) {
			for(float i=cr;i<=_angle;i+=1) {
				Vector3 vec = new Vector3();
				vec.z = i;
				cube.Rotate (vec);
				Debug.Log(cube.rotation.z.ToString());
				yield return new WaitForSeconds(0.001f);
			}

		} else {
			for(float i=cr;i>=_angle;i-=1) {
				Vector3 vec = new Vector3();
				vec.z = i;
				cube.Rotate (vec);
				yield return new WaitForSeconds(0.001f);
			}

		}

	}
}
