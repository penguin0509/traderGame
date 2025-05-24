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
            if (instance.myBag.itemlist[i] == _item)
            {
                if (_item.itemHeld > 1)
                {
                    instance.myBag.itemlist[i].itemHeld--;
                }
                else
                {
                    instance.myBag.itemlist.RemoveAt(i);
                }
                break;
            }
        }
        UpdateItemUI(_item);
    }
    public static void RefreshItem()
    {
        // 先清除所有現有 UI 元件（由後往前刪除較安全）
        Transform grid = instance.Cn1Grid.transform;
        for (int i = grid.childCount - 1; i >= 0; i--)
        {
            Object.Destroy(grid.GetChild(i).gameObject);
        }

        // 依照背包內容重建 UI
        foreach (var item in instance.myBag.itemlist)
        {
            CreateNewItem(item);
        }
    }
    public static void UpdateItemUI(item _item)
    {
        Cn[] allSlots = instance.Cn1Grid.GetComponentsInChildren<Cn>();
        foreach (var slot in allSlots)
        {
            if (slot.Cn1item == _item)
            {
                slot.RefreshCount();
                break;
            }
        }
    }
}