﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class fa : MonoBehaviour
{
    public AudioClip sound4;
    AudioSource audioSource;
    public GameObject targetObj;

    static public int add4 = 0;
    static public int counter4 = 0;


    // Start is called before the first frame update
    void Start()
    {


        audioSource = GetComponent<AudioSource>();


    }

    // Update is called once per frame
    void Update()
    {

        if (add4 == 1)
        {
            if (Input.GetKeyDown(KeyCode.F))
            {
                counter4 = counter4 + 1;
                if (counter4 == 1)
                {
                    targetObj.SendMessage("AddScore");

                }
            }
        }

        if (Input.GetKeyDown(KeyCode.F))
        {
            audioSource.volume = 0.5f;
            audioSource.PlayOneShot(sound4);
            //oto1.transform.position += new Vector3(0, -0.1f, 0);
        }
        if (Input.GetKey(KeyCode.F))
        {

            if (transform.position.y <= -0.1f)
            {
                transform.position += new Vector3(0, 0, 0);
            }
            if (transform.position.y > -0.1f)
            {

                transform.position += new Vector3(0, -0.1f, 0);
            }


        }


        if (Input.GetKeyUp(KeyCode.F))
        {
            //audioSource.Stop();
            audioSource.volume -= 10;

            if (transform.position.y <= 0)
            {
                transform.position += new Vector3(0, 0.1f, 0);
            }
            if (transform.position.y > 0)
            {

                transform.position += new Vector3(0, 0, 0);
            }
        }


    }
    private void OnTriggerStay(Collider coll3)
    {
        if (coll3.gameObject.tag == "notu")
        {
            GetComponent<Renderer>().material.color = Color.yellow;
            add4 = 1;
        }


    }
    private void OnTriggerExit(Collider coll4)
    {
        if (coll4.gameObject.tag == "notu")
        {
            GetComponent<Renderer>().material.color = Color.white;
            counter4 = 0;
            add4 = 0;
        }

    }
}
