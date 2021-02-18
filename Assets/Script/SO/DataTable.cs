using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Playables;

//COPYRIGHT by George Cui
public class DataTable
{
    #region health
    public float maxHealth { get; private set; }
    public float currentHealth { get; private set; }
    #endregion

    #region mana
    public float maxMana { get; private set; }
    public float currentMana { get; private set; }
    #endregion


    public float HealthPercentage => currentHealth / maxHealth;
    public float ManaPercentage => currentMana / maxMana;

    #region Functions

    private DataTable (float maxHealth, float currentHealth, float maxMana, float currentMana)
    {
        this.maxHealth = maxHealth;
        this.currentHealth = currentHealth;
        this.maxHealth = maxMana;
        this.currentMana = currentMana;
    }

    public DataTable NewDataTable (float maxHealth, float currentHealth, float maxMana, float currentMana)
    {
        return new DataTable(maxHealth, currentHealth, maxMana, currentMana);
    }

    public void Initialize()
    {
        currentHealth = maxHealth;
        currentMana = maxMana;
    }

    


    #endregion

}
