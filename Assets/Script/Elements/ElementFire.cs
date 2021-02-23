using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ElementFire : ElementBase
{
    public override string ItemName { get { return ObjectGroups.ItemFire; }}
    public ElementFire()
    {

    }

    public override void AddToPlayerInventory(PlayerController playerController)
    {
        playerController.Inventory.AddFire();
    }
}
