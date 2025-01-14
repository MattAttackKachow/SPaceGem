using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class Timer : MonoBehaviour
{
    [Header("Component")]
    public TextMeshProUGUI timerText;

    [Header("Timer Settings")]
    public float currentTime;
    public bool countDown;

    [Header("Limit Settings")]
    public bool hasLimit;
    public float timerLimit;

    public int Hour;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        currentTime = countDown ? currentTime -= Time.deltaTime : currentTime += Time.deltaTime;

        Time.timeScale = 1;

        SetTimerText();

        if (Hour >= 0)
        {
          
        }
            
        if (currentTime <= 59)
        {
            SceneManager.LoadScene("Win");
        }
        if (currentTime >= 60)
        {
            Hour = 1;
        }
        if (currentTime >= 120)
        {
            Hour = 2;
        }
        if (currentTime >= 180)
        {
            Hour = 3;

            if (currentTime >= 240)
            {
                Hour = 4;
            }

            if (currentTime >= 300)
            {
                Hour = 5;
            }

            if (currentTime >= 360)
            {
                Hour = 6;
            }

            if (currentTime >= 420)
            {
                Hour = 7;
            }

            if (currentTime >= 480)
            {
                Hour = 7;
            }
        }

         void SetTimerText()
        {
            timerText.text = Hour.ToString("0 Hours Until Arrival");
        }


    }
}
