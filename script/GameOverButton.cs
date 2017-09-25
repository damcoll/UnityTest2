using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameOverButton : MonoBehaviour {

    public Text aff;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        aff.text = (PlayerPrefs.GetInt("ptsTotal")+ vie.pts).ToString() + " point";
	}

    public void quitter()
    {
        Application.Quit();
    }
    public void continuer()
    {
        vie.lifeLeft = 100;
        vie.pts = 0;
        SceneManager.LoadScene("scen1");
    }
}
