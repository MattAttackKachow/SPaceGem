using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnPointSpin : MonoBehaviour
{
    public float spinSpeedz = 0f;

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(0, 0, spinSpeedz * Time.deltaTime, Space.Self);
    }
}
