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
    protected Transform _transform;


    #region property
    public DataTable DataTable => _dataTable;
    public Inventory Inventory => _inventory;

    #endregion

    protected virtual void Awake()
    {
        _transform = GetComponent<Transform>();
        //_dataTable = DataTable.NewDataTable(maxHealth, currentHealth, maxMana, currentMana);
    }

    protected virtual void Start()
    {
        //GetComponent<BuffEffect>().RunEffect();
    }
}
