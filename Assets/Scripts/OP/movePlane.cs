﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movePlane : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position += new Vector3(0, 2.0f*Time.deltaTime, 0);
    }
}
