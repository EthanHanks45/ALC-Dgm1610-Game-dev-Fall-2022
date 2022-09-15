using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Float : MonoBehaviour
{
    public float moveSpeed = 1.0f;
    public float upperBound = 25.0f;
    private Balloon balloon;
     
    // Start is called before the first frame update
    void Start()
    {
        balloon = GetComponent<Balloon>();
    }

    // Update is called once per frame
    void Update()
    {
        // Destroy balloon after it passes upperbound
        transform.Translate(Vector3.up * moveSpeed * Time.deltaTime);
        if(transform.position.y > upperBound)
        {
            Destroy(gameObject);
        }
    }
}
