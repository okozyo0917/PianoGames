using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TitleScript : MonoBehaviour
{
    public GameObject icon1;
    public GameObject icon2;
    bool choice = true;
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

        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            audioSource.PlayOneShot(sound01);
            icon1.SetActive(true);
            icon2.SetActive(false);
            choice = true;
            
        }
            if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            audioSource.PlayOneShot(sound01);
            icon1.SetActive(false);
            icon2.SetActive(true);
            choice = false;

        }

        if (Input.GetKeyDown(KeyCode.Space))
        {
            audioSource.PlayOneShot(sound01);
            if (choice == true) {
                SceneManager.LoadScene("Tutorial");
            }

            if (choice == false)
            {
                SceneManager.LoadScene("OP");
            }
        }

    }
}
