using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public float speed;
    private Rigidbody enemyRb;
    private GameObject player;

    // Start is called before the first frame update
    void Start()
    {
        enemyRb = GetComponent<Rigidbody>();
        player = FindObjectOfType<playerControl>().gameObject;

    }

    // Update is called once per frame
    void Update()
    {
        if (player.transform.position.z < -99)
        {
            Vector3 directionToPlayer = player.transform.position - transform.position;
        
            enemyRb.AddForce(directionToPlayer.normalized * speed);
        
            if (transform.position.y < -10) 
            {
            Destroy(gameObject); 
            } 
        }
    }
}
