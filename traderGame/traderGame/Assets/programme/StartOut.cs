using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class StartOut : MonoBehaviour
{
    // Start is called before the first frame update
    public void OutGoods()
    {
        Application.Quit();

    }

    public void InGoods()
    {
        SceneManager.LoadScene("SampleScene");
    }

}
