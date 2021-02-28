using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class RetryScript : MonoBehaviour
{
    static public bool hantei = true;
 
    // Start is called before the first frame update
    void Start()
    {
    
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.R))
        {
            SceneManager.LoadScene("Main2");
            if (hantei == true)
            {
                if (AddScoreScript.Score > 39)
                {
                    SceneManager.LoadScene("Animation_1");
                    AddScoreScript.Score = 0;
                    hantei = false;
                }
            }
        }

    }
}
