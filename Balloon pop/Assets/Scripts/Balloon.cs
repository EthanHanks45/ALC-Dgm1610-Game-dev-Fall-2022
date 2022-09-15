using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Balloon : MonoBehaviour
{
    public int scoreToGive = 100;

    public int clickToPop = 3;// How many clicks before balloon pops

    public float scaleToIncrease = 0.10f;// Scale to increase each time the balloon is clicked


   private 

    // Start is called before the first frame update
    void Start()
    {
        //Refrence ScoreManager Component
       
    }

    // Update is called once per frame
    void OnMouseDown()
    {
        clickToPop -= 1;

        transform.localScale += Vector3.one * scaleToIncrease;

        if (clickToPop == 0)
        {
            
            Destroy(gameObject);
        }
    }
}
