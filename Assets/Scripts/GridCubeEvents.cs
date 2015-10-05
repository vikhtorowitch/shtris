using UnityEngine;
using System.Collections;

public class GridCubeEvents : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnMouseEnter () {
		Debug.Log ("Mouse on");
		//DestroyObject (this.gameObject);
	}
}
