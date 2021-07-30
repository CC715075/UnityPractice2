using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Beacon : MonoBehaviour
{
    //text string init
    TextMeshPro Counts;
    private float Seconds;

    public float waitSec;
    private float initSec = - 500f;

    public GameObject Lookhere;
    GameObject teleportLoc;

    // Start is called before the first frame update
    void Start()
    {
        teleportLoc = transform.Find("BeaconExit").gameObject;
        Counts = GetComponentInChildren<TextMeshPro>();
        Seconds = initSec;
    }

    // Update is called once per frame
    void Update()
    {
        if (Seconds > 0) {Seconds -= Time.deltaTime;}
        if (Seconds < 0 && Seconds > -1) {Teleport(GameObject.FindWithTag("Player"), Lookhere);}

        //Count text to beacon
        if (Seconds <5.1f && Seconds > 0)
        {
        Counts.text = string.Format("{0:f0}", Seconds);
            if (Counts.text == "0")
            {
                Counts.text = "Good Luck!";
            }
        }

    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            Seconds = waitSec;
        }
    }
    private void OnTriggerExit(Collider other)
    {
        if(other.gameObject.tag == "Player")
        {
        Seconds = initSec;


        }
    }
    private void Teleport(GameObject other, GameObject lookhere)
    {

        GameObject enemy = GameObject.Find("seeHere");

        //teleport
        other.transform.position = teleportLoc.transform.position;

        //camera forced look
        GameObject.Find("Main Camera").GetComponent<CameraMovement>().CameraForced(lookhere);

        //doge look
        other.transform.LookAt(enemy.transform);
        other.gameObject.GetComponent<Rigidbody>().velocity = Vector3.zero;
    }

}
