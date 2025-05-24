using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Events;
public class printfSellBuy : MonoBehaviour
{
    [SerializeField]
    public Text SellBuy;
    public static bool TF;
    public static bool printfTF;
    public static int Sell;
    public static int Buy;
    // Start is called before the first frame update
    // Update is called once per frame

    public void Start()
    {
        SellBuy.text = "";
    }
    public void Update()
    {
        if (TF == true)
        {
            SellBuy.text = "顧客喜歡你\n\n這一件物品成功賣出\n+" + Sell;

        }
        else if (printfTF == true)
        {
            SellBuy.text = "<color=#FF1E00>顧客不喜歡這一件物品\n\n只好回收</color>\n+$" + Buy;
        }



    }
}
