using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerMovement : MonoBehaviour
{
    Rigidbody rb;
    public float speed;
    // Start is called before the first frame update
    void Start()
    {
        speed = 10;
        rb = gameObject.GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        float h = Input.GetAxisRaw("Horizontal");
        if (h != 0)
        {
        Move(h);

        }
    }

    void Move(float h)
    {
        if (h < 0)
        {
            rb.velocity = new Vector3(speed, rb.velocity.y, rb.velocity.z);
        }
        else if (h > 0)
        {
            rb.velocity = new Vector3(-speed, rb.velocity.y, rb.velocity.z);

        }
    }
}
