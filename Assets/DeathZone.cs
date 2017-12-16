using UnityEngine;
using System.Collections;

public class DeathZone : MonoBehaviour
{
    void OnTriggerEnter2D(Collider2D col)
    {
        if(col.gameObject.layer == LayerMask.NameToLayer("Player"))
        {
            Destroy(col.gameObject);
            Destroy(gameObject);
        }
    }
}
