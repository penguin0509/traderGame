using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NPCRun2 : MonoBehaviour
{
    public float speed = 0.5f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float y = Random.Range(-3.12f, 0.91f);
        float x = Random.Range(-7.39f, -4.83f);
        gameObject.transform.localPosition = new Vector3(Mathf.Lerp(gameObject.transform.localPosition.x, x, speed * Time.deltaTime), Mathf.Lerp(gameObject.transform.localPosition.y, y, speed * Time.deltaTime), 0);
        if (gameObject.transform.localPosition.x <= x +1)
        {
            RandomSpawn.Spawnnumber2--;
            Destroy(gameObject);
        }
    }
}
