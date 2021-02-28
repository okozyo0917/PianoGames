using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class so_1 : MonoBehaviour
{
    public AudioClip sound4_4;
    AudioSource audioSource;
    // Start is called before the first frame update
    void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Y))
        {
            audioSource.volume = 0.5f;
            audioSource.PlayOneShot(sound4_4);
            //oto1.transform.position += new Vector3(0, -0.1f, 0);
        }
        if (Input.GetKey(KeyCode.Y))
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

        if (Input.GetKeyUp(KeyCode.Y))
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

