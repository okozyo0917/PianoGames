using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SEScript : MonoBehaviour
{
    AudioSource audioSource;
    public bool DontDestroyEnabled = true;
    public AudioClip sound02;
    // Start is called before the first frame update
    void Start()
    {
        audioSource = GetComponent<AudioSource>();
        if (DontDestroyEnabled)
        {
            // Sceneを遷移してもオブジェクトが消えないようにする
            DontDestroyOnLoad(this);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void Onclick()
    {
        audioSource.PlayOneShot(sound02);

        SceneManager.LoadScene("Main");

    }
    public void Onclick2()
    {
        audioSource.PlayOneShot(sound02);
        SceneManager.LoadScene("Main2");
    }
}
