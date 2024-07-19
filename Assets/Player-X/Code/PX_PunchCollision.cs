using System;
using System.Collections;
using System.Collections.Generic;
using PlayerX;
using UnityEngine;

public class PX_PunchCollision : MonoBehaviour
{
    [Header("- Punch Damage")]
    public float punchDamage;

    private bool canDamage = false;

    private void OnCollisionEnter(Collision col)
    {
        if (canDamage && col.gameObject.transform.root != this.transform.root)
        {
            PX_Health targetHealth = col.gameObject.transform.root.GetComponent<PX_Health>();
            if (targetHealth != null)
            {
                targetHealth.TakeDamage(punchDamage);
                canDamage = false;
            }
        }
    }

    public void EnableDamage(float damage)
    {
        punchDamage = damage;
        canDamage = true;
    }

    public void DisableDamage()
    {
        canDamage = false;
    }
}
