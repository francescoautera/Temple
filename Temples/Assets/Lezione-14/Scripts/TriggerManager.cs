using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace L13.RispoliFederico
{
    public enum Trigger { arrow, treasure }
    public class TriggerManager : MonoBehaviour
    {
        public Trigger trigger;
        public SpawnManager SpawnArrow;
        public GameObject Wall;
        public GameObject Treasure;
        MovePlayer MovePlayer;
        public Camera camera;
        // Start is called before the first frame update
        void Start()
        {
            MovePlayer = FindObjectOfType<MovePlayer>();
        }

        // Update is called once per frame
        void Update()
        {

        }

        private void OnTriggerEnter(Collider other)
        {
            if (other.CompareTag("Player")) {
                
                switch (trigger) {
                    case Trigger.arrow:
                        SpawnArrow.Spawn();
                        break;
                    case Trigger.treasure:
                        Destroy(Wall);
                        Destroy(Treasure);
                        Quaternion rotate = new Quaternion(0, 180, 0,1);
                        camera.gameObject.transform.rotation = rotate;
                        MovePlayer.isRotating = true;
                        break;
                    default:
                        break;
                }
            }
        }

    }
}