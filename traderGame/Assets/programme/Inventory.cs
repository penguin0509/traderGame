using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu (fileName = "New Item",menuName ="Goods/New Inventory")]
public class Inventory : ScriptableObject
{
    public List<item> itemlist = new List<item>();
    
    
}
