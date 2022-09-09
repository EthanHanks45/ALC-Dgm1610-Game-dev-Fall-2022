using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public int speed;
    public float hInput;
    public float vInput;
    public float rotSpeed;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
         hInput = Input.GetAxis("Horizontal");
         vInput = Input.GetAxis("Vertical");

        transform.Rotate(Vector3.up, rotSpeed * hInput * Time.deltaTime);
        transform.Translate(Vector3.right * hInput * Time.deltaTime);
        transform.Translate(Vector3.forward * speed * vInput * Time.deltaTime);
    }
}
