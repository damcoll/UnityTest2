using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class sacDePIeces : MonoBehaviour
{


    GameObject player;
    public GameObject spone;
    public GameObject pieces;
    public GameObject lui;
    int nbpieces = 10;
    int p = 0;
    bool poof = true;
    int t;
    // Use this for initialization
    void Start()
    {
        player = GameObject.FindGameObjectWithTag("player");
        t = 0;
    }

    // Update is called once per frame
    void Update()
    {
        if (nbpieces ==  0)
            Destroy(lui);
        if(p == 1)
        {
            GameObject piece = Instantiate(pieces, spone.transform);
           //    piece.GetComponent<Rigidbody2D>().AddForce(new Vector2(2f, 2f));
            p = 0;
        }
        if (t > 10)
            poof = true;
        t++;
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag.Equals("player") && nbpieces > 0 && poof)
        {
            player.GetComponent<Rigidbody2D>().AddForce(new Vector2(-2f, 14f));
            p = 1;
            nbpieces--;
            poof = false;
            t = 0;
        }
    }
}
