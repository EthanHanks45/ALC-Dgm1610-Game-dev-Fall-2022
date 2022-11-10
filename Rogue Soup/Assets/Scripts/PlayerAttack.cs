using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAttack : MonoBehaviour
{
    public float startDelay;
    public Transform attackPos;
    public LayerMask whatIsEnimies;
    public float attackRange;
    public int damage;
    private float attackDelay;
    // Start is called before the first frame update
    void Start()
    {
        if(attackDelay <= 0)
        {
            if(Input.GetKey(KeyCode.Space))
            {
                Collider2D[] enemiesToDamage = Physics2D.OverlapCircleAll(attackPos.position, attackRange, whatIsEnimies);

                for(int i = 0; i < enemiesToDamage.Length; i++)
                {
                    enemiesToDamage[i].GetComponent<EnemyHealth>().TakeDamage(damage);
                }
            }
            attackDelay = startDelay;
        }
        else
        {
            attackDelay -= Time.deltaTime;
        }
    
    }

    // Update is called once per frame
    void OnDrawGizmosSelected()
    {
        Gizmos.color = Color.red;
        Gizmos.DrawWireSphere(attackPos.position, attackRange);
    }
}
