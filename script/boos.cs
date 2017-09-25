using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class boos : MonoBehaviour {
    public GameObject lui;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    public void lancement()
    {
        lui.GetComponent<Animator>().SetInteger("go", 1);
    }
}
