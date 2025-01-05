using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExampleScript : MonoBehaviour
{
    public GameObject prefabToInstantiate;

    void Start()
    {
        // Создание нового экземпляра объекта из префаба
        GameObject instance = Instantiate(prefabToInstantiate);

        // Позиционирование нового экземпляра
        instance.transform.position = new Vector3(-35.73f, 10, 0);
    }
}

