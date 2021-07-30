using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Beacon : MonoBehaviour
{
    TextMeshPro Counts;
    GameObject txt;
    public float Seconds;
    // Start is called before the first frame update
    void Start()
    {
        GameObject txt = GameObject.Find("Text");

        Counts = txt.transform.GetComponent<TextMeshPro>();

    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            //Counts.text = "123";
            GameObject enemy = GameObject.Find("Mueh'zala");
            GameObject cam = GameObject.Find("Main Camera");
            //cam.transform.LookAt(enemy.transform);
            other.transform.position = new Vector3(41,-3.1f,-97);
            other.transform.LookAt(enemy.transform);
            other.gameObject.GetComponent<Rigidbody>().velocity = Vector3.zero;

        }
    }

    private string CountdownTimer(bool isUpdate = true)
    {
        if (isUpdate) { }

        string timer = (Seconds - Time.deltaTime).ToString();
        return timer;
    }
    

}
