using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class printfUo2 : MonoBehaviour
{
    public Text CnLv_UI;
    public Text JpLv_UI;
    public Text EsLv_UI;
    public Text UkLv_UI;
    public Text PtLv_UI;
    public Text NlLv_UI;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        CnLv_UI.text = "中國lv:" + LevelUp.CnLevelUp;
        JpLv_UI.text = "日本lv:" + LevelUp.JpLevelUp;
        PtLv_UI.text = "葡萄牙lv:" + LevelUp.PtLevelUp;
        UkLv_UI.text = "英國lv:" + LevelUp.UkLevelUp;
        EsLv_UI.text = "西班牙lv:" + LevelUp.EsLevelUp;
        NlLv_UI.text = "荷蘭lv:" + LevelUp.NlLevelUp;
    }
}
