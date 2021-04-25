using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlaueBlumen : MonoBehaviour
{
    private float timer = 0;
    private int countSpaceInput;
    private int countKInput;
    private GameObject clone;
    private int cloneBlaueBlume;
    private GameObject cloneFlowerPool;

    public GameObject blaueBlume;
    public GameObject[] blumen;


    // Start is called before the first frame update
    void Start()
    {
        timer = 0;
        cloneBlaueBlume = 0;
        countKInput = 0;
    }

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;

        if (Input.GetKeyDown(KeyCode.Space))
        {
            countSpaceInput = countSpaceInput + 1;
            Debug.Log(countSpaceInput + "count Space Input");
            timer = 0;

        }

        if (timer > 1)
        {
            Debug.Log("time for spawning");

            while (countSpaceInput > cloneBlaueBlume)
            {
                clone = Instantiate(blaueBlume);
                clone.transform.position = new Vector2(Random.Range(-300f, 300f), Random.Range(-100f, 100f));
                clone.transform.SetParent(GameObject.FindGameObjectWithTag("Canvas").transform, false);
                cloneBlaueBlume = cloneBlaueBlume + 1;
                Debug.Log(cloneBlaueBlume + "Blumen");
            }
            timer = 0;
            countSpaceInput = 0;
        }

        if (Input.GetKeyDown(KeyCode.K))
        {
            countKInput = countKInput + 1;
            Debug.Log(countKInput + "count K Input");
        }

        if (countKInput > 10)
        {
            cloneFlowerPool = Instantiate(blumen[UnityEngine.Random.Range(0, 5)]);
            cloneFlowerPool.transform.position = new Vector2(Random.Range(-300f, 300f), Random.Range(-100f, 100f));
            cloneFlowerPool.transform.SetParent(GameObject.FindGameObjectWithTag("Canvas").transform, false);    
            countKInput = 0;
        }



    }     
}
