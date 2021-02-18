using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class CharacterMovement : MonoBehaviour
{
    //[SerializeField] private Animator _animator;
    [SerializeField] private MovementAttributes _movementAttributes;
    [SerializeField] private Vector2 _moveInput;

    private Rigidbody2D _rigidbody;

    #region property

    public MovementAttributes MovementAttributes => _movementAttributes;
    public Vector3 MoveInput { get; private set; }
    public bool HasMoveInput { get; private set; }
    public Vector3 LookDirection { get; private set; }
    public bool CanMove { get; private set; }
    public float MoveSpeedMultiplier { get; set; } = 1f;
    public float ForcedMovement { get; set; } = 0f;
    public Vector3 Velocity
    {
        get => _rigidbody.velocity;
        set => _rigidbody.velocity = value;
    }

    #endregion

    private void Awake()
    {
        _rigidbody = GetComponent<Rigidbody2D>();
        _rigidbody.constraints = RigidbodyConstraints2D.FreezeRotation;
        _rigidbody.interpolation = RigidbodyInterpolation2D.Interpolate;
        _rigidbody.gravityScale = 0f;

        //LookDirection = _animator.transform.forward;
    }

    public void SetMoveInput(Vector3 input)
    {
        input.y = 0f;
        MoveInput = Vector3.ClampMagnitude(input, 1f);
    }

    private void FixedUpdate()
    {
        _rigidbody.AddForce(MoveInput * MovementAttributes.Speed);
    }

    private void Update()
    {
        
    }

}
