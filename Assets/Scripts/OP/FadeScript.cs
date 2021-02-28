using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;
using UnityEngine.UI;

public class FadeScript : MonoBehaviour
{
    float speed = 0.05f;  //透明化の速さ
    float alfa;    //A値を操作するための変数
    float red, green, blue;    //RGBを操作するための変数
    float time;
    public GameObject cat1;
    public GameObject camera1;
    public GameObject camera2;
    public GameObject wall;
    public GameObject text1;

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
        time += Time.deltaTime;
        if (time > 6.0f & 8.0f>time)
        {
            GetComponent<Image>().color = new Color(red, green, blue, alfa);
            alfa += speed;
        }
        if (time > 7.7f)
        {
           cat1.SetActive(true);

        }
        if (time > 9.0f)
        {

            GetComponent<Image>().color = new Color(red, green, blue, alfa);
            alfa -= speed;

        }
        if (time > 8.2f)
        {
            
            camera1.SetActive(true);
            camera2.SetActive(false);
            wall.SetActive(false);
        }
        if (time > 10.0f)
        {
            text1.SetActive(true);
        }
    }
}
