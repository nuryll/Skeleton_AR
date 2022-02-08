using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Start_Script : MonoBehaviour
{
    
    public GameObject Skeleton,Skeleton1,Skeleton2,Skeleton3,Man,Human,startbutton;

    public GameObject buttonH_and_N,buttonA_and_H,buttonC_and_B,buttonP_and_B,buttonL_and_F;

    public GameObject button_restart;

    public bool acik = false;


    // Start is called before the first frame update
    void Start()
    {
      
        Skeleton.SetActive(false);
        Skeleton1.SetActive(false);
        Skeleton2.SetActive(false);
        Skeleton3.SetActive(false);
        Human.SetActive(false);

        buttonH_and_N.SetActive(false);
        buttonA_and_H.SetActive(false);
        buttonC_and_B.SetActive(false);
        buttonP_and_B.SetActive(false);
        buttonL_and_F.SetActive(false);

        button_restart.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {

    }
    
    public void open()
    {

        
        StartCoroutine("second");



    }

    public IEnumerator second()
    {



        acik = !acik;
        if (acik)
        {
            yield return new WaitForSeconds(0.5f);

            Man.SetActive(false);

            Human.SetActive(true);
            Skeleton.SetActive(true);
            yield return new WaitForSeconds(0.2f);
            Human.GetComponent<Renderer>().material.color = new Color32(36, 52, 68, 60);
            yield return new WaitForSeconds(0.2f);
            Human.GetComponent<Renderer>().material.color = new Color32(36, 52, 68, 50);
            yield return new WaitForSeconds(0.2f);
            Human.GetComponent<Renderer>().material.color = new Color32(36, 52, 68, 40);
            yield return new WaitForSeconds(0.2f);
            Human.GetComponent<Renderer>().material.color = new Color32(36, 52, 68, 30);
            yield return new WaitForSeconds(0.2f);
            Human.GetComponent<Renderer>().material.color = new Color32(36, 52, 68, 20);
            yield return new WaitForSeconds(0.2f);
            Human.GetComponent<Renderer>().material.color = new Color32(36, 52, 68, 10);
            yield return new WaitForSeconds(0.2f);
            Human.GetComponent<Renderer>().material.color = new Color32(36, 52, 68, 0);
            Human.SetActive(false);
            Skeleton.SetActive(false);

            Skeleton1.SetActive(true);
            yield return new WaitForSeconds(1);
            Skeleton1.SetActive(false);
            Skeleton2.SetActive(true);
            yield return new WaitForSeconds(1);
            Skeleton2.SetActive(false);
            Skeleton3.SetActive(true);

            buttonH_and_N.SetActive(true);
            buttonA_and_H.SetActive(true);
            buttonC_and_B.SetActive(true);
            buttonP_and_B.SetActive(true);
            buttonL_and_F.SetActive(true);


            yield return new WaitForSeconds(0.5f);
            button_restart.SetActive(true);
            yield return new WaitForSeconds(0.005f);
            startbutton.SetActive(false);
        }
      



    }


}
