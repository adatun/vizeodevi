using System;
using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;

public class FruitCollecter : MonoBehaviour
{
   [SerializeField] private ScoreBoard scoreBoard;

   private void Start()
   {
       scoreBoard = FindObjectOfType<ScoreBoard>();
   }

   private void OnTriggerEnter(Collider other)
   {
       switch (this.tag)
       {
           case "Apple":
               scoreBoard.SkorEkle(2);
               Destroy(this.gameObject);
               break;
           
           case "Peach":
               scoreBoard.SkorEkle(4);
               Destroy(this.gameObject);
               break;
           
           case "Pear":
               scoreBoard.SkorEkle(3);
               Destroy(this.gameObject);
               break;
           
           case "Strawberry":
               scoreBoard.SkorEkle(1);
               Destroy(this.gameObject);
               break;
           
           case "Cherry":
               scoreBoard.SkorEkle(1);
               Destroy(this.gameObject);
               break;
           
           case "Watermelon":
               scoreBoard.SkorEkle(5);
               Destroy(this.gameObject);
               break;
           
           case "Rock":
               scoreBoard.SkorEksilt(3);
               Destroy(this.gameObject);
               break;
       }
      
   }
   
}
