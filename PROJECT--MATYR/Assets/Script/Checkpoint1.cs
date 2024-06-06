using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Checkpoint1 : MonoBehaviour
{
    [SerializeField] GameObject player;
    [SerializeField] List<GameObject> checkpoint;
    [SerializeField] Vector3 vectorPoint;
    //private float death;

    // Update is called once per frame
    void LateUpdate()
    {
        if (player.transform.position.y <= -20.0f)
        {
            player.transform.position = vectorPoint;
        }
    }
    
    private void OnTriggerEnter(Collider other)
    {
        vectorPoint = player.transform.position;
        //Destroy(other.gameObject);
    }
}
