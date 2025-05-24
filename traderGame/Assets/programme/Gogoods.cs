using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class Gogoods : MonoBehaviour
{
    [SerializeField]
    private GameObject Cn;
    private GameObject Jp;
    private GameObject Es;
    private GameObject Nl;
    private GameObject Pt;
    private GameObject Uk;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {


    }

    public void InGoods()
    {
            SceneManager.LoadScene("BuyGoods");
        
    }

    public void OutGoods()
    {
        SceneManager.LoadScene("SampleScene");
    }

    public void OutCn()
    {

    }
}
