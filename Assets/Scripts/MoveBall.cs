using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveBall : MonoBehaviour
{
    // Start is called before the first frame update
    public Rigidbody rb;

    public float moveSpeed = 10f;

    private float xInput;
    private float yInput;


    private float boostTime;
    private bool booster;


    private void Start()
    {
      
        boostTime = 0;
        booster = false;
    }
    private void Awake()
    {
        rb = GetComponent<Rigidbody>();
    }

    private void Update()
    {
        Inputs();
        if(booster)
        {
            boostTime += Time.deltaTime;
            if(boostTime >= 2 )
            {
                moveSpeed = 10f;
                boostTime = 0;
                booster = false;
            }
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.tag == "SpeedBooster")
        {
            booster = true;
            moveSpeed = 35f;
        }
    }
    private void FixedUpdate()
    {
        Move();
    }

    private void Inputs()
    {
        xInput = Input.GetAxis("Horizontal");
        yInput = Input.GetAxis("Vertical");
    }

    private void Move()
    {
        rb.AddForce(new Vector3(xInput, 0f, yInput) * moveSpeed);
    }
}
