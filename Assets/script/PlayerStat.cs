using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerStat : CharacterStat
{
    // Start is called before the first frame update
    void Start()
    {
        
    }
    public override void Die()
    {
        Debug.Log(transform.name + "child die");

    }
    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.T))
        {
            TakeDamage(10);
        }
    }
}
