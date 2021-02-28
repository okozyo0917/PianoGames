using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mi : MonoBehaviour
{

    public AudioClip sound3;
    AudioSource audioSource;
    public GameObject targetObj;

    static public int add3 = 0;
    static public int counter3 = 0;

    // Start is called before the first frame update
    void Start()
    {


        audioSource = GetComponent<AudioSource>();


    }

    // Update is called once per frame
    void Update()
    {

        if (add3 == 1)
        {
            if (Input.GetKeyDown(KeyCode.D))
            {
                counter3 = counter3 + 1;
                if (counter3 == 1)
                {
                    targetObj.SendMessage("AddScore");

                }
            }
        }

        if (Input.GetKeyDown(KeyCode.D))
        {
            audioSource.volume = 0.5f;
            audioSource.PlayOneShot(sound3);
            //oto1.transform.position += new Vector3(0, -0.1f, 0);
        }
        if (Input.GetKey(KeyCode.D))
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


        if (Input.GetKeyUp(KeyCode.D))
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
            add3 = 1;
        }


    }
    private void OnTriggerExit(Collider coll4)
    {
        if (coll4.gameObject.tag == "notu")
        {
            GetComponent<Renderer>().material.color = Color.white;
            counter3 = 0;
            add3 = 0;
        }

    }
}
