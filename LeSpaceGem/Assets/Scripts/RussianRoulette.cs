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

    // Start is called before the first frame update
  
   
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
}
