using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mouvCam : MonoBehaviour {
    float vitesse = -0.1f;
    public GameObject Player;
    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        
        if (Input.GetAxis("Horizontal") < 0)
        {
            this.transform.Translate(new Vector3(vitesse, 0));

        }
        else if (Input.GetAxis("Horizontal") > 0)
        {
            this.transform.Translate(new Vector3(-vitesse , 0));

        }
        else if (Player.transform.position.x < this.transform.position.x - 2f)
            this.transform.Translate(new Vector3(vitesse, 0));
        else if (Player.transform.position.x > this.transform.position.x + 2)
            this.transform.Translate(new Vector3(-vitesse, 0));
        if (Player.transform.position.y < this.transform.position.y - 2f)
            this.transform.Translate(new Vector3(0, vitesse));
        else if (Player.transform.position.y > this.transform.position.y + 2)
            this.transform.Translate(new Vector3(0, -vitesse));
    }
}
