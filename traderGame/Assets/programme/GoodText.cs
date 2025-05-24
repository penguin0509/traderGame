using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class GoodText : MonoBehaviour
{
    [SerializeField]
    public Text Cn1Buy;
    public Text Cn1Sell;
    public static int Cn1Buyint;
    public static int Cn1Sellint;
    public Text Cn2Buy;
    public Text Cn2Sell;
    public static int Cn2Buyint;
    public static int Cn2Sellint;
    public Text Cn3Buy;
    public Text Cn3Sell;
    public static int Cn3Buyint;
    public static int Cn3Sellint;
    public Text Cn4Buy;
    public Text Cn4Sell;
    public static int Cn4Buyint;
    public static int Cn4Sellint;

    public Text Jp1Buy;
    public Text Jp1Sell;
    public static int Jp1Buyint;
    public static int Jp1Sellint;
    public Text Jp2Buy;
    public Text Jp2Sell;
    public static int Jp2Buyint;
    public static int Jp2Sellint;
    public Text Jp3Buy;
    public Text Jp3Sell;
    public static int Jp3Buyint;
    public static int Jp3Sellint;
    public Text Jp4Buy;
    public Text Jp4Sell;
    public static int Jp4Buyint;
    public static int Jp4Sellint;

    public Text Es1Buy;
    public Text Es1Sell;
    public static int Es1Buyint;
    public static int Es1Sellint;
    public Text Es2Buy;
    public Text Es2Sell;
    public static int Es2Buyint;
    public static int Es2Sellint;
    public Text Es3Buy;
    public Text Es3Sell;
    public static int Es3Buyint;
    public static int Es3Sellint;
    public Text Es4Buy;
    public Text Es4Sell;
    public static int Es4Buyint;
    public static int Es4Sellint;

    public Text Nl1Buy;
    public Text Nl1Sell;
    public static int Nl1Buyint;
    public static int Nl1Sellint;
    public Text Nl2Buy;
    public Text Nl2Sell;
    public static int Nl2Buyint;
    public static int Nl2Sellint;
    public Text Nl3Buy;
    public Text Nl3Sell;
    public static int Nl3Buyint;
    public static int Nl3Sellint;
    public Text Nl4Buy;
    public Text Nl4Sell;
    public static int Nl4Buyint;
    public static int Nl4Sellint;

    public Text Pt1Buy;
    public Text Pt1Sell;
    public static int Pt1Buyint;
    public static int Pt1Sellint;
    public Text Pt2Buy;
    public Text Pt2Sell;
    public static int Pt2Buyint;
    public static int Pt2Sellint;
    public Text Pt3Buy;
    public Text Pt3Sell;
    public static int Pt3Buyint;
    public static int Pt3Sellint;
    public Text Pt4Buy;
    public Text Pt4Sell;
    public static int Pt4Buyint;
    public static int Pt4Sellint;

    public Text Uk1Buy;
    public Text Uk1Sell;
    public static int Uk1Buyint;
    public static int Uk1Sellint;
    public Text Uk2Buy;
    public Text Uk2Sell;
    public static int Uk2Buyint;
    public static int Uk2Sellint;
    public Text Uk3Buy;
    public Text Uk3Sell;
    public static int Uk3Buyint;
    public static int Uk3Sellint;
    public Text Uk4Buy;
    public Text Uk4Sell;
    public static int Uk4Buyint;
    public static int Uk4Sellint;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Cn1Buyint = goods.cn_cargo_01Buy;
        Cn1Sellint = goods.cn_cargo_01Sell;
        Cn2Buyint = goods.cn_cargo_02Buy;
        Cn2Sellint = goods.cn_cargo_02Sell;
        Cn3Buyint = goods.cn_cargo_03Buy;
        Cn3Sellint = goods.cn_cargo_03Sell;
        Cn4Buyint = goods.cn_cargo_04Buy;
        Cn4Sellint = goods.cn_cargo_04Sell;
        Cn1Buy.text = Cn1Buyint + "";
        Cn1Sell.text = Cn1Sellint + "";
        Cn2Buy.text = Cn2Buyint + "";
        Cn2Sell.text = Cn2Sellint + "";
        Cn3Buy.text = Cn3Buyint + "";
        Cn3Sell.text = Cn3Sellint + "";
        Cn4Buy.text = Cn4Buyint + "";
        Cn4Sell.text = Cn4Sellint + "";

        Jp1Buyint = goods.jp_cargo_01Buy;
        Jp1Sellint = goods.jp_cargo_01Sell;
        Jp2Buyint = goods.jp_cargo_02Buy;
        Jp2Sellint = goods.jp_cargo_02Sell;
        Jp3Buyint = goods.jp_cargo_03Buy;
        Jp3Sellint = goods.jp_cargo_03Sell;
        Jp4Buyint = goods.jp_cargo_04Buy;
        Jp4Sellint = goods.jp_cargo_04Sell;
        Jp1Buy.text = Jp1Buyint + "";
        Jp1Sell.text = Jp1Sellint + "";
        Jp2Buy.text = Jp2Buyint + "";
        Jp2Sell.text = Jp2Sellint + "";
        Jp3Buy.text = Jp3Buyint + "";
        Jp3Sell.text = Jp3Sellint + "";
        Jp4Buy.text = Jp4Buyint + "";
        Jp4Sell.text = Jp4Sellint + "";

        Es1Buyint = goods.es_cargo_01Buy;
        Es1Sellint = goods.es_cargo_01Sell;
        Es2Buyint = goods.es_cargo_02Buy;
        Es2Sellint = goods.es_cargo_02Sell;
        Es3Buyint = goods.es_cargo_03Buy;
        Es3Sellint = goods.es_cargo_03Sell;
        Es4Buyint = goods.es_cargo_04Buy;
        Es4Sellint = goods.es_cargo_04Sell;
        Es1Buy.text = Es1Buyint + "";
        Es1Sell.text = Es1Sellint + "";
        Es2Buy.text = Es2Buyint + "";
        Es2Sell.text = Es2Sellint + "";
        Es3Buy.text = Es3Buyint + "";
        Es3Sell.text = Es3Sellint + "";
        Es4Buy.text = Es4Buyint + "";
        Es4Sell.text = Es4Sellint + "";

        Nl1Buyint = goods.nl_cargo_01Buy;
        Nl1Sellint = goods.nl_cargo_01Sell;
        Nl1Buy.text = Nl1Buyint + "";
        Nl1Sell.text = Nl1Sellint + "";
        Nl2Buyint = goods.nl_cargo_02Buy;
        Nl2Sellint = goods.nl_cargo_02Sell;
        Nl2Buy.text = Nl2Buyint + "";
        Nl2Sell.text = Nl2Sellint + "";
        Nl3Buyint = goods.nl_cargo_03Buy;
        Nl3Sellint = goods.nl_cargo_03Sell;
        Nl3Buy.text = Nl3Buyint + "";
        Nl3Sell.text = Nl3Sellint + "";
        Nl4Buyint = goods.nl_cargo_04Buy;
        Nl4Sellint = goods.nl_cargo_04Sell;
        Nl4Buy.text = Nl4Buyint + "";
        Nl4Sell.text = Nl4Sellint + "";

        Pt1Buyint = goods.pt_cargo_01Buy;
        Pt1Sellint = goods.pt_cargo_01Sell;
        Pt1Buy.text = Pt1Buyint + "";
        Pt1Sell.text = Pt1Sellint + "";
        Pt2Buyint = goods.pt_cargo_02Buy;
        Pt2Sellint = goods.pt_cargo_02Sell;
        Pt2Buy.text = Pt2Buyint + "";
        Pt2Sell.text = Pt2Sellint + "";
        Pt3Buyint = goods.pt_cargo_03Buy;
        Pt3Sellint = goods.pt_cargo_03Sell;
        Pt3Buy.text = Pt3Buyint + "";
        Pt3Sell.text = Pt3Sellint + "";
        Pt4Buyint = goods.pt_cargo_04Buy;
        Pt4Sellint = goods.pt_cargo_04Sell;
        Pt4Buy.text = Pt4Buyint + "";
        Pt4Sell.text = Pt4Sellint + "";

        Uk1Buyint = goods.uk_cargo_01Buy;
        Uk1Sellint = goods.uk_cargo_01Sell;
        Uk1Buy.text = Uk1Buyint + "";
        Uk1Sell.text = Uk1Sellint + "";
        Uk2Buyint = goods.uk_cargo_02Buy;
        Uk2Sellint = goods.uk_cargo_02Sell;
        Uk2Buy.text = Uk2Buyint + "";
        Uk2Sell.text = Uk2Sellint + "";
        Uk3Buyint = goods.uk_cargo_03Buy;
        Uk3Sellint = goods.uk_cargo_03Sell;
        Uk3Buy.text = Uk3Buyint + "";
        Uk3Sell.text = Uk3Sellint + "";
        Uk4Buyint = goods.uk_cargo_04Buy;
        Uk4Sellint = goods.uk_cargo_04Sell;
        Uk4Buy.text = Uk4Buyint + "";
        Uk4Sell.text = Uk4Sellint + "";


    }
}
