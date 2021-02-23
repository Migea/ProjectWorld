using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using NaughtyAttributes;

[RequireComponent(typeof(Collider2D))]
public class ItemElement : ItemBase
{
    
    [Dropdown("ElementTypes")]
    public ElementBase _element;



    private ElementBase[] ElementTypes = new ElementBase[] {ObjectGroups.FireStatic, ObjectGroups.IceStatic, ObjectGroups.LightStatic};
    


    #region property
    public ElementBase Element
    {
        get
        {
            return _element;
        }
        set
        {
            _element = value;
        }
    }
    #endregion


    protected override void Awake()
    {
        _itemName = _element.ItemName;
        base.Awake();
        
    }


    protected void OnCollisionEnter2D(Collision2D collision)
    {
        PlayerController player = collision.gameObject.GetComponent<PlayerController>();
        if (player != null)
        {
            _element.AddToPlayerInventory(player);
            Destroy(gameObject);
        }
        
    }


}
