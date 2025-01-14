using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;


public class PlayerController : MonoBehaviour
{
    public static PlayerController instance;


    public float ET;
    public TextMeshProUGUI ETBar;
    public float speed;

    public Rigidbody2D rb;

    [Header("Component")]
    public TextMeshProUGUI timerText;

    [Header("Timer Settings")]
    public bool countDown;

    [Header("Limit Settings")]
    public bool hasLimit;
    public float timerLimit;

    public bool InMiniG;



    // Start is called before the first frame update
    void Start()
    {
        ET = 100;
    }

    // Update is called once per frame
    void Update()
    {
        ET = countDown ? ET -= Time.deltaTime : ET += Time.deltaTime;

        SetTimerText();

        if (InMiniG == false) 
        {

            if (Input.GetKeyDown(KeyCode.W))
            {
                rb.velocity = new Vector2(rb.velocity.x, speed);

            }

            if (Input.GetKeyDown(KeyCode.A))
            {

                rb.velocity = new Vector2(-speed, rb.velocity.y);
            }


            if (Input.GetKeyDown(KeyCode.D))
            {

                rb.velocity = new Vector2(speed, rb.velocity.y);
            }


            if (Input.GetKeyDown(KeyCode.S))
            {
                rb.velocity = new Vector2(rb.velocity.x, -speed);

            }

        }
    }
    private void SetTimerText()
    {
        ETBar.text = ET.ToString("0" + " Percent Entertained");
    }
}
