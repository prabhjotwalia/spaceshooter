using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class Spaceship1 : MonoBehaviour
{
    public float MovementSpeed = 3;
    public float MovementSpeed1 = 3;
    public float ShiftSpeed = 24;
    [SerializeField]
    GameObject mExplosionPrefab;
    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

        float movement = Input.GetAxisRaw("Horizontal");
        float movement1 = Input.GetAxisRaw("Vertical");

        Debug.Log("Horizontal = " + movement);
        transform.position += new Vector3(movement, 0, 0) * Time.deltaTime * MovementSpeed;


        Debug.Log("Vertical = " + movement1);
        transform.position += new Vector3(0, movement1, 0) * Time.deltaTime * MovementSpeed1;

        if (Input.GetKey(KeyCode.LeftShift) && Input.GetKey(KeyCode.UpArrow))
        {
            transform.position += new Vector3(0, 0, 1) * Time.deltaTime * MovementSpeed;
        }
        if (Input.GetKey(KeyCode.LeftShift) && Input.GetKey(KeyCode.DownArrow))
        {
            transform.position += new Vector3(0, 0, -1) * Time.deltaTime * MovementSpeed;
        }


    }
    void OnCollisionEnter2D(Collision2D col)
    {
        if (col.gameObject.tag == "enemy")
        {
            Destroy(col.gameObject);
            Destroy(gameObject);
            SceneManager.LoadScene("Gameover");
            
        }



    }
}
    


    

