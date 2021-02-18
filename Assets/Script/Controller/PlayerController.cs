using System;
using System.Collections;
using System.Collections.Generic;
using Cinemachine;
using UnityEngine;
using UnityEngine.InputSystem;
using static UnityEngine.InputSystem.InputAction;

[RequireComponent(typeof(Rigidbody2D))]
[RequireComponent(typeof(BoxCollider2D))]
public class PlayerController : CharacterControllerBase
{
    [Header("Movement")]
    [SerializeField] protected Vector2 _moveInput;



    public void OnMove(InputValue value)
    {
        _moveInput = value.Get<Vector2>();
    }

    private void Update()
    {
        Vector3 worldSpeedMovement = new Vector3(_moveInput.x, 0f, _moveInput.y);
        _characterMovement.SetMoveInput(worldSpeedMovement);
    }

}
