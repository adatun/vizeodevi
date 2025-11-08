using System;
using UnityEngine;
using UnityEngine.SceneManagement;
public class GameOver : MonoBehaviour
{
  private void OnCollisionEnter(Collision other)
  {
    if (other.gameObject.CompareTag("Ground"))
    {
      Debug.Log("Oyunu Kaybettiniz!");
      SceneManager.LoadScene("MeyveToplama");
    }
  }
}
