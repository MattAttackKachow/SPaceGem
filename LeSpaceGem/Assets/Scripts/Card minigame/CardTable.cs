using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardTable : MonoBehaviour
{
    public Transform spawnPoint;
    public GameObject cardPrefab;

    public float cardSpeed = 20f;

    public float coolDown;

    public float currentCoolDown;

    // Update is called once per frame
    void Update()
    {
        currentCoolDown -= Time.deltaTime;

        if (Input.GetButtonDown("Fire1") && currentCoolDown <= 0f)
        {
            Spawn();

            currentCoolDown = coolDown;
        }
    }

    void Spawn()
    {
        GameObject card = Instantiate(cardPrefab, spawnPoint.position, spawnPoint.rotation);
        Rigidbody2D rb = card.GetComponent<Rigidbody2D>();
        rb.AddForce(spawnPoint.up * cardSpeed, ForceMode2D.Impulse);
    }
}
