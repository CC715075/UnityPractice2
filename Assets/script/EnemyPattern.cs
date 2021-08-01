using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyPattern : MonoBehaviour
{
    public GameObject Cosmic;
    public GameObject player;
    Animator ani;
    // Start is called before the first frame update
    void Start()
    {
        ani = GetComponent<Animator>(); 
    }

    // Update is called once per frame
    void Update()
    {
        BasicAttack(player); // is this fit in Patterns or Stat?
    }

    void BasicAttack(GameObject player)
    {
        if (Vector3.Distance(player.transform.position, transform.position) < 30)
        {
            ani.SetBool("isAttacking", true);
        }
        else
        {
            ani.SetBool("isAttacking", false);
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
