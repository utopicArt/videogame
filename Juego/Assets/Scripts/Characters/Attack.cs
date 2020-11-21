using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Attack : MonoBehaviour
{
    private Animator _animator;
    private Weapon _weapon;

    void Awake()
    {
        _animator = GetComponent<Animator>();
        _weapon = GetComponentInChildren<Weapon>();
    }

    void Start()
    {
        _animator.SetBool("Idle", true);
    }

    void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            _animator.SetTrigger("Shoot");
        }        
    }

    void CanShoot()
    {
        if (_weapon != null)
        {
            StartCoroutine(_weapon.ShootWithRaycast());
        }
    }
}