using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
public int speed; //set speed value
public float hInput; //horizontal input
public float vInput; //vertical input
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
      hInput = Input.GetAxis("Horizontal"); //left and right movement
      vInput = Input.GetAxis("Vertical"); //Foward and Backward
      
      Transform.Translate(Vector3.right * speed * hInput * Time.deltaTime); //move character right and left
      Transform.Translate(Vector3.forward * speed * vInput * Time.deltaTime); //move character foward and back
    }
}