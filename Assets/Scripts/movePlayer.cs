using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class movePlayer : MonoBehaviour
{
    // Start is called before the first frame update
    public Rigidbody2D detective;
    public static Vector2 PlayerVector;
    public static string fromLocation ;
    public void move_Player()
    {
        
        if (detective == null)
        {
            detective = GameObject.Find("Detective Variant").GetComponent<Rigidbody2D>();
        }
        if (detective == null)
        {
            detective = GameObject.Find("Detective").GetComponent<Rigidbody2D>();
        }
        detective.position = PlayerVector;

    }
}
