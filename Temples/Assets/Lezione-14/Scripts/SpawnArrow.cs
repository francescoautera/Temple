using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace L13.RispoliFederico
{
    public class SpawnArrow : MonoBehaviour
    {
        public GameObject arrow;
        public GameObject Wall;
        public MovePlayer Player;
        public ArrowManager manager;
        [SerializeField] private float timer;
        [SerializeField] private float globaltimer=3f;

        

        [SerializeField] private float shutdown = 0.5f;
        Vector3 pos;
        // Start is called before the first frame update
        void Start()
        {
            timer = 0;
            
        }

        // Update is called once per frame
        void Update()
        {

        }

       public void Spawn() {

            Vector3 pos = new Vector3(Wall.transform.position.x,Player.transform.position.y, Wall.transform.position.z);
            var instanciate = Instantiate(arrow, pos, Quaternion.identity,manager.transform);
            var comp = instanciate.GetComponent<MoveArrow>();
            comp.posPlayer = Player.transform.position;

        
        }
    }
}