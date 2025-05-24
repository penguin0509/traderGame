using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
public class Cn : MonoBehaviour
{
    public item Cn1item;
    public Image Cn1image;
    public Text Cn1num;
    public int Cn1Buy;
    public int money;
    public int Random1;
    public int Randomnumber;
    public int a;

    public void Sell()
    {
        Randomnumber = 0;

        // 執行 100 次隨機機率
        for (int i = 0; i < 100; i++)
        {
            int ran = Random.Range(0, 5);
            if (ran == 1)
            {
                Randomnumber++;
            }
        }

        if (Cn1item.itemHeld <= 0) return; // 這格沒道具了就直接跳出

        if (Randomnumber >= Random1)
        {
            // 成功賣出
            printfSellBuy.TF = true;
            printfSellBuy.printfTF = false;
            printfSellBuy.Sell = money;
            goods.playermoney += money;
            TimeDay.Allmoney += money;
        }
        else
        {
            // 折半收購
            printfSellBuy.printfTF = true;
            printfSellBuy.TF = false;
            printfSellBuy.Buy = Cn1Buy / 2;
            goods.playermoney += (Cn1Buy / 2);
            TimeDay.Allmoney += (Cn1Buy / 2);
        }

        Cn1item.itemHeld--;      // 扣 1 個
        RefreshCount();          // ✅ 更新 UI 上顯示數量

        if (Cn1item.itemHeld <= 0)
        {
            InventoryManager.RemoveItem(Cn1item); // 從資料中移除
            Destroy(gameObject);                 // ✅ 移除 UI slot
        }
    }
        public void RefreshCount()
    {
        Cn1num.text = Cn1item.itemHeld.ToString();
    }
}
