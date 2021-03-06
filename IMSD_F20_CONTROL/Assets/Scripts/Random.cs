﻿using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Security.Cryptography;
using System.Threading;
using UnityEngine;

public class Random : MonoBehaviour
{
    public Transform myTransform;
    public float timer;
    private float x;
    private double y;
    private float z;
    // Start is called before the first frame update
    void Start()
    {
        x = this.transform.position.x;
        y = this.transform.position.y;
        z = this.transform.position.z;
    }

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;
        x = UnityEngine.Random.Range(-18.5f,-3.0f);
        y = 1.5;
        z = UnityEngine.Random.Range(0.0f,19.5f);
        if(timer >= 1)
        {
            timer = 0; 
            myTransform.position = new Vector3((float)x, (float)y, z);
        }    
    }
}
