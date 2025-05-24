using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelUp : MonoBehaviour
{
    public SpriteRenderer Cn;
    public SpriteRenderer Jp;
    public SpriteRenderer Es;
    public SpriteRenderer Uk;
    public SpriteRenderer Pt;
    public SpriteRenderer Nl;

    public static int Cnneedmoney = 300;
    public static int CnLevelUp = 1;

    public static int Jpneedmoney = 300;
    public static int JpLevelUp = 1;

    public static int Ptneedmoney = 300;
    public static int PtLevelUp = 1;

    public static int Esneedmoney = 300;
    public static int EsLevelUp = 1;

    public static int Nlneedmoney = 300;
    public static int NlLevelUp = 1;

    public static int Ukneedmoney = 300;
    public static int UkLevelUp = 1;


    public static int money;
    // Start is called before the first frame update

    public void Update()
    {
        money = goods.playermoney;
    }
    public void CnCheck()
    {
        if (CnLevelUp == 1 && money >= Cnneedmoney)
        {
            goods.playermoney -= Cnneedmoney;
            CnLevelUp = 2;
            Cnneedmoney = 350;
            goods.cn_cargo_01Buy -= 20;
            goods.cn_cargo_02Buy -= 10;
            goods.cn_cargo_03Buy -= 5;
        }
        else if (CnLevelUp == 2 && money >= Cnneedmoney)
        {
            goods.playermoney -= Cnneedmoney;
            CnLevelUp = 3;
            Cnneedmoney = 400;
            goods.cnunlock = true;
            Goodslv3.CnTF = true;
            goods.cn_cargo_01Buy -= 20;
            goods.cn_cargo_02Buy -= 10;
            goods.cn_cargo_03Buy -= 5;
        }
        else if (CnLevelUp == 3 && money >= Cnneedmoney)
        {
            goods.playermoney -= Cnneedmoney;
            CnLevelUp = 4;
            Cnneedmoney = 450;
            goods.cn_cargo_01Buy -= 25;
            goods.cn_cargo_02Buy -= 15;
            goods.cn_cargo_03Buy  -= 10;
            goods.cn_cargo_04Buy  -= 30;
        }
        else if (CnLevelUp == 4 && money >= Cnneedmoney)
        {
            goods.playermoney -= Cnneedmoney;
            CnLevelUp = 5;
            Cnneedmoney = 0;
            goods.cn_cargo_01Buy -= 25;
            goods.cn_cargo_02Buy -= 15;
            goods.cn_cargo_03Buy -= 10;
            goods.cn_cargo_04Buy -= 30;
        }
    }

    public void EsCheck()
    {
        if (EsLevelUp == 1 && money >= Esneedmoney)
        {
            goods.playermoney -= Esneedmoney;
            EsLevelUp = 2;
            Esneedmoney = 350;
            goods.es_cargo_01Buy -= 24;
            goods.es_cargo_02Buy -= 12;
            goods.es_cargo_03Buy -= 6;
        }
        else if (EsLevelUp == 2 && money >= Esneedmoney)
        {
            goods.playermoney -= Esneedmoney;
            EsLevelUp = 3;
            Esneedmoney = 400;
            goods.esnlock = true;
            goods.es_cargo_01Buy -= 24;
            goods.es_cargo_02Buy -= 12;
            goods.es_cargo_03Buy -= 6;
        }
        else if (EsLevelUp == 3 && money >= Esneedmoney)
        {
            goods.playermoney -= Esneedmoney;
            EsLevelUp = 4;
            Esneedmoney = 450;
            goods.es_cargo_01Buy -= 24;
            goods.es_cargo_02Buy -= 12;
            goods.es_cargo_03Buy -= 6;
            goods.es_cargo_04Buy -= 36;
        }
        else if (EsLevelUp == 4 && money >= Esneedmoney)
        {
            goods.playermoney -= Esneedmoney;
            EsLevelUp = 5;
            Esneedmoney = 0;
            goods.es_cargo_01Buy -= 24;
            goods.es_cargo_02Buy -= 12;
            goods.es_cargo_03Buy -= 6;
            goods.es_cargo_04Buy -= 36;
        }
    }

    public void UkCheck()
    {
        if (UkLevelUp == 1 && money >= Ukneedmoney)
        {
            goods.playermoney -= Ukneedmoney;
            UkLevelUp = 2;
            Ukneedmoney = 350;
            goods.uk_cargo_01Buy -= 30;
            goods.uk_cargo_02Buy -= 15;
            goods.uk_cargo_03Buy -= 8;
        }
        else if (UkLevelUp == 2 && money >= Ukneedmoney)
        {
            goods.playermoney -= Ukneedmoney;
            UkLevelUp = 3;
            Ukneedmoney = 400;
            goods.ukunlock = true;
            goods.uk_cargo_01Buy -= 30;
            goods.uk_cargo_02Buy -= 15;
            goods.uk_cargo_03Buy -= 8;
        }
        else if (UkLevelUp == 3 && money >= Ukneedmoney)
        {
            goods.playermoney -= Ukneedmoney;
            UkLevelUp = 4;
            Ukneedmoney = 450;
            goods.uk_cargo_01Buy -= 30;
            goods.uk_cargo_02Buy -= 15;
            goods.uk_cargo_03Buy -= 8;
            goods.uk_cargo_04Buy -= 45;
        }
        else if (UkLevelUp == 4 && money >= Ukneedmoney)
        {
            goods.playermoney -= Ukneedmoney;
            UkLevelUp = 5;
            Ukneedmoney = 0;
            goods.uk_cargo_01Buy -= 30;
            goods.uk_cargo_02Buy -= 15;
            goods.uk_cargo_03Buy -= 8;
            goods.uk_cargo_04Buy -= 45;
        }
    }

    public void PtCheck()
    {
        if (PtLevelUp == 1 && money >= Ptneedmoney)
        {
            goods.playermoney -= Ptneedmoney;
            PtLevelUp = 2;
            Ptneedmoney = 350;
            goods.pt_cargo_01Buy -= 36;
            goods.pt_cargo_02Buy -= 18;
            goods.pt_cargo_03Buy -= 9;
            goods.pt_cargo_04Buy -= 0;
        }
        else if (PtLevelUp == 2 && money >= Ptneedmoney)
        {
            goods.playermoney -= Ptneedmoney;
            PtLevelUp = 3;
            Ptneedmoney = 400;
            goods.ptunlock = true;
            goods.pt_cargo_01Buy -= 36;
            goods.pt_cargo_02Buy -= 18;
            goods.pt_cargo_03Buy -= 9;
            goods.pt_cargo_04Buy -= 0;
        }
        else if (PtLevelUp == 3 && money >= Ptneedmoney)
        {
            goods.playermoney -= Ptneedmoney;
            PtLevelUp = 4;
            Ptneedmoney = 450;
            goods.pt_cargo_01Buy -= 36;
            goods.pt_cargo_02Buy -= 18;
            goods.pt_cargo_03Buy -= 9;
            goods.pt_cargo_04Buy -= 54;
        }
        else if (PtLevelUp == 4 && money >= Ptneedmoney)
        {
            goods.playermoney -= Ptneedmoney;
            PtLevelUp = 5;
            Ptneedmoney = 0;
            goods.pt_cargo_01Buy -= 36;
            goods.pt_cargo_02Buy -= 18;
            goods.pt_cargo_03Buy -= 9;
            goods.pt_cargo_04Buy -= 54;
        }
    }

    public void JpCheck()
    {
        if (JpLevelUp == 1 && money >= Jpneedmoney)
        {
            goods.playermoney -= Jpneedmoney;
            JpLevelUp = 2;
            Jpneedmoney = 350;
            goods.jp_cargo_01Buy -= 40;
            goods.jp_cargo_02Buy -= 10;
            goods.jp_cargo_03Buy -= 5;
            goods.jp_cargo_04Buy -= 0;
        }
        else if (JpLevelUp == 2 && money >= Jpneedmoney)
        {
            goods.playermoney -= Jpneedmoney;
            JpLevelUp = 3;
            Jpneedmoney = 400;
            goods.jpunlock = true;
            goods.jp_cargo_01Buy -= 40;
            goods.jp_cargo_02Buy -= 10;
            goods.jp_cargo_03Buy -= 5;
            goods.jp_cargo_04Buy -= 0;
        }
        else if (JpLevelUp == 3 && money >= Jpneedmoney)
        {
            goods.playermoney -= Jpneedmoney;
            JpLevelUp = 4;
            Jpneedmoney = 450;
            goods.jp_cargo_01Buy -= 40;
            goods.jp_cargo_02Buy -= 10;
            goods.jp_cargo_03Buy -= 5;
            goods.jp_cargo_04Buy -= 30;
        }
        else if (JpLevelUp == 4 && money >= Jpneedmoney)
        {
            goods.playermoney -= Jpneedmoney;
            JpLevelUp = 5;
            Jpneedmoney = 0;
            goods.jp_cargo_01Buy -= 40;
            goods.jp_cargo_02Buy -= 10;
            goods.jp_cargo_03Buy -= 5;
            goods.jp_cargo_04Buy -= 30;
        }
    }

    public void NlCheck()
    {
        if (NlLevelUp == 1 && money >= Nlneedmoney)
        {
            goods.playermoney -= Nlneedmoney;
            NlLevelUp = 2;
            Nlneedmoney = 350;
            goods.nl_cargo_01Buy -= 40;
            goods.nl_cargo_02Buy -= 20;
            goods.nl_cargo_03Buy -= 10;
            goods.nl_cargo_04Buy -= 0;
        }
        else if (NlLevelUp == 2 && money >= Nlneedmoney)
        {
            goods.playermoney -= Nlneedmoney;
            NlLevelUp = 3;
            Nlneedmoney = 400;
            goods.nlunlock = true;
            goods.nl_cargo_01Buy -= 40;
            goods.nl_cargo_02Buy -= 20;
            goods.nl_cargo_03Buy -= 10;
            goods.nl_cargo_04Buy -= 0;
        }
        else if (NlLevelUp == 3 && money >= Nlneedmoney)
        {
            goods.playermoney -= Nlneedmoney;
            NlLevelUp = 4;
            Nlneedmoney = 450;
            goods.nl_cargo_01Buy -= 40;
            goods.nl_cargo_02Buy -= 20;
            goods.nl_cargo_03Buy -= 10;
            goods.nl_cargo_04Buy -= 60;
        }
        else if (NlLevelUp == 4 && money >= Nlneedmoney)
        {
            goods.playermoney -= Nlneedmoney;
            NlLevelUp = 5;
            Nlneedmoney = 0;
            goods.nl_cargo_01Buy -= 40;
            goods.nl_cargo_02Buy -= 20;
            goods.nl_cargo_03Buy -= 10;
            goods.nl_cargo_04Buy -= 60;
        }
    }
}
