using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NotuScript : MonoBehaviour
{

    MeshRenderer mr;
    bool hantei2 = true;


    // Start is called before the first frame update
    void Start()
    {
        mr = GetComponent<MeshRenderer>();
        mr.enabled = true;
    }

    // Update is called once per frame
    void Update()
    {
        transform.position += new Vector3(0,-Time.deltaTime*1.6f,0);
        if (Input.GetKeyDown(KeyCode.N))
        {
            if (hantei2 == true)
            {
                mr.enabled = false;
                hantei2 = false;
                return;
            }
            if (hantei2 == false)
            {
                mr.enabled = true;
                hantei2 = true;
                return;
            }

        }

    }

}
