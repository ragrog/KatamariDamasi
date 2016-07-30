using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class SphereSizeUI : MonoBehaviour {

    Text _size;
	// Use this for initialization
	void Start () {
        _size = this.GetComponent<Text>();
	}
	
	// Update is called once per frame
	void Update () {
    }
    public void SetSphereSize(int size){
        _size.text = (size).ToString("00m00cm00mm");
    }
    
}
