using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.Threading;

public class StartScript : MonoBehaviour
{
    AudioSource audioSource;
    public AudioClip sound01;
    public GameObject image;
    public GameObject book;
    public GameObject ui;
    public Text text;
    bool hantei = false;


    // Start is called before the first frame update
    void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            if (hantei == false)
            {
                audioSource.PlayOneShot(sound01);
                image.SetActive(true);
                book.SetActive(true);
                ui.SetActive(true);
                text.text = "choose MODE";
                hantei = true;
                return;
            }

            if (hantei == true)
            {
                audioSource.PlayOneShot(sound01);
                image.SetActive(false);
                book.SetActive(false);
                ui.SetActive(false);
                text.text = "Press the space";
                hantei = false;
                return;
            }


            }
    }

}
