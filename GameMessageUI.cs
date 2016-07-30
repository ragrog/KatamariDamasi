using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class GameMessageUI : MonoBehaviour {

    Text _game_message;
    public enum Message{
        START,
        OVER,
        CLEAR,
        NON
    }
	// Use this for initialization
	void Start () {
        _game_message = this.GetComponent<Text>();
        SetMessage(Message.CLEAR);
	}

    public void SetMessage(Message m){
        _game_message.enabled = true;
        switch (m)
        {
            case Message.CLEAR:
                _game_message.text = "GAME CLEAR";
                break;
            case Message.OVER:
                _game_message.text = "GAME OVER";
                break;
            case Message.START:
                _game_message.text = "GAME START";
                break;
            case Message.NON:
                _game_message.enabled = false;
                break;
        }
    }

    
}
