using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class discussion : MonoBehaviour {

    public GameObject scripte;
    public Text text;
    public GameObject fondText;
    int aff = -1;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (aff == 0)
        {
            text.text = "B";
        }else if (aff == 10)
        {
            text.text += "o";
        }
        else if (aff == 20)
        {
            text.text += "n";
        }
        else if (aff == 40)
        {
            text.text += "j";
        }
        else if (aff == 60)
        {
            text.text += "o";
        }
        else if (aff == 80)
        {
            text.text += "u";
        }
        else if (aff == 100)
        { 
            text.text += "r";
        }
        else if (aff == 120)
        {
            text.text += " ";
        }
        else if (aff == 140)
        {
            text.text += "t";
        }
        else if (aff == 160)
        {
            text.text += "u";
        }
        else if (aff == 180)
        {
            text.text += " ";
        }
        else if (aff == 200)
        {
            text.text += "e";
        }
        else if (aff == 220)
        {
            text.text += "s";
        }
        else if (aff == 240)
        {
            text.text += " ";
        }
        else if (aff == 260)
        {
            text.text += "l";
        }
        else if (aff == 280)
        {
            text.text += "e";
        }
        else if (aff == 300)
        {
            text.text += " ";
        }
        else if (aff == 320)
        {
            text.text += "n";
        }
        else if (aff == 340)
        {
            text.text += "o";
        }
        else if (aff == 360)
        {
            text.text += "u";
        }
        else if (aff == 380)
        {
            text.text += "v";
        }
        else if (aff == 400)
        {
            text.text += "e";
        }
        else if (aff == 420)
        {
            text.text += "a";
        }
        else if (aff == 440)
        {
            text.text += "u";
        }
        if (aff >= 0)
            aff++;
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        Debug.Log("lol");
        if (other.tag.Equals("player"))
        {
            scripte.GetComponent<mouve>().enabled = false;
            fondText.SetActive(true);
            aff = 0;
        }
    }
}
