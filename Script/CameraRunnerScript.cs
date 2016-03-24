using UnityEngine;
using System.Collections;

public class CameraRunnerScript : MonoBehaviour {
    public Transform Player;

	
	// Update is called once per frame
	void Update () {
         transform.position = new Vector3(Player.position.x + 2, Player.position.y, -10);
       // transform.position = new Vector3(Player.position.x + 2,0, -10);
    }

}


