﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class lancementBoss : MonoBehaviour
{
    public GameObject boss;

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
    void OnTriggerEnter2D(Collider2D other)
    {
        boss.GetComponent<boos>().lancement();
    }

}
