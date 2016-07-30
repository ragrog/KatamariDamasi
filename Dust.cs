using UnityEngine;
using System.Collections;

public class Dust : MonoBehaviour {

    int _size = 1;
    int _sphere_size = 0;
    // Use this for initialization
    void Start() {

    }

    // Update is called once per frame
    void Update() {

    }
    void OnTriggerEnter(Collider other)
    {
        if(_size > _sphere_size)
        {
            this.transform.parent = other.transform;
               Destroy(this.GetComponent<Collider>());
        // this.GetComponent<Collider>().isTrigger = true;
            GameManager.GetSingreton().AddSize(_size);
            SoundManager.GetSingreton().PlayDusetSe();
        }
    }
}
