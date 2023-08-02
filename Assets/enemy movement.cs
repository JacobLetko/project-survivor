using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemymovement : MonoBehaviour
{
    public GameObject[] player;
    public float speed;


    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.FindGameObjectsWithTag("Player");
    }

    void Awake()
    {

    }

    // Update is called once per frame
    void Update()
    {   
        Vector3 playerPOS = player[0].transform.position;  
        transform.position = Vector3.MoveTowards(transform.position, playerPOS, speed * Time.deltaTime);
    }
}
