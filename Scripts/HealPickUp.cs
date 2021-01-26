using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealPickUp : Interactable
{
    PlayerStats playerStats;

    public override void Interact()
    {
        base.Interact();

        IncreaseHealCount();
    }

    void IncreaseHealCount()
    {
        playerStats.healsCount += 1;
    }
}
