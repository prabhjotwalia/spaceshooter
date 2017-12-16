using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movingobject : MonoBehaviour {
    public float FollowSpeed = 5f;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        
        transform.Translate(new Vector3(-4, -8, 0) * FollowSpeed * Time.deltaTime);
 
	}
}
