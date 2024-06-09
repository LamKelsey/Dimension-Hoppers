using System.Collections;
using System.Collections.Generic;
using System.Xml.Linq;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.Rendering;
[System.Serializable]

public class Cards : MonoBehaviour
{
    public int id;
    public string title;
    public int cost;
    public int damage;
    public string description;

    public Cards()
    {

    }

    public Cards(int id, string title, int cost, int damage, string description)
    {
      
    }
}
