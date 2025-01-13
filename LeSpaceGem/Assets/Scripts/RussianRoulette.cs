using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;


public class RussianRoulette : MonoBehaviour
{
    public int Bullet;
    public int Amount;
    public int Tries;
    public bool hasDied;

    public int theKnumber;

    // Start is called before the first frame update
    public void Awake()
    {
        int randomNumber = Random.Range(Bullet, Amount);

        theKnumber = randomNumber;
    }
   
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Tries >= 1)
        {
            if (Input.GetKeyDown(KeyCode.E))
            {
                --Tries;
                Debug.Log("THe number is" + " " + theKnumber);
                if (theKnumber == 6) 
                {
                    SceneManager.LoadScene("GameOver");

                }

            }
        }
       

    }
}
