using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CatMovement : MonoBehaviour
{
    // Movement variables
    public float speed;

    // Animation
    private Animator animator;

    public void Awake()
    {
        animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        Movement();
    }

    public void Movement()
    {
        float x = Input.GetAxis("Horizontal");
        float y = Input.GetAxis("Vertical");

        animator.SetBool("Walking", Mathf.Abs(x) > 0.0f || Mathf.Abs(y) > 0.0f);

        transform.Translate(x * speed * Time.deltaTime, y * speed * Time.deltaTime, 0.0f);
    }
}
