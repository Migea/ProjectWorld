using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ElementIce : ElementBase
{
    public override string ItemName { get { return ObjectGroups.ItemIce; } }
    public ElementIce(){}

    public override void AddToPlayerInventory(PlayerController playerController)
    {
        playerController.Inventory.AddIce();
    }
}
