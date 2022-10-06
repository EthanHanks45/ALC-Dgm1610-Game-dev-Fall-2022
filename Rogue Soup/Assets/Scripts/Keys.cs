using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Keys : PickUps
{
    private GameManager gm;
    void Start()
    {
        gm = GameObject.Find("GameManager").GetComponent<GameManager>();
    }
    void OnTriggerEnter2D(Collider2D other)
    {
        //Pickup
        if (other.gameObject.CompareTag("Player"))
        {
            gm.AddKey(amount);// add pickup to inventory
            Destroy(gameObject);// Destroy pickup
        }
    }
}
