using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomSpawn : MonoBehaviour
{
    public GameObject Cn1;
    public GameObject Cn2;
    public GameObject Jp1;
    public GameObject Jp2;
    public GameObject Pt1;
    public GameObject Pt2;
    public GameObject Es1;
    public GameObject Es2;
    public GameObject Nl1;
    public GameObject Nl2;

    public static int Spawnnumber = 0;
    public static int Spawnnumber2 = 0;
    public int Spawn1 = 0;
    public int x = 0;
    public float y = 0;
    public float x2 = 0;
    public float y2 = 0;

    // Start is called before the first frame update
    void Start()
    {
        
    }
    void FixedUpdate()
    {
        Spawn2();
        Spawn();

    }

    void Spawn2()
    {
        if (Spawnnumber2 < 3)
        {
            for (int i = 0; i < 3; i++)
            {
                float x2 = Random.Range(4.55f, 10.38f);
                float y2 = Random.Range(-2.3f, 0.54f);
                int Spawn1 = Random.Range(1, 10);
                    if (Spawn1 == 2)
                    {
                        Instantiate(Cn2, new Vector3(x2, y2, 0), new Quaternion(0, -1, 0, 0));
                        Spawnnumber2++;
                    }
                    else if (Spawn1 == 10)
                    {
                        Instantiate(Nl2, new Vector3(x2, y2, 0), new Quaternion(0, -1, 0, 0));
                        Spawnnumber2++;
                    }
                    else if (Spawn1 == 9)
                    {
                        Instantiate(Nl1, new Vector3(x2, y2, 0), new Quaternion(0, -1, 0, 0));
                        Spawnnumber2++;
                    }
                    else if (Spawn1 == 4)
                    {
                        Instantiate(Jp1, new Vector3(x2, y2, 0), new Quaternion(0, -1, 0, 0));
                        Spawnnumber2++;
                    }
                    else if (Spawn1 == 6)
                    {
                        Instantiate(Es2, new Vector3(x2, y2, 0), new Quaternion(0, -1, 0, 0));
                        Spawnnumber2++;
                    }
                    else if (Spawn1 == 7)
                    {
                        Instantiate(Pt2, new Vector3(x2, y2, 0), new Quaternion(0, -1, 0, 0));
                        Spawnnumber2++;
                    } 
            }
        }
    }

    void Spawn()
    {
        if (Spawnnumber < 2)
        {
            for (int i = 0; i < 2; i++)
            {
                int x = Random.Range(-9, -5);
                float y = Random.Range(-2.31f, 0.34f);
                int Spawn1 = Random.Range(1, 10);
                if (Spawn1 == 1)
                {
                    Instantiate(Cn1, new Vector3(x, y, 0), new Quaternion(0, 0, 0, 0));
                    Spawnnumber++;
                }
                else if (Spawn1 == 3)
                {
                    Instantiate(Jp2, new Vector3(x, y, 0), new Quaternion(0, 0, 0, 0));
                    Spawnnumber++;
                }
                else if (Spawn1 == 5)
                {
                    Instantiate(Es1, new Vector3(x, y, 0), new Quaternion(0, 0, 0, 0));
                    Spawnnumber++;
                }
                else if (Spawn1 == 8)
                {
                    Instantiate(Pt1, new Vector3(x, y, 0), new Quaternion(0, 0, 0, 0));
                    Spawnnumber++;
                }
            }
        }
    }
    // Update is called once per frame

}
