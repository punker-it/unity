using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Tag : MonoBehaviour
{
    public GameObject prefabToInstantiate;
    public int count = 0;
    public int maxCount = 0;

    public GameObject item;
    void Start()
    {
        GameObject instance = Instantiate(prefabToInstantiate);

        instance.transform.position = new Vector3(0,0,0);
        
    }
    void OnTriggerEnter(Collider other) {
        if(other.CompareTag("Coin")){
            Destroy(other);
            count++;
            Debug.Log(count);
        }
    }

    
        
    
    void Update()
    {
        
    }
}
