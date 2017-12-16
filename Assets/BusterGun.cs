using UnityEngine;
using System.Collections;

public class BusterGun : MonoBehaviour
{
  
    bool mShooting;

    float kShootDuration = 0.25f;
    float mTime;

    public GameObject mBulletPrefab;
    Spaceship1 mSpaceship1Ref;

    AudioSource mBusterSound;

    void Start ()
    {



        mSpaceship1Ref = transform.parent.GetComponent<Spaceship1>();
        mBusterSound = transform.parent.GetComponent<AudioSource>();
        
    }

    void Update ()
    {
        if(Input.GetButtonDown ("Fire"))
        {
            
            GameObject bulletObject = Instantiate(mBulletPrefab, transform.position, Quaternion.identity);
            Bullet bullet = bulletObject.GetComponent<Bullet>();



           
            mShooting = true;
            mTime = 0.0f;
        }

        if(mShooting)
        {
            mTime += Time.deltaTime;
            if(mTime > kShootDuration)
            {
                mShooting = false;
            }
        }

       
    }
    
}
