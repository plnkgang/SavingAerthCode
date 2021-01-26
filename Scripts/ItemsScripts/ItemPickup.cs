using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemPickup : Interactable
{
    public Item item;

    PlayerStats playerStats;

    public override void Interact()
    {
        base.Interact();

        PickUp();
    }

    void PickUp()
    { 
        Debug.Log("Picking up " + item.name);
        bool wasPickedUp = Inventory.instance.Add(item); // Add item to inventory

        if (wasPickedUp)
            Destroy(gameObject);
    }
}
