using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Door : MonoBehaviour
{
    private GameManager gm;
    public float doorDelay = 0.5f;
    // Start is called before the first frame update
    void Start()
    {
        gm=GameObject.Find("GameManager").GetComponent<GameManager>();
    }

    // Update is called once per frame
    void OnTriggerEnter2D(Collider2D other)
    {
       if(other.gameObject.CompareTag("Player") && gm.key >= 1)
       {
        Destroy(gameObject, doorDelay);
        gm.key --;
        Debug.Log("Keys = "+ gm.key);
        Debug.Log("Hooray!");
       }
       else
       {
            Debug.Log("A key is nedded.");
       }
    }
}