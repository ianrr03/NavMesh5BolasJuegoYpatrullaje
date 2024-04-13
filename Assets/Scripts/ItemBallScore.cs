using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemBallScore : MonoBehaviour
{
    public int scoreValue = 1;
    public ScoreManager scoreManager;
    private void Start()
    {
        scoreManager = GameObject.Find("TextScore").GetComponent<ScoreManager>();
    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.transform.CompareTag("Player"))
        {
            scoreManager.SumarPuntuacion(scoreValue);
            Destroy(this.gameObject); //Para que destruya la bola si la toca el player
        }
    }
}
