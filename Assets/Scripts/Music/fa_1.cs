﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class fa_1 : MonoBehaviour
{
    public AudioClip sound3_3;
    AudioSource audioSource;
    // Start is called before the first frame update
    void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.T))
        {
            audioSource.volume = 0.5f;
            audioSource.PlayOneShot(sound3_3);
            //oto1.transform.position += new Vector3(0, -0.1f, 0);
        }
        if (Input.GetKey(KeyCode.T))
        {

            if (transform.position.y <= -0.01f)
            {
                transform.position += new Vector3(0, 0, 0);

            }
            if (transform.position.y > -0.01f)
            {

                transform.position += new Vector3(0, -0.1f, 0);
            }


        }

        if (Input.GetKeyUp(KeyCode.T))
        {
            //audioSource.Stop();
            audioSource.volume -= 10;


            if (transform.position.y <= 0.2f)
            {
                transform.position += new Vector3(0, 0.2f, 0);
            }
            if (transform.position.y > 0.2f)
            {

                transform.position += new Vector3(0, 0, 0);
            }
        }

    }
}
