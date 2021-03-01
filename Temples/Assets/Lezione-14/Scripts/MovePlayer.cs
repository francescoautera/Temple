using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace L13.RispoliFederico
{
    public class MovePlayer : MonoBehaviour
    {
        //public RotateObject rotate;
        public bool isRotating;
        Vector3 dir;
        [SerializeField] float velocity = 10f;

        // Start is called before the first frame update
        void Start()
        {

        }

        // Update is called once per frame
        void Update()
        {
            if (!isRotating)
            {
                if (Input.GetKey(KeyCode.W))
                {
                    dir = new Vector3(0, 0, 1);
                    transform.position += dir * velocity * Time.deltaTime;

                }
                else if (Input.GetKey(KeyCode.S))
                {
                    dir = new Vector3(0, 0, -1);
                    transform.position += dir * velocity * Time.deltaTime;

                }
            }
            else {
                if (Input.GetKey(KeyCode.W))
                {
                    dir = new Vector3(0, 0, -1);
                    transform.position += dir * velocity * Time.deltaTime;

                }
                else if (Input.GetKey(KeyCode.S))
                {
                    dir = new Vector3(0, 0, 1);
                    transform.position += dir * velocity * Time.deltaTime;

                }

            }
            
        }
    }

}
