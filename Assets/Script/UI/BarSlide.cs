using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class BarSlide : MonoBehaviour
{
    [SerializeField] private DataTable _dataTable;

    private void Awake()
    {
        _dataTable = GetComponentInParent<Canvas>().GetComponentInParent<CharacterControllerBase>().DataTable;
        if (_dataTable == null)
        {
            Destroy(gameObject);
        }
    }
    private void Update()
    {
        float healthFill = 0;
        if (_dataTable != null)
        {
            healthFill = _dataTable.HealthPercentage;
        }
        GetComponentInChildren<HealthBar>().GetComponent<Image>().fillAmount = healthFill;
        GetComponentInChildren<ManaBar>().GetComponent<Image>().fillAmount = healthFill;
    }
}