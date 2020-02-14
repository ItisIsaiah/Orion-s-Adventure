using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Melee : MonoBehaviour
{
   
    public int ammo=0;
    public double damage = 0;
    public Animator ani;
    public float attackRange = 0.5f;
    public LayerMask enemies;
    public Transform attackPoint;
    // Update is called once per frame
    void Update()
    {
        
    }
    public void attack()
    {
        ani.SetTrigger("Attack");

        Collider2D[] hitenemy = Physics2D.OverlapCircleAll(attackPoint.position, attackRange, enemies);

        foreach (Collider2D enemy in hitenemy)
        {
            enemy.GetComponent<Enemy>().TakeDamage(damage);
        }

        void OnDrawGizmosSelected()
        {
            if (attackPoint = null)
            {
                return;
            }
            Gizmos.DrawWireSphere(attackPoint.position, attackRange);
        }
    }
}
