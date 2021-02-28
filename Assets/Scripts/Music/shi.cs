using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class shi : MonoBehaviour
{
    public AudioClip sound7;
    AudioSource audioSource;
    public GameObject targetObj;

    static public int add7 = 0;
    static public int counter7 = 0;



    // Start is called before the first frame update
    void Start()
    {


        audioSource = GetComponent<AudioSource>();


    }

    // Update is called once per frame
    void Update()
    {
        if (add7 == 1)
        {
            if (Input.GetKeyDown(KeyCode.J))
            {
                counter7 = counter7 + 1;
                if (counter7 == 1)
                {
                    targetObj.SendMessage("AddScore");

                }
            }
        }



        if (Input.GetKeyDown(KeyCode.J))
        {
            audioSource.volume = 0.5f;
            audioSource.PlayOneShot(sound7);
            //oto1.transform.position += new Vector3(0, -0.1f, 0);
        }
        if (Input.GetKey(KeyCode.J))
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


        if (Input.GetKeyUp(KeyCode.J))
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
            add7 = 1;
        }


    }
    private void OnTriggerExit(Collider coll4)
    {
        if (coll4.gameObject.tag == "notu")
        {
            GetComponent<Renderer>().material.color = Color.white;
            counter7 = 0;
            add7 = 0;
        }

    }
}
