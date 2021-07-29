using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Beacon : MonoBehaviour
{
    TextMeshPro Counts;
    GameObject txt;
    // Start is called before the first frame update
    void Start()
    {
        GameObject txt = transform.Find("Text").gameObject;
        GameObject obj = transform.Find("BeaconCylinder").gameObject;

        Counts = txt.GetComponent<TextMeshPro>();

    }

    // Update is called once per frame
    void Update()
    {
        Counts.text = "sdf";
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            Invoke("TimeCounts(obj)", 5);
        }
    }
    private void TimeCounts(GameObject counter)
    {
        counter.transform.position = new Vector3(41,0,-97);
    }

}
