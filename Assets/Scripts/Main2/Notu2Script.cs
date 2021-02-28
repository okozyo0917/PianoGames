using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Notu2Script : MonoBehaviour
{
    public Text text2;
    bool hantei2 = true;
    AudioSource audioSource;
    public AudioClip sound01;

    // Start is called before the first frame update
    void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
                       

        if (Input.GetKeyDown(KeyCode.N))
        {
            if (hantei2 == true)
            {

                hantei2 = false;
                text2.text = "OFF[N]";
                audioSource.PlayOneShot(sound01);
                return;
            }
            if (hantei2 == false)
            {
                audioSource.PlayOneShot(sound01);
                hantei2 = true;
                text2.text = "ON[N]";
                return;
            }

        }
    }
}
