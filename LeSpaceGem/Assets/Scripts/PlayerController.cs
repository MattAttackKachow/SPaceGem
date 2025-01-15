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

    [Header("Timer Settings")]
    public bool countDown;

    [Header("Limit Settings")]
    public bool hasLimit;
    public float timerLimit;

    public bool playerOff;
    public GameObject PressE;

    [Header("Russian Rol")]
    public bool RROn;
    public int Bullet;
    public int Amount;
    public int Tries;
    public bool hasDied;

    [Header("Book")]
    public bool BOn;
    public bool AlreadyRead;
    public GameObject Bok;
    public GameObject Read;

    [Header("Cards")]
    public bool COn;
    public int CardTries;
    public Transform spawnPoint;
    public GameObject cardPrefab;

    public float cardSpeed;

    public float coolDown;

    public float currentCoolDown;

    [Header("Slots")]
    public bool SOn;
    public bool leverDown;
    public Animator anim;
    public GameObject SlotsOn;
    public GameObject StopGamb;

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
        ET = 100;
    }

    // Update is called once per frame
    void Update()
    {
        if (ET >= 100)
        {
            ET = 100;
        }

        if (ET <= 0)
        {
            SceneManager.LoadScene("BoreDomDeath");
        }
        ET = countDown ? ET -= Time.deltaTime : ET += Time.deltaTime;
        currentCoolDown -= Time.deltaTime;

        SetTimerText();

        if (playerOff == false) 
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
                if (randomNumber == 5)
                {
                    SceneManager.LoadScene("GameOver");

                }

                if (Tries == 0)
                {
                    SceneManager.LoadScene("GameOver");
                }

            }


        }
        if (Input.GetKeyDown(KeyCode.Escape))
        {

            SOn = false;
            SlotsOn.SetActive(false);
            StopGamb.SetActive(false);
            playerOff = false;
            BOn = false;
            Bok.SetActive(false);
        }
        if (BOn == true)
        {
            if (AlreadyRead == false)
            {
                if (Input.GetKeyDown(KeyCode.E))
                {
                    ET += 10;
                    playerOff = true;
                    Bok.SetActive(true);
                    AlreadyRead = true;

                }
               
            }

            if (AlreadyRead == true) 
            {
                if (Input.GetKeyDown(KeyCode.E))
                {
                    Read.SetActive(true);


                }
         
            
            }


          }

        if (COn == true)
        {
            if (CardTries >= 0)
            {



                if (Input.GetKeyDown(KeyCode.E) && currentCoolDown <= 0f)
                {
                    Spawn();
                    currentCoolDown = coolDown;
                    ET++;
                    --CardTries;
            

                    
                }
            }
      

           
        }


        if (SOn == true)
        {
            if (Input.GetKeyDown(KeyCode.E))
            {
                playerOff = true;
                SlotsOn.SetActive(true);
                StopGamb.SetActive(true);

                if (leverDown == false)
                {
                    anim.SetTrigger("LeverDown");
                    Invoke("Press", 0.6f);
                    leverDown = true;

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

        if (other.tag == "Book")
        {
            BOn = true;
           
        }

        if (other.tag == "Table")
        {
            COn = true;
        }

        if (other.tag == "Slots")
        {
            SOn = true;

        }
    }

    public void OnTriggerExit2D(Collider2D other)
    {
        PressE.SetActive(false);
        if (other.tag == "RussianR")
        {
            RROn = false;
            Read.SetActive(false);
        }
        if (other.tag == "Book")
        {
            BOn = false;
            Read.SetActive(false);
        }

        if (other.tag == "Table")
        {
            COn = false;
        }

    }


    private void SetTimerText()
    {
        ETBar.text = ET.ToString("0" + " Percent Entertained");
    }
    void Spawn()
    {
        GameObject card = Instantiate(cardPrefab, spawnPoint.position, spawnPoint.rotation);
        Rigidbody2D rb = card.GetComponent<Rigidbody2D>();
        rb.AddForce(spawnPoint.up * cardSpeed, ForceMode2D.Impulse);
    }

    public void Press()
    {
        ET -= 10;
        leverDown = false;
        int row1 = Random.Range(1, 4);
        int row2 = Random.Range(1, 4);
        int row3 = Random.Range(1, 4);

        if(row1 == 1 && row2 == 1 && row3 == 1)
        {
            ET += 60;
        }

        if (row1 == 2 && row2 == 2 && row3 == 2)
        {
            ET += 60;
        }

        if (row1 == 3 && row2 == 3 && row3 == 3)
        {
            ET += 60;
        }

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
