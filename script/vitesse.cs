using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class vitesse : MonoBehaviour
{

    GameObject player;
    static bool go = false;


    // Use this for initialization
    void Start()
    {
        player = GameObject.FindGameObjectWithTag("player");
    }

    // Update is called once per frame
    void Update()
    {
        if (go) player.GetComponent<Rigidbody2D>().AddForce(new Vector2(0, -5f));
    }
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag.Equals("player")) ;
            
    }
}
