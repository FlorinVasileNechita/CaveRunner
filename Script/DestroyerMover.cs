using UnityEngine;
using System.Collections;

public class DestroyerMover : MonoBehaviour
{
    public Transform Player;
    void Update()
    {
        transform.position = new Vector3(Player.position.x + 2, 0, -10);
    }
    
}
