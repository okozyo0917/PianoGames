using System.Collections;
using System.Collections.Generic;
using System.Net.Http.Headers;
using UnityEngine;
using UnityEngine.UIElements;

public class do1 : MonoBehaviour
{
    public AudioClip sound1;
    AudioSource audioSource;

    public GameObject targetObj;

    static public int add = 0;
    static public int counter = 0;


    // Start is called before the first frame update
    void Start()
    {
        audioSource = GetComponent<AudioSource>();

    }

    // Update is called once per frame
    void Update()
    {
        if (add==1)
        {
            if (Input.GetKeyDown(KeyCode.A))
            {
                counter = counter+1;
                if (counter==1) {
                    targetObj.SendMessage("AddScore");
                   
                }
            }
        }


        if (Input.GetKeyDown(KeyCode.A))
        {
            audioSource.volume =0.5f;
            audioSource.PlayOneShot(sound1);
            //oto1.transform.position += new Vector3(0, -0.1f, 0);
        }
        if (Input.GetKey(KeyCode.A))
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
 

        if (Input.GetKeyUp(KeyCode.A))
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
    private void OnTriggerStay(Collider coll)
    {
        if (coll.gameObject.tag=="notu") {
            //GetComponent<Renderer>().material.color = iro.color;
            GetComponent<Renderer>().material.color = Color.yellow;
            add = 1;

        }




    }


    private void OnTriggerExit(Collider coll2)
    {
        if (coll2.gameObject.tag == "notu")
        {
            GetComponent<Renderer>().material.color = Color.white;
            counter = 0;
            add = 0;
        }

    }
}
