using UnityEngine;
using System.Collections;

public class SphereOperate : MonoBehaviour {

    public float _thrust = 0.001f;
    public Rigidbody _myrb;
    public Transform _center;
    public Transform _sphere;
    public bool _operate;

    float angle = 0;

	// Use this for initialization
	void Start () {
        _myrb = this.GetComponent<Rigidbody>();
	}
	
	// Update is called once per frame
	void Update () {
        if (_operate)
        {
            if (Input.GetKey(KeyCode.Space)) {
                this.GetComponent<Rigidbody>().AddForce(
                _center.forward / _thrust, 
                ForceMode.VelocityChange);
                //_myrb.velocity = _thrust * _center.forward;
            }
            if (Input.GetKeyUp(KeyCode.Space))
            {
                //_myrb.velocity = Vector3.zero;
                //_myrb.angularVelocity = Vector3.zero;   
            }

            if (Input.GetKey(KeyCode.LeftArrow)){
                angle -= 3f;
                angle %= 360.0f;
                _center.rotation = Quaternion.Euler(0, angle, 0);
            }
            if (Input.GetKey(KeyCode.RightArrow)){
                angle += 3f;
                angle %= 360.0f;
                _center.rotation = Quaternion.Euler(0, angle, 0);
            }
        }

    }
    public void Restart()
    {
        _sphere.transform.position = new Vector3(0,2.3f,0);
    }
    public void Operate(bool operate)
    {
        if (!operate)
        {
            _myrb.velocity = Vector3.zero;
            _myrb.angularVelocity = Vector3.zero;

        }
        _operate = operate;
    }
}
