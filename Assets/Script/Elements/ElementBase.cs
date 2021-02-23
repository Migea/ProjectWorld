using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public abstract class ElementBase
{
    public virtual string ItemName { get;}

    public virtual void AddToPlayerInventory(PlayerController playerController) { }
}
