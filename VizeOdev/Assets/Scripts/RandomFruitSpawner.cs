using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Random = UnityEngine.Random;

public class RandomFruitSpawner : MonoBehaviour
{
   public GameObject[] fruits;
   private float SpawnTimer = 2f;
   private float timer;

   private void Update()
   {
       timer += Time.deltaTime;
       if (timer > SpawnTimer)
       {
           RandomSpawn();
           timer = 0;
       }
   }

   void RandomSpawn()
   {
      
      
       int RandomIndex = Random.Range(0, fruits.Length);
       Vector3 randomSpawnPosition = new Vector3(Random.Range(-8,-3),5, -16);
         
       Instantiate(fruits[RandomIndex], randomSpawnPosition, Quaternion.identity);
   }
}
