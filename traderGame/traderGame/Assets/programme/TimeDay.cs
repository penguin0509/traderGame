using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.Threading.Tasks;
public class TimeDay : MonoBehaviour
{
    [SerializeField]
    public static int Allmoney;
    public static int Allgoods;
    public int time = 0;
    public int day = 1;
    public float a = 0;
    public SpriteRenderer Image;
    public Text TimeController_UI;
    public Text TimeController2_UI;
    public Text ShopDoom_UI;
    public Text Allmoney_UI;
    public Text AllGoods_UI;
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("timer", 1, 1);
    }

    void FixedUpdate()
    {
        Image.color = new Color(255, 255, 255, a);
        TimeController_UI.text = "第" + day + "天";
        ShopDoom_UI.text = "目前店面開銷:\n-$" + (int)(goods.playermoney * 0.15f);
        Allmoney_UI.text = "總銷售額:\n+$" + Allmoney;
        AllGoods_UI.text = "總進貨數:\n+" + Allgoods + "件";
    }

    // Update is called once per frame
    void timer()
    {
        time += 1;
        a += 0.006f;
        if (time >= 182)
        {
            Image.color = new Color(255, 255, 255, 0f);
            time = 0;
            a = 0;
            day++;
            goods.playermoney = (int)(goods.playermoney * 0.85f);
        }

    }
}
