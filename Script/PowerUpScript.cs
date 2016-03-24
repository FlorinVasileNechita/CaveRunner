using UnityEngine;
using System.Collections;

public class PowerUpScript : MonoBehaviour {
    public int points;
    HUDScript hud;

    void OnTriggerEnter2D(Collider2D other)
    {
        if(other.tag == "Player")
        {
            hud = GameObject.Find("Main Camera").GetComponent<HUDScript>();
            hud.IncreaseScore(points);
            Destroy(this.gameObject);
        }
    }

}
