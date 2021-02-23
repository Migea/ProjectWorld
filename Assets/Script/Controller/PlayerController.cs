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


    private bool _isFiring;
    [SerializeField] private Vector3 _mousePosition;
    [SerializeField] private float _rotationMotifier;

    #region property

    public bool IsFiring => _isFiring;

    #endregion

    public void OnMove(InputValue input)
    {
        _moveInput = input.Get<Vector2>();
    }

    public void OnFire(InputValue input) {
        _isFiring = input.Get<float>() > 0.5f;
    }


    private void Update()
    {
        //Vector2 up = Vector2.up;
        //Vector2 right = Vector2.right;

        //Vector2 localMovement = right * _moveInput.x + up * _moveInput.y;

        //_characterMovement.SetMoveInput(localMovement);


        //Rotate player with mouse
        Vector3 dir = Input.mousePosition - Camera.main.WorldToScreenPoint(_transform.position);
        float angle = Mathf.Atan2(dir.y, dir.x) * Mathf.Rad2Deg;
        angle += _rotationMotifier;
        _transform.rotation = Quaternion.AngleAxis(angle, Vector3.forward);



    }
    
    private void FixUpdate()
    {
        


    }







}
