using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMovement : MonoBehaviour
{
    public GameObject player;
    private float xmove = 0;
    private float ymove = 0;
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


    void Update()
    {
        CameraAngle();
        CameraLocation();
    }


    void CameraAngle()
    {
        if (Input.GetMouseButton(1) || Input.GetMouseButton(0))
        {
            xmove += Input.GetAxis("Mouse X") * Sensitivity;
            ymove -= Input.GetAxis("Mouse Y") * Sensitivity;
        }
        if (ymove > yLimitation) ymove = yLimitation;
        if (ymove < -10) ymove = -10;
        transform.rotation = Quaternion.Euler(ymove, xmove, 0);
    }


    void CameraLocation()
    {
        distance -= Input.GetAxis("Mouse ScrollWheel") * 7;
        if (distance > MaxDis) distance = MaxDis;
        if (distance < MinDis) distance = MinDis;
        Vector3 reverseDistance = new Vector3(0.0f, -1.0f, distance);
        transform.position = player.transform.position - transform.rotation * reverseDistance;
    }
}
