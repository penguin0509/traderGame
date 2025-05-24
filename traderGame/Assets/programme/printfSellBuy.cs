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
        ReSetText();
    }
    public void Update()
    {
        if (TF == true)
        {
            

        }
        else if (printfTF == true)
        {
            
        }



    }

    public void ReSetText()
    {
        SellBuy.text = "";
    }
}
