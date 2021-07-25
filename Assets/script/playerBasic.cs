using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerBasic : MonoBehaviour
{

    // singleton
    private static playerBasic _instance;
    public static playerBasic Instance { get { return _instance; } }
    private void Awake()
    {
        if (_instance != null && _instance != this)
        {
            Destroy(this.gameObject);
        } else
        {
            _instance = this;
        }
    }

    
    public int health = 50;
    public int mana = 50;

    public int attack = 10;
    public float attackSpeed = 0.5f;

    private float currentValue;

    public float myMaxValue { get; set; }

    public float myCurrentValue
    {
        get
        {
            return currentValue;
        }

        set
        {
            if (value > myMaxValue) currentValue = myMaxValue;
            else if (value < 0) currentValue = 0;
            else currentValue = value;
        }
    }

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void StatManager(int health, int mana)
    {
    }
}
