using UnityEngine;
using System.Collections;

public class GameOverScript : MonoBehaviour {

    int score = 0;
	
	// Update is called once per frame
	void Start () {
        score = PlayerPrefs.GetInt("Score");
	}

    void OnGUI()
    {

        
        GUI.Label(new Rect(Screen.width / 2 - 40, 300, 100, 100), "Score: " + score);

        if(GUI.Button(new Rect(Screen.width / 2 - 40, 400, 80, 30), "Retry"))
        {
            Application.LoadLevel(1);
        }
    }
}
