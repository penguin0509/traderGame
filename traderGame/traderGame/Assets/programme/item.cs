using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName ="New item",menuName = "Goods/New Item")]
public class item : ScriptableObject
{
    public string itemName;
    public Sprite itemImage;
    public  int itemHeld;
    [TextArea]
    public string itemInfo;
    public bool Lvneed;
    public int Sell;
    public int Buy;
    public int Random;


}
