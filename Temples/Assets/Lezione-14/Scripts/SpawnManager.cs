using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
namespace L13.RispoliFederico
{
    public class SpawnManager : MonoBehaviour
    {

        public SpawnArrow[] SpawnArrow;
        private bool stopSpawn;
        // Start is called before the first frame update
        void Start()
        {
            SpawnArrow = FindObjectsOfType<SpawnArrow>();
            stopSpawn = false;

        }
        // Update is called once per frame
        void Update()
        {

        }

        public void Spawn()
        {
            if (!stopSpawn)
            {
                for (int i = 0; i < SpawnArrow.Length; i++)
                {
                    SpawnArrow[i].Spawn();

                }
            }
        }

        public void Stop()
        {
            stopSpawn = !stopSpawn;

        }
    }


}
