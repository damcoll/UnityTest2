using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class piege : MonoBehaviour {

    GameObject player;
	// Use this for initialization
	void Start () {
		player = GameObject.FindGameObjectWithTag("player");
    }
	
	// Update is called once per frame
	void Update () {
		
	}
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag.Equals("player"))
        {
            vie.LoosePv();
            player.GetComponent<Rigidbody2D>().AddForce(new Vector2(0, 2f));
        }

    }
}
