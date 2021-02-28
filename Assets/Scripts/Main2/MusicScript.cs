using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MusicScript : MonoBehaviour
{
    public AudioClip sound1;
    public AudioClip sound2;
    AudioSource audioSource;
    public GameObject buton2;
    public GameObject buton3;
    public GameObject notu;
    public GameObject notu2;
    bool music1 = false;
    bool music2 = false;
    // Start is called before the first frame update
    void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        if (music1 == true)
        {
            buton2.SetActive(false);
            buton3.SetActive(false);
            notu.SetActive(true);
        }
        if (music2 == true)
        {
            buton2.SetActive(false);
            buton3.SetActive(false);
            notu2.SetActive(true);

        }
        
    }
    public void Onclick3()
    {
        audioSource.PlayOneShot(sound1);
        music1 = true;
        AddScoreScript.number = 42;
    }
    public void Onclick4()
    {
        audioSource.PlayOneShot(sound2);
        music2 = true;
        AddScoreScript.number = 66;
    }

}
