using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class buttonH_and_N : MonoBehaviour
{
    public GameObject panel;

    public bool acik = false;


    // Start is called before the first frame update
    void Start()
    {

        panel.SetActive(false);
       

    }

    // Update is called once per frame
    void Update()
    {

    }

    public void open()
    {


        acik = !acik;
        if (acik)
        {
           

            panel.SetActive(true);

            
        }

        else
        {

            panel.SetActive(false);
        }



    }

}
