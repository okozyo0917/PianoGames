using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Fade2Script : MonoBehaviour
{
    public float speed2 = 0.00001f;  //透明化の速さ
    float alfa;    //A値を操作するための変数
    float red, green, blue;    //RGBを操作するための変数
    float time;
    public GameObject imge;
    public GameObject asist;
    bool hantei = false;
    AudioSource audioSource;
    public AudioClip sound03;

    public Text text2;

    // Start is called before the first frame update
    void Start()
    {
        audioSource = GetComponent<AudioSource>();
        red = GetComponent<Image>().color.r;
        green = GetComponent<Image>().color.g;
        blue = GetComponent<Image>().color.b;
    }

    // Update is called once per frame
    void Update()
    {
        time += Time.deltaTime;

        if (time > 0.001f & 0.8f > time)
        {
            GetComponent<Image>().color = new Color(red, green, blue, alfa);
            alfa += speed2;
        }
        if (time > 1.0f)
        {
            imge.SetActive(false);
            GetComponent<Image>().color = new Color(red, green, blue, alfa);
            alfa -= speed2;

        }
        if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            if (SceneManager.GetActiveScene().name == "Main")
            {
                SceneManager.LoadScene("Main2");
            }
            if (SceneManager.GetActiveScene().name == "Main2")
            {
                SceneManager.LoadScene("OP");
            }
        }
        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            if (SceneManager.GetActiveScene().name == "Main")
            {
                SceneManager.LoadScene("OP");
            }
            if (SceneManager.GetActiveScene().name == "Main2")
            {
                SceneManager.LoadScene("Main");
            }
        }
        if (Input.GetKeyDown(KeyCode.C))
        {
            if (hantei == true)
            {
                audioSource.PlayOneShot(sound03);
                asist.SetActive(true);
                hantei = false;
                text2.text = "ON[C]";
                return;
            }
            if (hantei == false)
            {
                audioSource.PlayOneShot(sound03);
                asist.SetActive(false);
                hantei = true;
                text2.text = "OFF[C]";
                return;
            }
     
        }

    }


    
}
