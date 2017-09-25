using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mouve : MonoBehaviour
{
    public Animator test;
     float vitesse = -0.1f;
    float saut = 14f;
    int dir = 1;
    int change = 0;
    int bond = 0;
    // Use this for initialization
    void Start()
    {
        PlayerPrefs.SetInt("ptsTotal", 0);
        PlayerPrefs.SetInt("ptsGagner", 0);
    }

    // Update is called once per frame
    void Update()
    {

        if (Input.GetAxis("Horizontal") < 0)
        {
            test.SetInteger("Animation", 1);
            if (dir != 1)
                change = 1;
            dir = 1;

        }
        else if (Input.GetAxis("Horizontal") < 0)
            test.SetInteger("Animation", 0);

        else if (Input.GetAxis("Horizontal") > 0)
        {
            test.SetInteger("Animation", 1);
            if (dir != -1)
                change = 1;
            dir = -1;
        }
        else if (Input.GetAxis("Horizontal") > 0)
        {
            test.SetInteger("Animation", 0);
        }
        if (Input.GetAxis("Horizontal") != 0)
        {
            this.transform.Translate(new Vector3(vitesse, 0));
            
        }
        if (Input.GetButtonDown("Jump") && bond == 1)
        {
            GetComponent<Rigidbody2D>().AddForce(new Vector2(0,saut));
            
        }
        if (Input.GetButtonDown("Jump") && bond == 0)
        {
            GetComponent<Rigidbody2D>().AddForce(new Vector2(0, saut + 2f));
            bond = -1;
        }
        if (change != 0)
        {
            this.transform.Rotate(new Vector3(0, 180));
            change = 0;    
        }
    }
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag.Equals("sol"))
        {
            bond = 1;
        }

    }
    void OnTriggerExit2D(Collider2D other)
    {
        if (other.tag.Equals("sol"))
        {
            bond = 0;
        }
    }
}
