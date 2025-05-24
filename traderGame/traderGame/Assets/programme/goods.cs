using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class goods : MonoBehaviour
{
    public static int playermoney = 1000;
    public Inventory playerInventory;

    public static bool cn = false;
    public static GameObject cn_cargo_01;
    public static int cn_cargo_01Sell = 480;
    public static int cn_cargo_01Buy = 400;
    public static int cn_cargo_01Probability = 17;
    public static int cn_cargo_01Recycle = 200;
    public item cn1;
    public item cn2;
    public item cn3;
    public item cn4;

    public static GameObject cn_cargo_02;
    public static int cn_cargo_02Sell = 240;
    public static int cn_cargo_02Buy = 200;
    public static int cn_cargo_02Probability = 34;
    public static int cn_cargo_02Recycle = 100;

    public static GameObject cn_cargo_03;
    public static int cn_cargo_03Sell = 120;
    public static int cn_cargo_03Buy = 100;
    public static int cn_cargo_03Probability = 50;
    public static int cn_cargo_03Recycle = 50;

    public static bool cnunlock;
    public static GameObject cn_cargo_04;
    public static int cn_cargo_04Sell = 720;
    public static int cn_cargo_04Buy = 600;
    public static int cn_cargo_04Probability = 50;
    public static int cn_cargo_04Recycle = 300;

    public static bool jp = false;
    public static GameObject jp_cargo_01;
    public static int jp_cargo_01Sell = 480;
    public static int jp_cargo_01Buy = 400;
    public static int jp_cargo_01Probability = 17;
    public static int jp_cargo_01Recycle = 200;
    public item jp1;
    public item jp2;
    public item jp3;
    public item jp4;

    public static GameObject jp_cargo_02;
    public static int jp_cargo_02Sell = 240;
    public static int jp_cargo_02Buy = 200;
    public static int jp_cargo_02Probability = 34;
    public static int jp_cargo_02Recycle = 100;

    public static GameObject jp_cargo_03;
    public static int jp_cargo_03Sell = 120;
    public static int jp_cargo_03Buy = 100;
    public static int jp_cargo_03Probability = 50;
    public static int jp_cargo_03Recycle = 50;

    public static bool jpunlock = false;
    public static GameObject jp_cargo_04;
    public static int jp_cargo_04Sell = 720;
    public static int jp_cargo_04Buy = 600;
    public static int jp_cargo_04Probability = 50;
    public static int jp_cargo_04Recycle = 300;

    public static bool uk = false;
    public static GameObject uk_cargo_01;
    public static int uk_cargo_01Sell = 720;
    public static int uk_cargo_01Buy = 600;
    public static int uk_cargo_01Probability = 17;
    public static int uk_cargo_01Recycle = 300;
    public item uk1;
    public item uk2;
    public item uk3;
    public item uk4;

    public static GameObject uk_cargo_02;
    public static int uk_cargo_02Sell = 360;
    public static int uk_cargo_02Buy = 300;
    public static int uk_cargo_02Probability = 34;
    public static int uk_cargo_02Recycle = 150;

    public static GameObject uk_cargo_03;
    public static int uk_cargo_03Sell = 180;
    public static int uk_cargo_03Buy = 150;
    public static int uk_cargo_03Probability = 50;
    public static int uk_cargo_03Recycle = 75;

    public static bool ukunlock = false;
    public static GameObject uk_cargo_04;
    public static int uk_cargo_04Sell = 1080;
    public static int uk_cargo_04Buy = 900;
    public static int uk_cargo_04Probability = 50;
    public static int uk_cargo_04Recycle = 450;

    public static bool nl = false;
    public static GameObject nl_cargo_01;
    public static int nl_cargo_01Sell = 960;
    public static int nl_cargo_01Buy = 800;
    public static int nl_cargo_01Probability = 17;
    public static int nl_cargo_01Recycle = 400;
    public item nl1;
    public item nl2;
    public item nl3;
    public item nl4;

    public static GameObject nl_cargo_02;
    public static int nl_cargo_02Sell = 480;
    public static int nl_cargo_02Buy = 400;
    public static int nl_cargo_02Probability = 34;
    public static int nl_cargo_02Recycle = 200;

    public static GameObject nl_cargo_03;
    public static int nl_cargo_03Sell = 240;
    public static int nl_cargo_03Buy = 200;
    public static int nl_cargo_03Probability = 50;
    public static int nl_cargo_03Recycle = 100;

    public static bool nlunlock = false;
    public static GameObject nl_cargo_04;
    public static int nl_cargo_04Sell = 1440;
    public static int nl_cargo_04Buy = 1200;
    public static int nl_cargo_04Probability = 50;
    public static int nl_cargo_04Recycle = 600;

    public static bool es = false;
    public static GameObject es_cargo_01;
    public static int es_cargo_01Sell = 576;
    public static int es_cargo_01Buy = 480;
    public static int es_cargo_01Probability = 17;
    public static int es_cargo_01Recycle = 240;
    public item es1;
    public item es2;
    public item es3;
    public item es4;

    public static GameObject es_cargo_02;
    public static int es_cargo_02Sell = 288;
    public static int es_cargo_02Buy = 240;
    public static int es_cargo_02Probability = 34;
    public static int es_cargo_02Recycle = 120;

    public static GameObject es_cargo_03;
    public static int es_cargo_03Sell = 144;
    public static int es_cargo_03Buy = 120;
    public static int es_cargo_03Probability = 50;
    public static int es_cargo_03Recycle = 60;

    public static bool esnlock = false;
    public static GameObject es_cargo_04;
    public static int es_cargo_04Sell = 864;
    public static int es_cargo_04Buy = 720;
    public static int es_cargo_04Probability = 50;
    public static int es_cargo_04Recycle = 360;

    public static bool pt = false;
    public static GameObject pt_cargo_01;
    public static int pt_cargo_01Sell = 864;
    public static int pt_cargo_01Buy = 720;
    public static int pt_cargo_01Probability = 17;
    public static int pt_cargo_01Recycle = 360;
    public item pt1;
    public item pt2;
    public item pt3;
    public item pt4;

    public static GameObject pt_cargo_02;
    public static int pt_cargo_02Sell = 432;
    public static int pt_cargo_02Buy = 360;
    public static int pt_cargo_02Probability = 17;
    public static int pt_cargo_02Recycle = 180;

    public static GameObject pt_cargo_03;
    public static int pt_cargo_03Sell = 216;
    public static int pt_cargo_03Buy = 180;
    public static int pt_cargo_03Probability = 34;
    public static int pt_cargo_03Recycle = 90;

    public static bool ptunlock = false;
    public static GameObject pt_cargo_04;
    public static int pt_cargo_04Sell = 1296;
    public static int pt_cargo_04Buy = 1080;
    public static int pt_cargo_04Probability = 50;
    public static int pt_cargo_04Recycle = 540;
    public void AddNewItemCn1()
    {
        if (!playerInventory.itemlist.Contains(cn1) && playermoney >= cn_cargo_01Buy)
        {
            playermoney = playermoney - cn_cargo_01Buy;
            playerInventory.itemlist.Add(cn1);
            cn1.itemHeld += 1;
            TimeDay.Allgoods += 1;
        }
        else if (playermoney >= cn_cargo_01Buy)
        {
            playermoney = playermoney - cn_cargo_01Buy;
            cn1.itemHeld += 1;
            TimeDay.Allgoods += 1;
        }
        InventoryManager.RefreshItem();
    }

    public void AddNewItemCn2()
    {
        if (!playerInventory.itemlist.Contains(cn2) && playermoney >= cn_cargo_02Buy)
        {
            playermoney = playermoney - cn_cargo_02Buy;
            playerInventory.itemlist.Add(cn2);
            cn2.itemHeld += 1;
            TimeDay.Allgoods += 1;
        }
        else if (playermoney >= cn_cargo_02Buy)
        {
            playermoney = playermoney - cn_cargo_02Buy;
            cn2.itemHeld += 1;
            TimeDay.Allgoods += 1;
        }
        InventoryManager.RefreshItem();
    }

    public void AddNewItemCn3()
    {
        if (!playerInventory.itemlist.Contains(cn3) && playermoney >= cn_cargo_03Buy)
        {
            playermoney = playermoney - cn_cargo_03Buy;
            playerInventory.itemlist.Add(cn3);
            cn3.itemHeld += 1;
            TimeDay.Allgoods += 1;
        }
        else if (playermoney >= cn_cargo_03Buy)
        {
            playermoney = playermoney - cn_cargo_03Buy;
            cn3.itemHeld += 1;
            TimeDay.Allgoods += 1;
        }
        InventoryManager.RefreshItem();
    }

    public void AddNewItemCn4()
    {
        if (!playerInventory.itemlist.Contains(cn4) && playermoney >= cn_cargo_04Buy && cnunlock == true)
        {
            playermoney = playermoney - cn_cargo_04Buy;
            playerInventory.itemlist.Add(cn4);
            cn4.itemHeld += 1;
            TimeDay.Allgoods += 1;
        }
        else if (playermoney >= cn_cargo_04Buy && cnunlock == true)
        {
            playermoney = playermoney - cn_cargo_04Buy;
            cn4.itemHeld += 1;
            TimeDay.Allgoods += 1;
        }
        InventoryManager.RefreshItem();
    }

    public void AddNewItemEs1()
    {
        if (!playerInventory.itemlist.Contains(es1) && playermoney >= es_cargo_01Buy)
        {
            playermoney = playermoney - es_cargo_01Buy;
            playerInventory.itemlist.Add(es1);
            es1.itemHeld += 1;
            TimeDay.Allgoods += 1;
        }
        else if (playermoney >= es_cargo_01Buy)
        {
            playermoney = playermoney - es_cargo_01Buy;
            es1.itemHeld += 1;
            TimeDay.Allgoods += 1;
        }
        InventoryManager.RefreshItem();
    }

    public void AddNewItemEs2()
    {
        if (!playerInventory.itemlist.Contains(es2) && playermoney >= es_cargo_02Buy)
        {
            playermoney = playermoney - es_cargo_02Buy;
            playerInventory.itemlist.Add(es2);
            es2.itemHeld += 1;
            TimeDay.Allgoods += 1;
        }
        else if (playermoney >= es_cargo_02Buy)
        {
            playermoney = playermoney - es_cargo_02Buy;
            es2.itemHeld += 1;
            TimeDay.Allgoods += 1;
        }
        InventoryManager.RefreshItem();
    }

    public void AddNewItemEs3()
    {
        if (!playerInventory.itemlist.Contains(es3) && playermoney >= es_cargo_03Buy)
        {
            playermoney = playermoney - es_cargo_03Buy;
            playerInventory.itemlist.Add(es3);
            es3.itemHeld += 1;
            TimeDay.Allgoods += 1;
        }
        else if (playermoney >= es_cargo_03Buy)
        {
            playermoney = playermoney - es_cargo_03Buy;
            es3.itemHeld += 1;
            TimeDay.Allgoods += 1;
        }
        InventoryManager.RefreshItem();
    }

    public void AddNewItemEs4()
    {
        if (!playerInventory.itemlist.Contains(es4) && playermoney >= es_cargo_04Buy && esnlock == true)
        {
            playermoney = playermoney - es_cargo_04Buy;
            playerInventory.itemlist.Add(es4);
            es4.itemHeld += 1; TimeDay.Allgoods += 1;
        }
        else if (playermoney >= es_cargo_04Buy && esnlock == true)
        {
            playermoney = playermoney - es_cargo_04Buy;
            es4.itemHeld += 1; TimeDay.Allgoods += 1;
        }
        InventoryManager.RefreshItem();
    }

    public void AddNewItemJp1()
    {
        if (!playerInventory.itemlist.Contains(jp1) && playermoney >= jp_cargo_01Buy)
        {
            playermoney = playermoney - jp_cargo_01Buy;
            playerInventory.itemlist.Add(jp1);
            jp1.itemHeld += 1; TimeDay.Allgoods += 1;
        }
        else if (playermoney >= jp_cargo_01Buy)
        {
            playermoney = playermoney - jp_cargo_01Buy;
            jp1.itemHeld += 1; TimeDay.Allgoods += 1;
        }
        InventoryManager.RefreshItem();
    }

    public void AddNewItemJp2()
    {
        if (!playerInventory.itemlist.Contains(jp2) && playermoney >= jp_cargo_02Buy)
        {
            playermoney = playermoney - jp_cargo_02Buy;
            playerInventory.itemlist.Add(jp2);
            jp2.itemHeld += 1; TimeDay.Allgoods += 1;
        }
        else if (playermoney >= jp_cargo_02Buy)
        {
            playermoney = playermoney - jp_cargo_02Buy;
            jp2.itemHeld += 1; TimeDay.Allgoods += 1;
        }
        InventoryManager.RefreshItem();
    }

    public void AddNewItemJp3()
    {
        if (!playerInventory.itemlist.Contains(jp3) && playermoney >= jp_cargo_03Buy)
        {
            playermoney = playermoney - jp_cargo_03Buy;
            playerInventory.itemlist.Add(jp3);
            jp3.itemHeld += 1; TimeDay.Allgoods += 1;
        }
        else if (playermoney >= jp_cargo_03Buy)
        {
            playermoney = playermoney - jp_cargo_03Buy;
            jp3.itemHeld += 1; TimeDay.Allgoods += 1;
        }
        InventoryManager.RefreshItem();
    }

    public void AddNewItemJp4()
    {
        if (!playerInventory.itemlist.Contains(jp4) && playermoney >= jp_cargo_04Buy && jpunlock == true)
        {
            playermoney = playermoney - jp_cargo_04Buy;
            playerInventory.itemlist.Add(jp4);
            jp4.itemHeld += 1; TimeDay.Allgoods += 1;
        }
        else if (playermoney >= jp_cargo_04Buy && jpunlock == true)
        {
            playermoney = playermoney - jp_cargo_04Buy;
            jp4.itemHeld += 1; TimeDay.Allgoods += 1;
        }
        InventoryManager.RefreshItem();
    }

    public void AddNewItemNl1()
    {
        if (!playerInventory.itemlist.Contains(nl1) && playermoney >= nl_cargo_01Buy)
        {
            playermoney = playermoney - nl_cargo_01Buy;
            playerInventory.itemlist.Add(nl1);
            nl1.itemHeld += 1; TimeDay.Allgoods += 1;
        }
        else if (playermoney >= nl_cargo_01Buy)
        {
            playermoney = playermoney - nl_cargo_01Buy;
            nl1.itemHeld += 1; TimeDay.Allgoods += 1;
        }
        InventoryManager.RefreshItem();
    }

    public void AddNewItemNl2()
    {
        if (!playerInventory.itemlist.Contains(nl2) && playermoney >= nl_cargo_02Buy)
        {
            playermoney = playermoney - nl_cargo_02Buy;
            playerInventory.itemlist.Add(nl2);
            nl2.itemHeld += 1; TimeDay.Allgoods += 1;
        }
        else if (playermoney >= nl_cargo_02Buy)
        {
            playermoney = playermoney - nl_cargo_02Buy;
            nl2.itemHeld += 1; TimeDay.Allgoods += 1;
        }
        InventoryManager.RefreshItem();
    }

    public void AddNewItemNl3()
    {
        if (!playerInventory.itemlist.Contains(nl3) && playermoney >= nl_cargo_03Buy)
        {
            playermoney = playermoney - nl_cargo_03Buy;
            playerInventory.itemlist.Add(nl3);
            nl3.itemHeld += 1; TimeDay.Allgoods += 1;
        }
        else if (playermoney >= nl_cargo_03Buy)
        {
            playermoney = playermoney - nl_cargo_03Buy;
            nl3.itemHeld += 1; TimeDay.Allgoods += 1;
        }
        InventoryManager.RefreshItem();
    }

    public void AddNewItemNl4()
    {
        if (!playerInventory.itemlist.Contains(nl4) && playermoney >= nl_cargo_04Buy && nlunlock == true)
        {
            playermoney = playermoney - nl_cargo_04Buy;
            playerInventory.itemlist.Add(nl4);
            nl4.itemHeld += 1; TimeDay.Allgoods += 1;
        }
        else if (playermoney >= nl_cargo_04Buy && nlunlock == true)
        {
            playermoney = playermoney - nl_cargo_04Buy;
            nl4.itemHeld += 1; TimeDay.Allgoods += 1;
        }
        InventoryManager.RefreshItem();
    }

    public void AddNewItemPt1()
    {
        if (!playerInventory.itemlist.Contains(pt1) && playermoney >= pt_cargo_01Buy)
        {
            playermoney = playermoney - pt_cargo_01Buy;
            playerInventory.itemlist.Add(pt1);
            pt1.itemHeld += 1; TimeDay.Allgoods += 1;
        }
        else if (playermoney >= pt_cargo_01Buy)
        {
            playermoney = playermoney - pt_cargo_01Buy;
            pt1.itemHeld += 1; TimeDay.Allgoods += 1;
        }
        InventoryManager.RefreshItem();
    }

    public void AddNewItemPt2()
    {
        if (!playerInventory.itemlist.Contains(pt2) && playermoney >= pt_cargo_02Buy)
        {
            playermoney = playermoney - pt_cargo_02Buy;
            playerInventory.itemlist.Add(pt2);
            pt2.itemHeld += 1; TimeDay.Allgoods += 1;
        }
        else if (playermoney >= pt_cargo_02Buy)
        {
            playermoney = playermoney - pt_cargo_02Buy;
            pt2.itemHeld += 1; TimeDay.Allgoods += 1;
        }
        InventoryManager.RefreshItem();
    }

    public void AddNewItemPt3()
    {
        if (!playerInventory.itemlist.Contains(pt3) && playermoney >= pt_cargo_03Buy)
        {
            playermoney = playermoney - pt_cargo_03Buy;
            playerInventory.itemlist.Add(pt3);
            pt3.itemHeld += 1; TimeDay.Allgoods += 1;
        }
        else if (playermoney >= pt_cargo_03Buy)
        {
            playermoney = playermoney - pt_cargo_03Buy;
            pt3.itemHeld += 1; TimeDay.Allgoods += 1;
        }
        InventoryManager.RefreshItem();
    }

    public void AddNewItemPt4()
    {
        if (!playerInventory.itemlist.Contains(pt4) && playermoney >= pt_cargo_04Buy && ptunlock == true)
        {
            playermoney = playermoney - pt_cargo_04Buy;
            playerInventory.itemlist.Add(pt4);
            pt4.itemHeld += 1; TimeDay.Allgoods += 1;
        }
        else if (playermoney >= pt_cargo_04Buy && ptunlock == true)
        {
            playermoney = playermoney - pt_cargo_04Buy;
            pt4.itemHeld += 1; TimeDay.Allgoods += 1;
        }
        InventoryManager.RefreshItem();
    }

    public void AddNewItemUk1()
    {
        if (!playerInventory.itemlist.Contains(uk1) && playermoney >= uk_cargo_01Buy)
        {
            playermoney = playermoney - uk_cargo_01Buy;
            playerInventory.itemlist.Add(uk1);
            uk1.itemHeld += 1; TimeDay.Allgoods += 1;
        }
        else if (playermoney >= uk_cargo_01Buy)
        {
            playermoney = playermoney - uk_cargo_01Buy;
            uk1.itemHeld += 1; TimeDay.Allgoods += 1;
        }
        InventoryManager.RefreshItem();
    }

    public void AddNewItemUk2()
    {
        if (!playerInventory.itemlist.Contains(uk2) && playermoney >= uk_cargo_02Buy)
        {
            playermoney = playermoney - uk_cargo_02Buy;
            playerInventory.itemlist.Add(uk2);
            uk2.itemHeld += 1; TimeDay.Allgoods += 1;
        }
        else if (playermoney >= uk_cargo_02Buy)
        {
            playermoney = playermoney - uk_cargo_02Buy;
            uk2.itemHeld += 1; TimeDay.Allgoods += 1;
        }
        InventoryManager.RefreshItem();
    }

    public void AddNewItemUk3()
    {
        if (!playerInventory.itemlist.Contains(uk3) && playermoney >= uk_cargo_03Buy)
        {
            playermoney = playermoney - uk_cargo_03Buy;
            playerInventory.itemlist.Add(uk3);
            uk3.itemHeld += 1; TimeDay.Allgoods += 1;
        }
        else if (playermoney >= uk_cargo_03Buy)
        {
            playermoney = playermoney - uk_cargo_03Buy;
            uk3.itemHeld += 1; TimeDay.Allgoods += 1;
        }
        InventoryManager.RefreshItem();
    }

    public void AddNewItemUk4()
    {
        if (!playerInventory.itemlist.Contains(uk4) && playermoney >= uk_cargo_04Buy && ukunlock == true)
        {
            playermoney = playermoney - uk_cargo_04Buy;
            playerInventory.itemlist.Add(uk4);
            uk4.itemHeld += 1; TimeDay.Allgoods += 1;
        }
        else if (playermoney >= uk_cargo_04Buy && ukunlock == true)
        {
            playermoney = playermoney - uk_cargo_04Buy;
            uk4.itemHeld += 1; TimeDay.Allgoods += 1;
        }
        InventoryManager.RefreshItem();
    }
}
