using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class NPCRun : MonoBehaviour
{
    public float speed = 0.5f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float y = Random.Range(-3f, 0.93f);
        float x = Random.Range(2.74f, 7f);
        gameObject.transform.localPosition = new Vector3(Mathf.Lerp(gameObject.transform.localPosition.x, x, speed * Time.deltaTime), Mathf.Lerp(gameObject.transform.localPosition.y, y, speed * Time.deltaTime), 0);
        if (gameObject.transform.localPosition.x >= x - 1)
        {
            RandomSpawn.Spawnnumber--;
            Destroy(gameObject);
        }
    }
}
