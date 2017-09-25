using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class finDeNiveau2 : MonoBehaviour {

    public Text aff;

    int nbPiece = 0;
    int s = 0;
    int t = 0;
    int pts;
	// Use this for initialization
	void Start () {
        pts = PlayerPrefs.GetInt("ptsGagner");

    }

    // Update is called once per frame
    void Update()
    {
        if (s % 5 == 0)
        {
            if (nbPiece < pts)
                nbPiece++;
            aff.text = phrase(nbPiece);
        }
        s++;
        if (nbPiece >= pts ) t++;

        if (t > 20)
            SceneManager.LoadScene("scen4");
    }
    string phrase(int i)
    {
        return "X " + i.ToString();
    }
}
