using UnityEngine;
using System.Collections;

public class GameManager : MonoBehaviour {

    float _r_time;
    public const float _play_time = 30;
    public TimeUI _r_time_ui;
    public GameMessageUI _game_mgr_ui;
    public SphereSizeUI _sphere_size_ui;
    public int _size = 0;
    public SphereOperate _sphere_ope;

    bool result;
    private static GameManager singreton;

    public GameObject _dust_prefab;

    void Awake()
    {
        if (singreton == null)
        {
            singreton = this;
        }
        else {
            Destroy(this);
        }
        Restart();
    }

	// Use this for initialization
	void Start () {
 
	}
    public static GameManager GetSingreton() { return singreton; }
	

	// Update is called once per frame
	void Update () {
        // 時間を引く
        _r_time -= Time.deltaTime;
        if (_r_time < 0) _r_time = 0;

        _r_time_ui.SetRemainingTimeText(_r_time);

        // 開始3秒以内ならGameStart
        if(_r_time >= _play_time - 3){
            _game_mgr_ui.SetMessage(GameMessageUI.Message.START);
        }else if(_r_time > 0){
            _game_mgr_ui.SetMessage(GameMessageUI.Message.NON);
        }else{
            _game_mgr_ui.SetMessage((result) ? GameMessageUI.Message.CLEAR : GameMessageUI.Message.OVER);
            _sphere_ope.Operate(false);
        }

        if (Input.GetKey(KeyCode.R))
        {
            Restart();
        }

        _sphere_size_ui.SetSphereSize(_size);

	}

    public void AddSize(int size) { if(size > 0)_size += size; }
    public int GetSize() { return _size; }

    private void CreateDust(){
        System.Random r = new System.Random((int)Time.time);

        for(int i = 0; i < 40;i++)
        {

            Instantiate(_dust_prefab, new Vector3(r.Next(-15,15), -1.3f, r.Next(-15, 15)), Quaternion.identity);

        }
        
    }

    public void Restart()
    {
        
        GameObject[] dusts = GameObject.FindGameObjectsWithTag("Dust");
        foreach (GameObject dust in dusts)
        {
            Destroy(dust);
        }
        
        
        CreateDust();

        _sphere_ope.Restart();
        _r_time = _play_time;
        result = false;
        _sphere_ope.Operate(true);

    }
}
