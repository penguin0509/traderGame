using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class printfUp : MonoBehaviour
{
    public int CnLv;
    public int JpLv;
    public int EsLv;
    public int PtLv;
    public int NlLv;
    public int UkLv;

    public int Cnmoney;
    public int Ukmoney;
    public int Jpmoney;
    public int Esmoney;
    public int Ptmoney;
    public int Nlmoney;

    public Text CnLv_UI;
    public Text JpLv_UI;
    public Text EsLv_UI;
    public Text UkLv_UI;
    public Text PtLv_UI;
    public Text NlLv_UI;

    public Text NlMoney_UI;
    public Text CnMoney_UI;
    public Text PtMoney_UI;
    public Text UkMoney_UI;
    public Text JpMoney_UI;
    public Text EsMoney_UI;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        CnLv = LevelUp.CnLevelUp;
        JpLv = LevelUp.JpLevelUp;
        EsLv = LevelUp.EsLevelUp;
        UkLv = LevelUp.UkLevelUp;
        PtLv = LevelUp.PtLevelUp;
        NlLv = LevelUp.NlLevelUp;
        Cnmoney = LevelUp.Cnneedmoney;
        Jpmoney = LevelUp.Jpneedmoney;
        Ptmoney = LevelUp.Ptneedmoney;
        Ukmoney = LevelUp.Ukneedmoney;
        Esmoney = LevelUp.Esneedmoney;
        Nlmoney = LevelUp.Nlneedmoney;

        CnLv_UI.text = "中國lv:" + LevelUp.CnLevelUp;
        JpLv_UI.text = "日本lv:" + LevelUp.JpLevelUp;
        PtLv_UI.text = "葡萄牙lv:" + LevelUp.PtLevelUp;
        UkLv_UI.text = "英國lv:" + LevelUp.UkLevelUp;
        EsLv_UI.text = "西班牙lv:" + LevelUp.EsLevelUp;
        NlLv_UI.text = "荷蘭lv:" + LevelUp.NlLevelUp;

        CnMoney_UI.text = "$" + LevelUp.Cnneedmoney;
        JpMoney_UI.text = "$" + LevelUp.Jpneedmoney;
        PtMoney_UI.text = "$" + LevelUp.Ptneedmoney;
        UkMoney_UI.text = "$" + LevelUp.Ukneedmoney;
        EsMoney_UI.text = "$" + LevelUp.Esneedmoney;
        NlMoney_UI.text = "$" + LevelUp.Nlneedmoney;
    }
}
