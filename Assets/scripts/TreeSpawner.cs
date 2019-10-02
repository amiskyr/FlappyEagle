using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TreeSpawner : MonoBehaviour
{
    public float maxTime = 1;
    private float timer = 0;
    public GameObject TREE;
    float height;

    // Start is called before the first frame update
    void Start()
    {
        GameObject newTREE = Instantiate(TREE);
        newTREE.transform.position = transform.position + new Vector3(12, Random.Range(-2, 1), 0);
    }

    // Update is called once per frame
    void Update()
    {
        if(timer > maxTime)
        {
            GameObject newTREE = Instantiate(TREE);
            newTREE.transform.position = transform.position + new Vector3(12, Random.Range(-2, 1), 0);
            Destroy(newTREE, 10);
            timer = 0;
        }

        timer += Time.deltaTime;
    }
}
