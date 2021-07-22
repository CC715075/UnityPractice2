using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMovement : MonoBehaviour
{
    public GameObject player;
    private float xmove = 0;
    private float ymove= 0;
    float distance;
    public float MaxDis;
    public float MinDis;
    public float Sensitivity;

    [SerializeField]
    private float yLimitation;




    void Start()
    {
        distance = 20f;
    }

    // Update is called once per frame
    void Update()
    {

        //camera angle
        if (Input.GetMouseButton(1))
        {
            xmove += Input.GetAxis("Mouse X")* Sensitivity; 
            ymove -= Input.GetAxis("Mouse Y")* Sensitivity; 
        }
        if (ymove > yLimitation) ymove = yLimitation;
        if (ymove < 0) ymove = 0;
        transform.rotation = Quaternion.Euler(ymove, xmove , 0); 

        //camera location
        distance -= Input.GetAxis("Mouse ScrollWheel")*7;
        if (distance > MaxDis) distance = MaxDis;
        if (distance < MinDis) distance = MinDis;
        Vector3 reverseDistance = new Vector3(0.0f, -1.0f, distance); 
        transform.position = player.transform.position - transform.rotation * reverseDistance;

    }
}
