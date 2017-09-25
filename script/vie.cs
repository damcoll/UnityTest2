using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class vie : MonoBehaviour {

    public Texture2D barreVie;
    public  static int lifeLeft = 100; //Vie qui peut descendre avec le temps.
    public GameObject player;
    public Text point;
    public static int pts = 0;
    public static void LoosePv()
    {
        lifeLeft -= 10;
        if (lifeLeft <= 0)
            SceneManager.LoadScene("GameOver");
    }
    public static void addpiece()
    {
        pts++;
    }
    private void Update()
    {
        string t = NewMethod();
        point.text = t;
    }

    private static string NewMethod()
    {
        return pts.ToString() + " points";
    }

    void OnGUI()
    {
        GUI.DrawTexture(new Rect(10, 20, barreVie.width * lifeLeft / 100, barreVie.height), barreVie);
        
    }
}
