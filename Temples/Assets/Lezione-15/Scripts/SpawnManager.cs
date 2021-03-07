using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace L15.Fruit
{
    public class SpawnManager : MonoBehaviour
    {
        GameManager manager;
        public GameObject watermelon;
        public GameObject candy;
        public GameObject orange;
        public GameObject WallUp;
        public GameObject WallDown;
        Vector3 pos;
        [SerializeField] float timer;
        [SerializeField]private bool stopSpawn;
        // Start is called before the first frame update
        void Start()
        {
            manager = FindObjectOfType<GameManager>();
            timer = manager.spawnTimer;
            stopSpawn = false;
        }

        // Update is called once per frame
        void Update()
        {
            if (!stopSpawn)
            {
                timer -= Time.deltaTime;
                if (timer < 0)
                {
                    int x = Random.Range(0, 3);
                    pos = new Vector3(transform.position.x, Random.Range(WallDown.transform.position.y, WallUp.transform.position.y), transform.position.z);
                    switch (x)
                    {
                        case 0:
                            var instanciate = Instantiate(watermelon, pos, Quaternion.identity, transform);
                            var component = instanciate.GetComponent<FruitMovement>();
                            component.vel = manager.velocity;
                            break;
                        case 1:
                            var inst = Instantiate(candy, pos, Quaternion.identity, transform);
                            var comp = inst.GetComponent<FruitMovement>();
                            comp.vel = manager.velocity;
                            break;
                        case 2:
                            var inst2 = Instantiate(orange, pos, Quaternion.identity, transform);
                            var comp2 = inst2.GetComponent<FruitMovement>();
                            comp2.vel = manager.velocity;
                            break;
                        default:
                            break;

                    }
                    timer = manager.spawnTimer;
                }
            }
        }

        public void StopSpawn()
        {
            stopSpawn = !stopSpawn;

        }
    }
}
