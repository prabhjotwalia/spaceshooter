using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class death : MonoBehaviour
{
    void update()
    {
    }
        void OnCollisionEnter2D(Collision2D coll)
    {
            // TODO: Check if I am being hit by a bullet
            //       If that's the case, do the following:
            //          - Destroy the bullet
            //          - Destroy myself
            //          - Instantiate an explosion (use the prefab "mExplosionPrefab")
            if (coll.gameObject.tag == "EnemyBullet")
            {
                Destroy(coll.gameObject);
                Destroy(gameObject);
            SceneManager.LoadScene("Gameover");
            // Instantiate(mExplosionPrefab, transform.position, Quaternion.identity);



        }
        }
    }
