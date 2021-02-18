using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterControllerBase : Controller
{
    [Header("Character")]

    [SerializeField] protected float _maxHealth = 1000f;
    [SerializeField] protected float _currentHealth = 1000f;
    [SerializeField] protected float _maxMana = 1000f;
    [SerializeField] protected float _currentMana = 1000f;

    [Header("Movement")]
    [SerializeField] protected CharacterMovement _characterMovement;
    


    protected BuffEffect[] _buffEffects;
    protected DataTable _dataTable;
    protected Inventory _inventory;

    #region property
    public DataTable DataTable => _dataTable;
    public Inventory PropertyList => _inventory;

    #endregion

    protected void Awake()
    {
        //_dataTable = DataTable.NewDataTable(maxHealth, currentHealth, maxMana, currentMana);
    }

    protected void Start()
    {
        //GetComponent<BuffEffect>().RunEffect();
    }
}
