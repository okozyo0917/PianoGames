using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;
using System.Net.Http.Headers;

public class do2 : MonoBehaviour
{
    public AudioClip sound8;
    AudioSource audioSource;

    public GameObject targetObj;

    static public int add8 = 0;
    static public int counter8 = 0;


// Start is called before the first frame update
    void Start()
    {
        audioSource = GetComponent<AudioSource>();


    }
  // Update is called once per frame
    void Update()
    {
        if (add8 == 1)
        {
            if (Input.GetKeyDown(KeyCode.K))
            {
                counter8 = counter8 + 1;
                if (counter8 == 1)
                {
                    targetObj.SendMessage("AddScore");
                }
            }
        }

        if (Input.GetKeyDown(KeyCode.K))
        {
            audioSource.volume = 0.5f;
            audioSource.PlayOneShot(sound8);
            //oto1.transform.position += new Vector3(0, -0.1f, 0);
        }
        if (Input.GetKey(KeyCode.K))
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


        if (Input.GetKeyUp(KeyCode.K))
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
            add8 = 1;
        }


    }
    private void OnTriggerExit(Collider coll4)
    {
        if (coll4.gameObject.tag == "notu")
        {
            GetComponent<Renderer>().material.color = Color.white;
            counter8 = 0;
            add8 = 0;
        }

    }
}
