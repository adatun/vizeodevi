using System;
using UnityEngine;

public class YokOl : MonoBehaviour
{
   private void OnCollisionEnter(Collision other)
   {
      if (other.gameObject.tag == "Ground")
      {
         Destroy(this.gameObject);
      }
   }
}
