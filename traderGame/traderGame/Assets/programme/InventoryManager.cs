using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class InventoryManager : MonoBehaviour
{

    static InventoryManager instance;

    public Inventory myBag;
    public GameObject Cn1Grid;
    public Cn Cn1Prefab;
    void Awake()
    {
        if (instance != null)
            Destroy(this);
        instance = this;
    }

    private void OnEnable()
    {
        RefreshItem();
    }
    public static void CreateNewItem(item item)
    {
        Cn newItem = Instantiate(instance.Cn1Prefab, instance.Cn1Grid.transform.position, Quaternion.identity, instance.Cn1Grid.transform);
        newItem.gameObject.transform.SetParent(instance.Cn1Grid.transform);
        newItem.Cn1item = item;
        newItem.Cn1image.sprite = item.itemImage;
        newItem.Cn1num.text = item.itemHeld.ToString();
        newItem.money = item.Sell;
        newItem.Random1 = item.Random;
        newItem.Cn1Buy = item.Buy;  
    }

    public static void RemoveItem(item _item)
    {
        for (int i = 0; i < instance.myBag.itemlist.Count; i++)
        {
            if (_item == instance.myBag.itemlist[i])
            {
         
                instance.myBag.itemlist.Remove(instance.myBag.itemlist[i]);
            }
        }
    }
    public static void RefreshItem()
    {
        for (int i = 0; i < instance.Cn1Grid.transform.childCount; i++)
        {
            if (instance.Cn1Grid.transform.childCount == 0)
            {
                break;
            }
            else
            {
                Destroy(instance.Cn1Grid.transform.GetChild(i).gameObject);
            }


        }

        for (int i = 0; i < instance.myBag.itemlist.Count; i++)
        {
            CreateNewItem(instance.myBag.itemlist[i]);
        }

    }
}