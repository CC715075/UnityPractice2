using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Xml;

public class StatManager : MonoBehaviour
{
    readonly string xmlFileName = "StatTable";

    private void LoadXML(string _fileName)
    {
        TextAsset txtAsset = (TextAsset)Resources.Load("C:/Users/User/New Unity Project/Assets/xml/" + _fileName );
        XmlDocument xmlDoc = new XmlDocument();
        xmlDoc.LoadXml(txtAsset.text);
        XmlNodeList costTable = xmlDoc.GetElementsByTagName("text");
        foreach (XmlNode i in costTable)
        {
            Debug.Log(i);

        }

    }
    // singleton
    private static StatManager _instance;
    public static StatManager Instance { get { return _instance; } }
    private void Awake()
    {
        

        if (_instance != null && _instance != this)
        {
            Destroy(gameObject);
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
        LoadXML(xmlFileName);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    
}
