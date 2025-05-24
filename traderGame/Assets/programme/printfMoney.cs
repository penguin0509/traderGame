using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.Threading.Tasks;

public class printfMoney : MonoBehaviour
{
    [SerializeField]
    public static int money;
    public Text Money_UI;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        money = goods.playermoney;
        Money_UI.text = money + "";
    }
}
