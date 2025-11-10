using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Triggerpoint : MonoBehaviour
{
    public Transform SpikeBall;
    public Transform Spawnpoint;
    // Start is called before the first frame update

    void RespawnEnemy(){
        Instantiate(SpikeBall, Spawnpoint.transform.position, Spawnpoint.transform.rotation);
    }

    void OnTriggerEnter2D(Collider2D other){
        if(other.gameObject.tag == "Player"){
            RespawnEnemy();
        }
    }

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
