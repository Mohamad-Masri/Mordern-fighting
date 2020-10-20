using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class attack : MonoBehaviour
{

	public Animator anim;

	public Transform attackPoint;
	public float attackRange;
	public LayerMask enemyLayers;

	public static int enemyHealth = 100;
    
    void Start()
    {
        
    }

    
    void Update()
    {
        if (Input.GetKey (KeyCode.C))
        {
       		ShortHit();
        }
    }

    public void ShortHit()
    {
    	anim.SetTrigger("ShortHit");

    	Collider2D[] hitEnemies = Physics2D.OverlapCircleAll(attackPoint.position, attackRange, enemyLayers);

    	foreach(Collider2D enemy in hitEnemies)
    	{
    		enemyHealth --;
    	}
    }

    void OnDrawGizmosSelected()
    {
    	if (attackPoint == null)
    		return;

    	Gizmos.DrawWireSphere(attackPoint.position, attackRange); 
    }
}
