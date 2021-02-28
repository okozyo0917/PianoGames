using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ra : MonoBehaviour
{
    public AudioClip sound6;
    AudioSource audioSource;
    public GameObject targetObj;

    static public int add6 = 0;
    static public int counter6 = 0;


    // Start is called before the first frame update
    void Start()
    {


        audioSource = GetComponent<AudioSource>();


    }

    // Update is called once per frame
    void Update()
    {

        if (add6 == 1)
        {
            if (Input.GetKeyDown(KeyCode.H))
            {
                counter6 = counter6 + 1;
                if (counter6 == 1)
                {
                    targetObj.SendMessage("AddScore");

                }
            }
        }
        if (Input.GetKeyDown(KeyCode.H))
        {
            audioSource.volume = 0.5f;
            audioSource.PlayOneShot(sound6);
            //oto1.transform.position += new Vector3(0, -0.1f, 0);
        }
        if (Input.GetKey(KeyCode.H))
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


        if (Input.GetKeyUp(KeyCode.H))
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
            add6 = 1;
        }


    }
    private void OnTriggerExit(Collider coll4)
    {
        if (coll4.gameObject.tag == "notu")
        {
            GetComponent<Renderer>().material.color = Color.white;
            counter6 = 0;
            add6 = 0;
        }

    }
}
