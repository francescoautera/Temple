using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace L13.RispoliFederico
{
    public class MoveArrow : MonoBehaviour
    {
        public Vector3 posPlayer;
        [SerializeField]float velocity=10f;
        Vector3 move;
        // Start is called before the first frame update
        void Start()
        {
            move= GetDirection();
        }

        // Update is called once per frame
        void Update()
        {
            transform.position += move * Time.deltaTime * velocity;
        }

        private Vector3 GetDirection() {
            Vector3 pos = Vector3.zero;
            if (transform.position.x - posPlayer.x> 0)
            {
                pos = new Vector3(-1, 0, 0);
            }
            else if  (transform.position.x - posPlayer.x <= 0){
                pos = new Vector3(1, 0, 0);
            }
            return pos;
        }
    }

    
}
