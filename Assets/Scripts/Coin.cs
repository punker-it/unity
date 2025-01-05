using System.Collections;
using System.Collections.Generic;
using Unity.PlasticSCM.Editor.WebApi;
using UnityEngine;

public class Coin : MonoBehaviour
{
    public GameObject prefabToInstantiate;

    void Start() {

        float positionX = -28.6f;

        for(int i = 0;i<3;i++){

            GameObject instance = Instantiate(prefabToInstantiate);

            instance.transform.position = new Vector3(positionX, 6.24f, 0);
            instance.transform.localScale = new Vector3(.15f, .15f, .15f);

            positionX = positionX + 1.5f;

        }
    }
}

/*public class Coin : MonoBehaviour
{
    public GameObject prefabToInstantiate;
    public Transform spawnPosition;
    public float respawnTime = 10f;

    private GameObject currentCoin;
    void Start()
    {

        RespawnCoin();
    }
    private void SpawnCoin(){
        if (currentCoin == null){
            currentCoin = Instantiate(prefabToInstantiate,spawnPosition.position,spawnPosition.rotation);
        }
    }
    // Update is called once per frame
    void Update()
    {
        
    }
    private IEnumerator RespawnCoin()
    {
        yield return new WaitForSeconds(respawnTime+5f);

        SpawnCoin();

        yield return new WaitForSeconds(respawnTime);
        Destroy(currentCoin);
    }

    
}*/
