using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlaueBlumen : MonoBehaviour
{
    private int countSpaceInput;
    private int countKInput;
    private GameObject clone;

    public GameObject blaueBlume;

    //public int[] GameObject = { grueneBlume, roteBlume, orangeneBlume, rosaBlume, tuerkiseBlume };

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            countSpaceInput = countSpaceInput + 1;
            Debug.Log(countSpaceInput + "count Space Input");

            if (countSpaceInput > 4)
            {
                clone = Instantiate(blaueBlume);
                clone.transform.position = new Vector2(Random.Range(-20f, 20f), Random.Range(-10.0f, 10.0f));
            }
        }
    }
}
