using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyGun : MonoBehaviour
{

    public GameObject BulletPrefab;

    public float reload = 0.25f;
    float t;

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

        t += Time.deltaTime;

        if (t >= reload)
        {
            GameObject bulletObject = Instantiate(BulletPrefab, transform.position, Quaternion.identity);
            Bullet bullet = bulletObject.GetComponent<Bullet>();

            bullet.SetDirection(Vector2.down);
            

            t = 0;
        }


    }
}
