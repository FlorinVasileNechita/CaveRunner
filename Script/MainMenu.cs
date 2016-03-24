using UnityEngine;
using System.Collections;

public class MainMenu : MonoBehaviour {


	void OnGUI () {
        if (GUI.Button(new Rect(Screen.width / 2 - 40, 400, 80, 30), "Start Game"))
        {
            Application.LoadLevel(1);
        }
    }
}
