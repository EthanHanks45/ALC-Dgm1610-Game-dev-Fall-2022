using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum PickupType
{
    Health,
    Ammo
}

public class Pickup : MonoBehaviour
{
    [Header("Pickup Stats")]
    public PickupType type;
    public int HealthAmount;
    public int ammoAmount;

    [Header("Bobbing Anim")]
    public float rotationSpeed;
    public float bobSpeed;
    public float bobHeight;

    private Vector3 StartPos;
    private bool bobbingUp;
    public AudioClip pickupSfx;
    // Start is called before the first frame update
    void Start()
    {
      StartPos = transform.position;  
    }

    void OnTriggerEnter(Collider other)
    {
        PlayerController player = other.GetComponent<PlayerController>();
        
        switch(type)
        {
            case PickupType.Health:
            player.GiveHealth(HealthAmount);
            break;

            case PickupType.Ammo:
            player.GiveAmmo(ammoAmount);
            break;
        }
        //other.GetComponent<AudioSource.().PlayOneShot(pickupSfx);

        Destroy(gameObject);
    }
    // Update is called once per frame
    void Update()
    {
       transform.Rotate(Vector3.up, rotationSpeed * Time.deltaTime);

       Vector3 offset = (bobbingUp == true ? new Vector3(0,bobHeight / 2, 0) : new Vector3(0,bobHeight /2, 0));
       transform.position = Vector3.MoveTowards(transform.position, StartPos + offset, bobSpeed * Time.deltaTime);

       if(transform.position == StartPos + offset)
       bobbingUp = !bobbingUp; 
    }
}
