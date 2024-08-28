using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public float speed;
    private Rigidbody enemyRb;
    private GameObject Character;

    // Start is called before the first frame update
    void Start()
    {
        enemyRb = GetComponent<Rigidbody>();
        Character = GameObject.Find("Character");
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 lookDirection = (Character.transform.position - transform.position).normalized;
        enemyRb.AddForce(lookDirection * speed);
    }
}
