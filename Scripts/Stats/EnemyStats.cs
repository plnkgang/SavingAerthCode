using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyStats : CharacterStats
{
    public override void Die()
    {
        base.Die();

        PlayerStats.instance.killsCount++;

        // Add ragfoll effect / death animation
        Destroy(gameObject);
    }

}
