using UnityEngine;
using System.Collections;

public class SpawnScript : MonoBehaviour {
    public GameObject[] obj;       //Array of game objects to spawn
    public float spawnMin = 0.5f; //Minimum time to spawn a prefab
    public float spawnMax = 1.5f; //Maximum time to spawn a prefab
	// Use this for initialization
	void Start () {
        spawn();
	}
	
void spawn()
    {
        Instantiate(obj[Random.Range(0, obj.Length)], transform.position, Quaternion.identity); 
        Invoke("spawn", Random.Range(spawnMin, spawnMax));
    }
}
