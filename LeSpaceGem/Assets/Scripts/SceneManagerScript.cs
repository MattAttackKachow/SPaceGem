using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneManagerScript : MonoBehaviour
{

    void Update()
    {
        if (Input.anyKeyDown)
        {
                SceneManager.LoadScene("RuneTest"); 
           
           


        }
    }


}

