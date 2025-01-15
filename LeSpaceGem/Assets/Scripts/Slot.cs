using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Slot : MonoBehaviour
{
    public bool leverDown;
    Animator anim;

    [Header("FirstRow")]
    public GameObject Gun1;
    public GameObject Astro1;
    public GameObject Book1;

    [Header("SecondRow")]
    public GameObject Gun2;
    public GameObject Astro2;
    public GameObject Book2;

    [Header("ThirdRow")]
    public GameObject Gun3;
    public GameObject Astro3;
    public GameObject Book3;


    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
         if (Input.GetKeyDown(KeyCode.E))
         {
       
            if (leverDown == false)
            {
                anim.SetTrigger("LeverDown");
                Invoke("Press", 0.6f);
                leverDown = true;

            }
         }
   
        
    }
    public void Press()
    {
        leverDown = false;
        int row1 = Random.Range(1, 7);
        int row2 = Random.Range(1, 7);
        int row3 = Random.Range(1, 7);

        //Row1
        if (row1 == 1)
        {
            Gun1.SetActive(true);
            Astro1.SetActive(false);
            Book1.SetActive(false);
        }

        if (row1 == 2)
        {
            Gun1.SetActive(false);
            Astro1.SetActive(true);
            Book1.SetActive(false);
        }

        if (row1 == 3)
        {
            Gun1.SetActive(false);
            Astro1.SetActive(false);
            Book1.SetActive(true);
        }

        //Row2
        if (row2 == 1)
        {
            Gun2.SetActive(true);
            Astro2.SetActive(false);
            Book2.SetActive(false);
        }

        if (row2 == 2)
        {
            Gun2.SetActive(false);
            Astro2.SetActive(true);
            Book2.SetActive(false);
        }

        if (row2 == 3)
        {
            Gun2.SetActive(false);
            Astro2.SetActive(false);
            Book2.SetActive(true);
        }

        //row3
        if (row3 == 1)
        {
            Gun3.SetActive(true);
            Astro3.SetActive(false);
            Book3.SetActive(false);
        }

        if (row3 == 2)
        {
            Gun3.SetActive(false);
            Astro3.SetActive(true);
            Book3.SetActive(false);
        }

        if (row3 == 3)
        {
            Gun3.SetActive(false);
            Astro3.SetActive(false);
            Book3.SetActive(true);
        }
    }
}
