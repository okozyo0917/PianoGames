using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Fade4Script : MonoBehaviour
{
    float speed = 0.05f;   //透明化の速さ
    float alfa;    //A値を操作するための変数
    float timer = 0.0f;
    float red, green, blue;

    public GameObject music;
    // Start is called before the first frame update
    void Start()
    {
        red = GetComponent<Image>().color.r;
        green = GetComponent<Image>().color.g;
        blue = GetComponent<Image>().color.b;
    }

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;

        if (timer > 6.0f & 7.0f > timer)
        {
            GetComponent<Image>().color = new Color(red, green, blue, alfa);
            alfa += speed;
        }
        if (timer > 8.0f)
        {
            GetComponent<Image>().color = new Color(red, green, blue, alfa);
            alfa -= speed;
            music.SetActive(true);

        }
    }
}
