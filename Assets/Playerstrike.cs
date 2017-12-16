using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Playerstrike : MonoBehaviour
{

    [SerializeField]
    public Text ScoreText;
    static int Score = 0;

    void OnCollisionEnter2D(Collision2D col)
    {
        if (col.gameObject.tag == "Player")
        {
            Destroy(gameObject);

            Score++;
            ScoreText.text = "Coins :" + Score;

        }
    }
}
