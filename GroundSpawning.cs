using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GroundSpawning : MonoBehaviour
{
    // Variables
    public GameObject groundTile;
    Vector3 nextSpawnPoint;

    // Functions

    void SpawnTile() {
        GameObject temp = Instantiate(groundTile, nextSpawnPoint, Quaternion.identity);
        nextSpawnPoint = temp.transform.GetChild(1).transform.position;            
    }

    // Start is called before the first frame update
    void Start()
    {
        for (int i = 0; i < 15; i++)
        {
            SpawnTile();
        }
    }

    // Update is called once per frame
    //   void Update()
    //   {
    //       
    //   }
}
