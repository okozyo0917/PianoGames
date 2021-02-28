using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class re : MonoBehaviour
{
    public AudioClip sound2;
    AudioSource audioSource;
    public GameObject targetObj;

    static public int add2 = 0;
    static public int counter2 = 0;


    // Start is called before the first frame update
    void Start()
    {


        audioSource = GetComponent<AudioSource>();


    }

    // Update is called once per frame
    void Update()
    {
        if (add2 == 1)
        {
            if (Input.GetKeyDown(KeyCode.S))
            {
                counter2 = counter2 + 1;
                if (counter2 == 1)
                {
                    targetObj.SendMessage("AddScore");

                }
            }
        }


        if (Input.GetKeyDown(KeyCode.S))
        {
            audioSource.volume = 0.5f;
            audioSource.PlayOneShot(sound2);
            //oto1.transform.position += new Vector3(0, -0.1f, 0);
        }
        if (Input.GetKey(KeyCode.S))
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


        if (Input.GetKeyUp(KeyCode.S))
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
            add2 = 1;
        }


    }
    private void OnTriggerExit(Collider coll4)
    {
        if (coll4.gameObject.tag == "notu")
        {
            GetComponent<Renderer>().material.color = Color.white;
            counter2 = 0;
            add2 = 0;
        }

    }
}
