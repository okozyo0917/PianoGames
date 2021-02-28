using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FilterScript : MonoBehaviour
{
    bool hantei = true;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.N))
        {
            if (hantei == true)
            {
                hantei = false;
                return;
            }
            if (hantei == false)
            {
                hantei = true;
                return;
            }
        }

    }
    private void OnTriggerEnter(Collider other2)
    {
        if(hantei == false)
        {
            GameObject obj = other2.gameObject;
            obj.GetComponent<MeshRenderer>().enabled = false;

        }
        if(hantei == true)
        {
            GameObject obj = other2.gameObject;
            obj.GetComponent<MeshRenderer>().enabled = true;
        }

    }
}
