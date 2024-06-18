using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardDatabase : MonoBehaviour
{
    public static List<Cards> cardlist = new List<Cards>();
   void Awake()
    {
        cardlist.Add(new Cards(0,"None",0,0,"None"));
        cardlist.Add(new Cards(1,"None",1,0,"None"));
    }
    
}
