using UnityEngine;

public class ScoreBoard : MonoBehaviour
{
    private int _skor;

    public void SkorEkle(int amount)
    {
        _skor += amount;
        Debug.Log("Score: " + _skor);
    }

    public void SkorEksilt(int amount)
    {
        _skor -= amount;
        Debug.Log("Score Dustu!: " + _skor);
    }
}
