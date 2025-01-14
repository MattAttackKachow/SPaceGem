using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LRAnim : MonoBehaviour
{
    Animator Anim;

    void Start()
    {
        Anim = GetComponent<Animator>();
    }

    private void Update()
    {
        if (Input.GetKey(KeyCode.D))
        {
            Anim.SetTrigger("Right");
            
        }

        if (Input.GetKey(KeyCode.A))
        {
            Anim.SetTrigger("Left");
            
        }

    }

}
