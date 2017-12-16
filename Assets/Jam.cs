using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class Jam : MonoBehaviour
{
    public Text ScoreText;
    static int Score = 0;
    [SerializeField]
    GameObject mExplosionPrefab;
    void OnTriggerEnter2D(Collider2D col)
    {
        if (col.gameObject.layer == LayerMask.NameToLayer("BusterBullet"))
        {
            Instantiate(mExplosionPrefab, transform.position, Quaternion.identity);
            Destroy(col.gameObject);
            Destroy(gameObject);
            UpdateScore();
        }
    }
    void OnTriggerStay2D(Collider2D col)
    {
        if (col.gameObject.layer == LayerMask.NameToLayer("Player"))
        {
            Destroy(gameObject);
            SceneManager.LoadScene("Gameover");
        }
    }
    public void UpdateScore()
    {
        Score++;
        ScoreText.text = "Score:" + Score;
    }
}