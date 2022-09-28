using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
   public float speed; // How fast the player moves
   public float hInput;// Horizontial Input
   public float vInput;// Vertical Input
   
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        hInput = Input.GetAxis("Horizontial");
        vInput = Input.GetAxis("Vertical");
        transform.Translate(Vector2.right * hInput * speed * Time.deltaTime);// Moves player Right and Left
        transform.Translate(Vector2.up * vInput * speed * Time.deltaTime);// Moves player left and right
    }
}
