using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine.Events;
using System;
using UnityEngine;

public class InputActionListener : MonoBehaviour
{
    [SerializeField] private InputActionReference _input;

    public UnityEvent OnPerformed;

    private void OnEnable()
    {
        _input.action.performed += ActionPerformed;
    }

    private void ActionPerformed(InputAction.CallbackContext obj)
    {
        OnPerformed.Invoke();
    }

    private void OnDisable()
    {
        _input.action.performed -= ActionPerformed;
    }

    private void Invoke()
    {
        OnPerformed.Invoke();
    }
}
