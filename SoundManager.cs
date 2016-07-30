using UnityEngine;
using System.Collections;

public class SoundManager : MonoBehaviour {

    public AudioClip _dust_se;
    public AudioSource _dust_as;
    static private SoundManager _singreton;

    void Awake()
    {
        if(_singreton == null)
        {
            _singreton = this;
        }
        else
        {
            Destroy(this);
        }
    }
    static public SoundManager GetSingreton()
    {
        return _singreton;
    }
	// Use this for initialization
	void Start () {
        _dust_as = this.GetComponent<AudioSource>();
	}
	
    public void PlayDusetSe()
    {
        _dust_as.PlayOneShot(_dust_se);
    }
	// Update is called once per frame
	void Update () {
	
	}

    
}
