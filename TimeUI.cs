using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class TimeUI : MonoBehaviour {

    Text _r_text;

	// Use this for initialization
	void Start () {
        _r_text = this.GetComponent<Text>();
	}
    public void SetRemainingTimeText(float time){
        _r_text.text = ((int)time / 60).ToString("D2") + ":" + (time % 60).ToString("F");
    }
}
