using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;



public class ItemBase : MonoBehaviour
{
    protected string _itemName;

    protected virtual void Awake()
    {
        if (TryGetComponent<Collider2D>(out Collider2D collider))
        {
            collider.isTrigger = true;
        }
    }

}
