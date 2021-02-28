using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AddScoreScript : MonoBehaviour
{
    public Text text;
    public static int Score = 0;
    int parcent=0;
    public GameObject btn;
    Button btn2;
    static public int number;
    // Start is called before the first frame update
    void Start()
    {
        btn2 = btn.GetComponent<Button>();
    }

    // Update is called once per frame
    void Update()
    {
        if (RetryScript.hantei == false)
        {
            btn2.interactable = true;
        }
    }

    public void AddScore()
    {
        Score += 1;
        parcent = 100*Score / number ;

        text.text = "SCORE:   " + parcent +"%";
    }
}
