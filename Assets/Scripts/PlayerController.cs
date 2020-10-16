using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float speedMultiplier = 4f;

    private float _movementHorizontal, _movementVertical;
    private Rigidbody _rigidbody;
    
    // Awake is called as this initialize
    private void Awake()
    {
        
    }

    // Start is called before the first frame update
    void Start()
    {
        _rigidbody = gameObject.GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    // FixedUpdate is called 60 times per sec.
    private void FixedUpdate()
    {
        _movementHorizontal = Input.GetAxis("Horizontal") * speedMultiplier;
        _movementVertical = Input.GetAxis("Vertical") * speedMultiplier;
        
        _rigidbody.AddForce(_movementHorizontal, 0,_movementVertical, ForceMode.Acceleration);
    }

    private void OnCollisionEnter(Collision other)
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Coin")) // Detection of Coin
        {
            GameObject.Destroy(other.gameObject); // Destroy Coin
        }
    }
}