using UnityEngine;
using System.Collections;

public class SphereCenter : MonoBehaviour {

    public Transform _sphere;
	// Use this for initialization
	
	// Update is called once per frame
	void Update () {
        this.transform.position = _sphere.transform.position;
	}
}
