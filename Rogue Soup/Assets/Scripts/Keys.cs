using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Keys : MonoBehaviour
{
 
 void OnTriggerEnter2D(Collider2D other)
    {
        //Pickup
        if (other.GameObject.CompareTag("Player"))
        {
            gm.AddKey(amount);// add pickup to inventory
            Destroy(gameObject);// Destroy pickup
        }
    }
}
