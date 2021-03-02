using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeSpawner2 : MonoBehaviour
{
    public GameObject cubePrefabVar;
    // Start is called before the first frame update
    void Start()
    {
             
    }

    // Update is called once per frame
    void Update()
    {
        SpellItOut();
        Instantiate(cubePrefabVar);
    }
    public void SpellItOut()
    {
        string sA = "Hello world!";
        string sB = "";
        for (int i = 0; i < sA.Length; i++)
        {
            sB += sA[i];
        }
        print(sB);
    }
}
