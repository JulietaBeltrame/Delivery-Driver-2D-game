using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Driver : MonoBehaviour
{
    [SerializeField] float steerSpeed = 1f;
    [SerializeField] float moveSpeed = 20f;
    [SerializeField] float slowSpeed = 15f;
    [SerializeField] float boostSpeed = 30f;
    
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float steerAmount = Input.GetAxis("Horizontal") * steerSpeed * Time.deltaTime;
        float moveAmount = Input.GetAxis("Vertical") * moveSpeed * Time.deltaTime;
        transform.Rotate(0,0,-steerAmount);
        transform.Translate(0,moveAmount,0);
    }

    void OnTriggerEnter2D(Collider2D other){
        if (other.tag == "booster"){
            Debug.Log("Speed upppppp");
            moveSpeed = boostSpeed;
        }
        if (other.tag == "slow"){
            Debug.Log("oh no slow down");
            moveSpeed = slowSpeed;
        }
    }
    void OnCollisionEnter2D(Collider2D other){
        if (other.tag == "slow"){
            Debug.Log("oh no slow down");
            moveSpeed = slowSpeed;
        }
    }
}
