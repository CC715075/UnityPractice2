using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Xml;

public class StatManager : MonoBehaviour
{
    readonly string xmlFileName = "StatTable";
    private int playerAttack;
    private float playerAttackSpeed;
    private int playerHP;
    private int playerMP;
    private int playerindex = 0;


    // singleton
    private static StatManager _instance;
    public static StatManager Instance { get { return _instance; } }
    private void Awake()
    {
        if (_instance != null && _instance != this)
        {
            Destroy(gameObject);
        }
        else
        {
            _instance = this;
        }
        LoadXML(xmlFileName);
    }


    private void LoadXML(string _fileName)
    {
        TextAsset txtAsset = Resources.Load<TextAsset>("xml/" + _fileName);
        XmlDocument xmlDoc = new XmlDocument();

        xmlDoc.LoadXml(txtAsset.text);
        XmlNodeList costTable = xmlDoc.GetElementsByTagName("text");

        XmlNode i = costTable[playerindex];
        playerAttack = int.Parse(i.SelectSingleNode("attack").InnerText);
        playerAttackSpeed = float.Parse(i.SelectSingleNode("attackSpeed").InnerText);
        playerHP = int.Parse(i.SelectSingleNode("hp").InnerText);
        playerMP = int.Parse(i.SelectSingleNode("mp").InnerText);
    }


    // making Columns name of XML
    private List<string> ListColumns(XmlNodeList costTable)
    {
        List<string> list = new List<string>();
        XmlNode i = costTable[playerindex];
        string str = i.FirstChild.Name;
        list.Add(str);
        while (true)
        {
            try
            {
                list.Add(i.SelectSingleNode(str).NextSibling.Name);
                str = i.SelectSingleNode(str).NextSibling.Name;
            }
            catch { break; }
        }
        return list;
    }
    public void LabelingStat(List<string> list)
    {
        foreach(string i in list)
        {
            name = "player" + i;

        }
    }
    

}
