using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace L15.Fruit{ 
public class SpawnManager : MonoBehaviour
{
        GameManager manager;
        public GameObject watermelon;
        public GameObject candy;
        public GameObject orange;
        [SerializeField] float timer;
    // Start is called before the first frame update
    void Start()
    {
       manager = FindObjectOfType<GameManager>();
       timer = manager.spawnTimer;
    }

    // Update is called once per frame
    void Update()
    {
       timer -= Time.deltaTime;
       if (timer < 0) {
          int x = Random.Range(0, 3);
                switch (x)
                {
                    case 0:
                        var instanciate=Instantiate(watermelon,transform.position,Quaternion.identity,transform);
                        // var comp= instanciate.Getcomponent<FruitMove>();
                        //comp.velocity=manager.velocity;
                        break;
                    case 1:
                        var inst=Instantiate(candy, transform.position, Quaternion.identity, transform);
                       
                        break;
                    case 2:
                        var inst2= Instantiate(orange, transform.position, Quaternion.identity, transform);
                        break;
                    default:
                        break;

                }
                timer = manager.spawnTimer;
       } 
    }
}
}
