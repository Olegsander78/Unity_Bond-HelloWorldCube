using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeSpawner1 : MonoBehaviour
{
    public GameObject cubePrefabVar;
    // Start is called before the first frame update
    void Start()
    {
        //Instantiate(cubePrefabVar);

        bool f = false;
        bool t = true;
        print(f == t);
        print(f = t);
        print(10 != 10);
    }

    // Update is called once per frame
    void Update()
    {
        Instantiate(cubePrefabVar); 
    }
}
