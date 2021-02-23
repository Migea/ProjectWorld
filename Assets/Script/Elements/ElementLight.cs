using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ElementLight : ElementBase
{
    public override string ItemName { get { return ObjectGroups.ItemLight; } }
    public ElementLight(){}

    public override void AddToPlayerInventory(PlayerController playerController)
    {
        playerController.Inventory.AddLight();
    }
}
