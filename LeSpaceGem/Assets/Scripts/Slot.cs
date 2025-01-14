using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Slot : MonoBehaviour
{
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
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.E))
        {

        }
    }
}
