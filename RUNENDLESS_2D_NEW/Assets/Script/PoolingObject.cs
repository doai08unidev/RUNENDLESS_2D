using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PoolingObject : MonoBehaviour
{
    // Start is called before the first frame update
    List<GameObject> poolingObjects;
    [SerializeField] GameObject poolingObject;
    private int poolingAmount = 5;
    void Start()
    {
        poolingObjects = new List<GameObject>();
        for(int i = 0; i<poolingAmount;i++){
           
            GameObject poolingObj = (GameObject)Instantiate(poolingObject);
            poolingObj.SetActive(false);
            poolingObjects.Add(poolingObj);       
        }
    }
    public GameObject GetPoolingObject(){
        for(int i =0;i<poolingObjects.Count;i++){
            if(!poolingObjects[i].activeInHierarchy){
                poolingObjects[i].name = "uo";
                print(i);
                return poolingObjects[i];
            }
        }

        // GameObject poolingObj = (GameObject)Instantiate(poolingObject);
        // poolingObj.SetActive(false);
        // poolingObj.name="ua gi day troi";
        // poolingObjects.Add(poolingObj);
        // print(poolingObjects.Count);
        return null;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
