using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;


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
    public GameObject PressE;

    [Header("Russian Rol")]
    public bool RROn;
    public int Bullet;
    public int Amount;
    public int Tries;
    public bool hasDied;



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

        if (RROn == true) 
        {
       
                if (Input.GetKeyDown(KeyCode.E))
                {
                    ET += 50;
                    int randomNumber = Random.Range(Bullet, Amount);
                    --Tries;
                    Debug.Log("THe number is" + " " + randomNumber);
                    if (randomNumber == 6)
                    {
                        SceneManager.LoadScene("GameOver");

                    }

                    if (Tries == 0)
                    {
                        SceneManager.LoadScene("GameOver");
                    }

                }
            

        }
    }

      public void OnTriggerStay2D(Collider2D other)
    {
        PressE.SetActive(true);
        if (other.tag == "RussianR") 
        {
            RROn = true;
        }
      }

    public void OnTriggerExit2D(Collider2D other)
    {
        PressE.SetActive(false);
        if (other.tag == "RussianR")
        {
            RROn = false;
        }
    }

    private void SetTimerText()
    {
        ETBar.text = ET.ToString("0" + " Percent Entertained");
    }
}
