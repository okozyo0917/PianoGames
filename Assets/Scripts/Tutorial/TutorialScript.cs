using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class TutorialScript : MonoBehaviour
{
   
    int count = 0;
    float timer = 0;

    public GameObject Books;
    public GameObject texts;


    public GameObject Black;
    public GameObject White;
    public GameObject Asist;
    public GameObject Asist2;
   

    public GameObject tutorial;
    public GameObject image;

    public GameObject particle;

    AudioSource audioSource;
    public AudioClip sound;

    // Start is called before the first frame update
    void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;
        if (timer > 7.0f)
        {

            if (Input.GetKeyDown(KeyCode.Space))
            {
                count += 1;
                audioSource.PlayOneShot(sound);

            }

            if (count == 1)
            {
                Books.SetActive(true);
                texts.SetActive(true);

            }
            if (count == 5)
            {
                Books.SetActive(false);
                texts.SetActive(false);
                tutorial.SetActive(true);
            }

            if (count == 7)
            {
                Black.SetActive(true);
                White.SetActive(true);
                Asist.SetActive(true);
                Asist2.SetActive(true);
                tutorial.SetActive(false);

            }

            if (count == 10)
            {
                Black.SetActive(false);
                White.SetActive(false);
                Asist.SetActive(false);
                Asist2.SetActive(false);
                image.SetActive(true);

            }

            if (count == 14)
            {
                image.SetActive(false);
                particle.SetActive(true);
            }

            if (count == 16)
            {
                SceneManager.LoadScene("OP");
            }
        }

    }
}
