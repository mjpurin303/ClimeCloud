using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    Rigidbody2D rigid2D;
    Animator animator;
    float jumpForce = 680.0f;
    float walkForce = 30.0f;
    float maxWalkSpeed = 2.0f;

    void Start()
    {
        Application.targetFrameRate = 60;
        rigid2D = GetComponent<Rigidbody2D>();
        animator = GetComponent<Animator>();

    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            rigid2D.AddForce(transform.up * jumpForce);
        }

        int key = 0;
        if (Input.GetKey(KeyCode.RightArrow)) key = 1;
        if (Input.GetKey(KeyCode.LeftArrow)) key = -1;

        float speedx = Mathf.Abs(rigid2D.velocity.x);
        if (speedx < maxWalkSpeed)
        {
            rigid2D.AddForce(transform.right * key * walkForce);
        }
        if (key != 0)
        {
            transform.localScale = new Vector3(key, 1, 1);
        }
        animator.speed = speedx / 2.0f;

    }
    void OnTriggerEnter2D(Collider2D collision)
    {
        Debug.Log("ゴール");
        
    }
}
