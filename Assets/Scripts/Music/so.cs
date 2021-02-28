using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class so : MonoBehaviour
{
    public AudioClip sound5;
    AudioSource audioSource;
    public GameObject targetObj;

    static public int add5 = 0;
    static public int counter5 = 0;




    // Start is called before the first frame update
    void Start()
    {
  

        audioSource = GetComponent<AudioSource>();


    }

    // Update is called once per frame
    void Update()
    {
        if (add5 == 1)
        {
            if (Input.GetKeyDown(KeyCode.G))
            {
                counter5 = counter5 + 1;
                if (counter5 == 1)
                {
                    targetObj.SendMessage("AddScore");

                }
            }
        }
        if (Input.GetKeyDown(KeyCode.G))
        {
            audioSource.volume = 0.5f;
            audioSource.PlayOneShot(sound5);
            //oto1.transform.position += new Vector3(0, -0.1f, 0);
        }
        if (Input.GetKey(KeyCode.G))
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


        if (Input.GetKeyUp(KeyCode.G))
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
            add5 = 1;
        }


    }
    private void OnTriggerExit(Collider coll4)
    {
        if (coll4.gameObject.tag == "notu")
        {
            GetComponent<Renderer>().material.color = Color.white;
            counter5 = 0;
            add5 = 0;
        }

    }


}
