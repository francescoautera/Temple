using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace L13.RispoliFederico {
    public class MonsterManager : MonoBehaviour
    {
        MoveMonster[] move;
       // Start is called before the first frame update
       void Start()
        {
            move = FindObjectsOfType<MoveMonster>();
        }

        // Update is called once per frame
        void Update()
        {

        }

        public void StopSpawn() {
            for (int i = 0; i < move.Length; i++) {
                move[i].StopMove();
            }
        }
    }
}
