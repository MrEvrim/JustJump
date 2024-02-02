using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody), typeof(BoxCollider))]
public class PlayerController : MonoBehaviour
{
    [SerializeField] private Rigidbody _rb;
    [SerializeField] private FixedJoystick _js;
    [SerializeField] private Animator _ani;
    [SerializeField] private float _moveSpeed;
    private void FixedUpdate()
    {
        _rb.velocity = new Vector3(_js.Horizontal * _moveSpeed, _rb.velocity.y, _js.Vertical * _moveSpeed);



        if (_js.Horizontal != 0 || _js.Vertical != 0)
        {
            transform.rotation = Quaternion.LookRotation(_rb.velocity);
            if ((_js.Horizontal >= 0.1 && _js.Horizontal <= 0.3) ||
                (_js.Horizontal >= -0.1 && _js.Horizontal <= -0.3))
            {
                _ani.SetBool("IsWalking", true);
                _ani.SetBool("IsRuning", false);
            }
            else if ((_js.Vertical >= 0.1 && _js.Vertical <= 0.3) ||
                     (_js.Vertical >= -0.1 && _js.Vertical <= -0.3))
            {
                _ani.SetBool("IsWalking", true);
                _ani.SetBool("IsRuning", false);
            }
            if ((_js.Horizontal >= 0.31 && _js.Horizontal <= 1) ||
             (_js.Horizontal >= -0.31 && _js.Horizontal <= -1))
            {
                _ani.SetBool("IsWalking", false);
                _ani.SetBool("IsRuning", true);
            }
            else if ((_js.Vertical >= 0.31 && _js.Vertical <= 1) ||
                     (_js.Vertical >= -0.31 && _js.Vertical <= -1))
            {
                _ani.SetBool("IsWalking", false);
                _ani.SetBool("IsRuning", true);
            }

        }
        else
        {
            _ani.SetBool("IsRuning", false);
            _ani.SetBool("IsWalking", false);
        }
        // Başka işlemler
    }
}





