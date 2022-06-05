using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollowPlayer : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] private Transform player;
    [SerializeField] private Vector3 lastPositionPlayer;
    private float distanceOfPlayer;
    void Start()
    {
        lastPositionPlayer = player.transform.position;
    }
    void Update(){
        distanceOfPlayer = player.transform.position.x - lastPositionPlayer.x;
        this.transform.position = new Vector3(this.transform.position.x + distanceOfPlayer, this.transform.position.y, this.transform.position.z);
        lastPositionPlayer = player.transform.position;
    }

}
// using System
// using UnityEngine;
// using System.Collections;
// public class ObjectPooler : MonoBehaviour{
// 	public GameObject pooledObject;
// 	public int pooledAmount;
// 	List<GameObject> pooledObjects;
// 	void Start(){
// 	  pooledObjects = new List<GameObject>();
// 	  for(int i = 0 ; i<pooledAmount;i++){
// 	    GameObject obj = (GameObject) Instantiate(pooledObject);
// 	    obj.SetActive(false);
// 	    pooledObjects.Add(obj);
// 	  }
// 	}
// 	public GameObject GetPooledObject(){
// 	  for(int i = 0;i< pooledObjects.Count;i++){
// 	    if(pooledObjects[i].activeInHierarchy){
// 	      return pooledObjects[i];
// 	    }
// 	  }
// 	  GameObject obj = (GameObject) Instantiate(pooledObject);
//     obj.SetActive(false);
//     pooledObjects.Add(obj);
//     return obj;
// 	}
// 	void Update(){
		
// 	}
// }