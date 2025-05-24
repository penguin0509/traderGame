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
        for (a = 0; a < 100; a++)
        {

            int ran = Random.Range(0, 5);
            if (ran == 1)
            {
                Debug.Log(Randomnumber);
                Randomnumber++;
                
            }

        }
        if (Randomnumber >= Random1 && a >= 100 && Cn1item.itemHeld > 0)
        {
            printfSellBuy.TF = true;
            printfSellBuy.printfTF = false;
            printfSellBuy.Sell = money;
            goods.playermoney += money;
            TimeDay.Allmoney += money;
            Randomnumber = 0;
            Cn1item.itemHeld--;
        }
        else if (Cn1item.itemHeld > 0)
        {
            printfSellBuy.printfTF = true;
            printfSellBuy.TF = false;
            printfSellBuy.Buy = Cn1Buy/2;
            Randomnumber = 0;
            TimeDay.Allmoney += (Cn1Buy / 2);
            goods.playermoney += (Cn1Buy / 2);
            Cn1item.itemHeld--;
            
        }


        if (Cn1item.itemHeld <= 0)
        {
            InventoryManager.RemoveItem(Cn1item);
            Destroy(gameObject);
        }
    }

}
