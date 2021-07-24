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

        ani = gameObject.GetComponent<Animator>();
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
            Jump();

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
        ani.SetBool("isMoving", true);
        float h = Input.GetAxisRaw("Horizontal");
        float v = Input.GetAxisRaw("Vertical");
        Vector3 normalVec = (transform.right * h + transform.forward * v).normalized;
        rb.velocity = (normalVec) * speed;
    }

    void Jump()
    {

        if (Input.GetKeyDown("space"))
        {
            ani.SetBool("isJumping", true);
            Vector3 jumpVel = rb.velocity;
            jumpVel.y = jump;
            Debug.Log(jumpVel);
            rb.AddForce(jumpVel, ForceMode.Impulse);

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
