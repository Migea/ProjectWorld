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
    private readonly ElementBase[] ElementGroups = ObjectGroups.ElementGroups;



    #region property
    public ElementBase Element => _element;
    #endregion


    protected override void Awake()
    {
        if (_element == null)
        {
            _element = ElementGroups[UnityEngine.Random.Range(0, ElementGroups.Length)];
        }
        _itemName = _element.ItemName;
        base.Awake();
        
    }


    protected void OnCollisionEnter2D(Collision2D collision)
    {
        PlayerController player = collision.gameObject.GetComponent<PlayerController>();
        if (player != null)
        {
            _element.AddToPlayerInventory(player);

            //particals instantiate

            Destroy(gameObject);
        }
        
    }


}
