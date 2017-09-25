using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class endLvl2 : MonoBehaviour {


    GameObject player;
    int cine = 0;
    int n = 0;
    // Use this for initialization
    void Start()
    {
        player = GameObject.FindGameObjectWithTag("player");
    }

    // Update is called once per frame
    void Update()
    {

        if (cine == 1)
        {
            if (n < 5)
                player.transform.localScale -= new Vector3(0.1F, 0.1f, 0);
            player.GetComponent<Rigidbody2D>().AddForce(new Vector2(0, 2f));
            n++;
            if (n > 5)
            {
                int total = PlayerPrefs.GetInt("ptsTatal") + vie.pts;
                PlayerPrefs.SetInt("ptsTotal", total);
                PlayerPrefs.SetInt("ptsGagner", vie.pts);
                SceneManager.LoadScene("endLvl2");
            }
        }
    }
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag.Equals("player"))
        {
            cine = 1;
        }
    }
}
