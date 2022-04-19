using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{ //everything within the brackets are a class of the public Class
    public GameObject[] animalPrefabs;
    private float xPosRange = 13;
   // private int animalPrefabIndex; private prevents user from making changes) (placed in update and not needed in both areas)

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        /*float randXPos = Random.Range(-xPosRange, xPosRange); //method overloading
        int animalPrefabIndex = Random.Range(0, animalPrefabs.Length); //cannot be seen outside of update (moved so nthey only execute when needed)*/
        if (Input.GetKeyDown(KeyCode.A))
        {
            float randXPos = Random.Range(-xPosRange, xPosRange); //method overloading
            int animalPrefabIndex = Random.Range(0, animalPrefabs.Length);
            Vector3 randPos = new Vector3(randXPos, 0, 21); //no longer xpos now whole pos
            Instantiate(animalPrefabs[animalPrefabIndex], randPos, //why not randXPos?
                animalPrefabs[animalPrefabIndex].transform.rotation);
        }
    }
}
