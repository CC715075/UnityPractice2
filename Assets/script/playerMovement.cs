using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerMovement : MonoBehaviour
{
    public GameObject cam;
    Rigidbody rb;
    public float speed;
    public float jump;
    Animator ani;
    bool isAir = true;
    // Start is called before the first frame update
    void Start()
    {
        ani = GetComponent<Animator>();
        rb = gameObject.GetComponent<Rigidbody>();

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButton(1))
        {
            PlayerLootAt();
        }
        if (!isAir)
        {
            Move();
            Attack();

        }
    }


    void PlayerLootAt()
    {
        Vector3 offset = cam.transform.forward;
        offset.y = 0;
        transform.LookAt(transform.position + offset);
    }


    void Move()
    {   
        float h = Input.GetAxisRaw("Horizontal");
        float v = Input.GetAxisRaw("Vertical");
        Vector3 normalVec = (transform.right * h + transform.forward * v).normalized;
        rb.velocity = (normalVec) * speed;
        if (rb.velocity == Vector3.zero)
        {
            ani.SetBool("isWalking", false);
        }
        else 
        {
            ani.SetBool("isWalking", true);
        }
            
    }

    void Attack()
    {

        if (Input.GetKeyDown("space"))
        {
            ani.SetBool("isAttacking", true);
        }
        else
        {
            ani.SetBool("isAttacking", false);
        }

    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.layer == 6)
        {
            isAir = false;

        }
    }
    private void OnTriggerStay(Collider other)
    {
        if (other.gameObject.layer == 6)
        {
            isAir = false;
        }
    }
    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.layer == 6)
        {
            isAir = true;
        }
    }
}
