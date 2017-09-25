using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouveGranPaleteBas : MonoBehaviour {

    public GameObject lui;

    float y;
    public float dessante = 0.2f;
    float yMAx;
    int dir = 1;
    // Use this for initialization
    void Start()
    {
        y = transform.position.y;
        yMAx = y - dessante;
    }

    // Update is called once per frame
    void Update()
    {
        lui.transform.Translate(new Vector2(0, 0.05f * dir));
        if (transform.position.y < yMAx)
            dir = 1;
        if (transform.position.y > y)
            dir = -1;
    }
}
