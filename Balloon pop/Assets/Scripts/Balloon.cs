using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Balloon : MonoBehaviour
{
    public int scoreToGive = 100;

    public int clickToPop = 3;

    public float scaleToIncrease = 0.10f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void OnMouseDown()
    {
        clickToPop -= 1;

        transform.localScale += Vector3.one * scaleToIncrease;

        

    }
}
