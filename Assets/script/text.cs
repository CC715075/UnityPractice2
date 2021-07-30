using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class text : MonoBehaviour
{
    TextMeshPro Counts;
    // Start is called before the first frame update
    void Start()
    {
        Counts = transform.GetComponent<TextMeshPro>();

    }

    // Update is called once per frame
    void Update()
    {
        //Counts.text = "123";
    }
}
