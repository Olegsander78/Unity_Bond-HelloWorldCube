using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeSpawner3 : MonoBehaviour
{
    public GameObject cubePrefabVar;
    public List<GameObject> gameObjectList;
    public float scalingFactor = 0.95f;
    public int numCubes = 0;

    // Start is called before the first frame update
    void Start()
    {
        gameObjectList = new List<GameObject>();    
    }

    // Update is called once per frame
    void Update()
    {
        numCubes++; //a
        GameObject gObj = Instantiate<GameObject>(cubePrefabVar); 
        gObj.name = "Cube " + numCubes; //c
        Color c = new Color(Random.value, Random.value, Random.value); //d
        gObj.GetComponent<Renderer>().material.color = c;
        gObj.transform.position = Random.insideUnitSphere;  //e

        gameObjectList.Add(gObj);

        List<GameObject> removeList = new List<GameObject>();  //f

        foreach(GameObject goTemp in gameObjectList) { //g
            float scale = goTemp.transform.localScale.x;  //h
            scale *= scalingFactor;
            goTemp.transform.localScale = Vector3.one * scale;

            if(scale <= 0.1f)  //i
            {
                removeList.Add(goTemp);
            }        
        } 
        foreach(GameObject goTemp in removeList)   //g
        {
            gameObjectList.Remove(goTemp);  //j
            Destroy(goTemp);
        }
    }
}
