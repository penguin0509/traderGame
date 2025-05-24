using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class GoodsSell : MonoBehaviour
{
    public Image Cn;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Goodslv3.CnTF == true)
        {
            Cn.color = new Color(255, 255, 255, 1f);
        }
    }
}
