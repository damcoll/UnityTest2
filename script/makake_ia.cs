using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class makake_ia : MonoBehaviour {

    float maxDep = 2;
    float posXBase;
    int dir = -1;
    public float vitesse = -0.05f;
    Animator animatio;
    int mort = 0;
    int c = 0;
    public GameObject lui;
    //public GameObject vie;
    public GameObject player;
    float an = 0;
    int block = 0;
    int b = 0;
    // Use this for initialization
	void Start () {
        posXBase = transform.position.x;
        animatio = this.GetComponent<Animator>(); 
	}
	
	// Update is called once per frame
	void Update () {
        if (mort == 1)
        {
            c++;
            if (c >= 40)
                Destroy(lui);
        }
        else if (an >= 1f)
        {
            animatio.SetInteger("annime", 1);
        }
		else if (dir != 0)
        {
            transform.Translate(new Vector3(-vitesse, 0));
            if (transform.position.x >= maxDep + posXBase || transform.position.x <= posXBase - maxDep)
                transform.Rotate(new Vector3(0, 180, 0));
        }
        if (block > 0)
        {
            b++;
            if (b > 40)
            {
                block = 0;
                an = 0;
            }
        }
	}

    void OnTriggerEnter2D(Collider2D other)
    {

        if (other.tag.Equals("player") && other.transform.position.y > this.transform.position.y + 1&& block == 0)
        {
            dead();
        }else if (other.tag.Equals("player"))
        {
            vie.LoosePv();
            if (player.transform.position.x < this.transform.position.x)
            {
                player.GetComponent<Rigidbody2D>().AddForce(new Vector2(-1.5f, 3));
                an = 1;
                block = 1;
                b = 0;
            }
            else if (player.transform.position.x > this.transform.position.x)
            {
                player.GetComponent<Rigidbody2D>().AddForce(new Vector2(1.5f, 3));
                an = 1;
                block = 1;
                b = 0;
            }
        }
    }

   

    public void dead()
    {
        animatio.SetInteger("mort", 1);
        mort = 1;
    }
}
