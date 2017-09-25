using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class missile : MonoBehaviour
{
    int t = 0;
    public GameObject lui;
    int u = 0;
    // Use this for initialization
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        t++;
        if (t > 20)
            this.GetComponent<Animator>().SetInteger("boom", 1);
        if (t > 30)
            Destroy(lui);
    }
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag.Equals("player") && u == 0)
        {
            vie.LoosePv();
            this.GetComponent<Animator>().SetInteger("boom", 1);
            u = 1;
        }
        
    }
}
