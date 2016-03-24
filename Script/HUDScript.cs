using UnityEngine;
using System.Collections;

public class HUDScript : MonoBehaviour {

    float playerScore = 43f;
    public Transform Player;
	// Use this for initialization

	// Update is called once per frame
	void Update () {
        playerScore += Player.position.x;

	}

    public void IncreaseScore(int amount)
    {
        playerScore += amount;
    }
     void OnDisable()
    {
        PlayerPrefs.SetInt("Score", (int)playerScore);

    }
    void OnGUI()
    {
        GUI.Label(new Rect(10, 10, 100, 30), "Score: " + (int) (playerScore));
    }

 
}
