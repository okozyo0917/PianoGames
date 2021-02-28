using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Fade3Script : MonoBehaviour
{
    public float speed2 = 0.01f;  //透明化の速さ
    float alfa;    //A値を操作するための変数
    float red, green, blue;    //RGBを操作するための変数
    float time;
    public GameObject imge;
    public GameObject asist;
    bool hantei = false;
    public GameObject buton;
    AudioSource audioSource;
    public AudioClip sound04;

    public Text text1;

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
        if (time > 1.3f)
        {
            buton.SetActive(true);

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
            if (hantei == false)
            {
                audioSource.PlayOneShot(sound04);
                asist.SetActive(false);
                hantei = true;
                text1.text = "OFF[C]";
                return;
            }
            if (hantei == true)
            {
                audioSource.PlayOneShot(sound04);
                asist.SetActive(true);
                hantei = false;
                text1.text = "ON[C]";
                return;
            }

        }

    }
}
