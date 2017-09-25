using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class scellette : MonoBehaviour
{

    public GameObject lui;
    public float vitesse = 0.001f;
    bool tap = false;
    GameObject player;
    int c;
    bool cour = false;
    float x;
    float y;
    int dir = -1;
    int b;

    // Use this for initialization
    void Start()
    {
        x = transform.position.x;
        y = transform.position.y;
        b = 0;
    }

    // Update is called once per frame
    void Update()
    {

        if (cour)
        {

            lui.GetComponent<Rigidbody2D>().AddForce(new Vector2(1f * dir, 0));
            if (c >= 30)
            {
                cour = false;
                lui.GetComponent<Animator>().SetInteger("dance", 0);
                lui.GetComponent<Animator>().SetInteger("go", 0);
                lui.GetComponent<Animator>().SetInteger("tap", 1);
                tap = true;
                c = 0;
            }
            c++;
        }
        else if (tap)
        {
            if (c >= 30)
            {
                lui.GetComponent<Animator>().SetInteger("tap", 0);
                tap = false;
                c = 0;
            }
            c++;
        }else if (dir != 0){
            transform.Translate(new Vector3(-vitesse, 0));
            
            if (transform.position.x >= 2 + x || transform.position.x <= 2 - 5)
            {
                if (b > 20)
                {
                    transform.Rotate(new Vector3(0, 180, 0));
                    dir *= -1;
                    b = 0;
                }
            }
        }
        else
        {
            lui.GetComponent<Rigidbody2D>().AddForce(new Vector2(dir * 0.5f, 0));
            lui.GetComponent<Animator>().SetInteger("dance", 0);
        }
        b++;
    }
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag.Equals("player"))
        {
            lui.GetComponent<Animator>().SetInteger("go", 1);
            cour = true;
            c = 0;
        }

    }

}
