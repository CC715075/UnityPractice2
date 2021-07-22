using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerMovement : MonoBehaviour
{
    public GameObject cam;
    Rigidbody rb;
    public float speed;
    Animation ani;
    // Start is called before the first frame update
    void Start()
    {

        ani = gameObject.GetComponent<Animation>();
        rb = gameObject.GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        PlayerLootAt();
        Move();
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
        rb.velocity = (normalVec)*speed;
    }
}
