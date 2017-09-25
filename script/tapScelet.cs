using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class tapScelet : MonoBehaviour {

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
            if (player.transform.position.x < this.transform.position.x)
            {
                player.GetComponent<Rigidbody2D>().AddForce(new Vector2(-1.5f, 3));
            }
            else if (player.transform.position.x > this.transform.position.x)
            {
                player.GetComponent<Rigidbody2D>().AddForce(new Vector2(1.5f, 3));
            }
        }

    }
}
