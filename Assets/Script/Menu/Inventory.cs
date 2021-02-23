using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Inventory : ScriptableObject
{
    private int NumberOfIce = 0;
    private int NumberOfFire = 0;
    private int NumberOfLight = 0;

    #region property 
    
    #endregion




    public void ResetAll()
    {
        NumberOfIce = 0;
        NumberOfFire = 0;
        NumberOfLight = 0;
    }

    public void AddIce() { NumberOfIce += 1; }
    public void AddFire() { NumberOfFire += 1; }
    public void AddLight() { NumberOfLight += 1; }
}
