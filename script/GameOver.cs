using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOver : MonoBehaviour {


	// Use this for initialization
	void Start () {
        
	}

    // Update is called once per frame
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag.Equals("player"))
        {
            PlayerPrefs.SetInt("ptsTatal", vie.pts + PlayerPrefs.GetInt("ptsGagner"));
            SceneManager.LoadScene("GameOver");
        }
    }
}
