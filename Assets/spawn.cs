using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawn : MonoBehaviour
{
    public GameObject enemy;
    int nnode = 1;
    // Start is called before the first frame update
    void Start()
    {
        spawnenemy(nnode);
    }

    void spawnenemy(int a)
    {
        for(int i =0;i<a;i++)
        Instantiate(enemy, randompos(), enemy.transform.rotation);
    }

    Vector3 randompos()
    {
        float xpos = Random.Range(-10, 10);
        float zpos = Random.Range(-10, 10);
        Vector3 ret = new Vector3(xpos, 0, zpos);
        return ret;
    }

    public int enemycnt;
    // Update is called once per frame
    void Update()
    {
        enemycnt = FindObjectsOfType<enemy>().Length;
        if(enemycnt == 0)
        {
            nnode++;
            spawnenemy(nnode);
        }
    }
}
