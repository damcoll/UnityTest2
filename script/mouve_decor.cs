using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mouve_decor : MonoBehaviour
{
    float x;
    float f = 1;
    int dir = 1;
    // Use this for initialization
    void Start()
    {
        x = transform.position.x;
    }

    // Update is called once per frame
    void Update()
    {
     
        if (transform.position.x > x - 2)
            dir = -1;
        else if (transform.position.x < x + 2)
            dir = 1;

        this.GetComponent<Rigidbody2D>().AddForce(new Vector2(dir * f, 0));
    }
}
