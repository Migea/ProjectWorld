using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Globalization;
using System;

public static class ObjectGroups
{


    #region elements
    public static ElementFire FireStatic { get; private set;} = new ElementFire();
    public static ElementIce IceStatic { get; private set; } = new ElementIce();
    public static ElementLight LightStatic { get; private set; } = new ElementLight();
    #endregion



    #region itemNames
    public static readonly string ItemFire = "Element Fire";
    public static readonly string ItemIce = "Element Ice";
    public static readonly string Light = "Element Light";
    #endregion


    #region IceUpgradeCode
    public static readonly int IncreaseControlTime = 0;
    public static readonly int IncreaseDamage = 1;
    public static readonly int IncreaseSlowRate = 2;
    #endregion




    #region groups
    public static readonly ElementBase[] ElementGroups
        = {FireStatic, IceStatic, LightStatic};





    #endregion


}
