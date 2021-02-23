using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public static class ObjectGroups
{


    #region elements
    public static ElementFire FireStatic { get; private set;} = new ElementFire();
    public static ElementIce IceStatic { get; private set; } = new ElementIce();
    public static ElementLight LightStatic { get; private set; } = new ElementLight();
    #endregion

    #region itemNames
    public static string ItemFire = "Element Fire";
    public static string ItemIce = "Element Ice";
    public static string ItemLight = "Element Light";

    #endregion




    #region groups
    public static ElementBase[] ElementGroups
        = {FireStatic, IceStatic, LightStatic};





    #endregion
}
