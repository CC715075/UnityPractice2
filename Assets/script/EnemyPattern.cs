using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyPattern : MonoBehaviour
{

    public int health = 50;
    public int attack = 10;
    public float attackSpeed = 0.5f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void BasicAttack(GameObject player)
    {
        if (Vector3.Distance(player.transform.position, transform.position)< 10)
        {

        }
        else
        {

        }
    }


    void CrushedSoul(GameObject tanker)
    {

    }


    void MasterOfDeath(GameObject player)
    {

    }


    void CosmicAritifice(GameObject player)
    {

    }


    void ShatterReality()
    {

    }
}
