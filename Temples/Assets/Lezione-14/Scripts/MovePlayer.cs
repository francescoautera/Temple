using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
namespace L13.RispoliFederico
{
    public class MovePlayer : MonoBehaviour
    {
        //public RotateObject rotate;
        public bool isRotating;
        Vector3 dir;
        [SerializeField] float velocity = 10f;
        [SerializeField]private bool GodMode;

        // Start is called before the first frame update
        void Start()
        {
            GodMode = false;
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

        private void OnTriggerEnter(Collider other)
        {
            if (other.CompareTag("Enemy")&&!GodMode) {
                SceneManager.LoadScene(SceneManager.GetActiveScene().name);
            
            }
            if (other.CompareTag("Finish")) {
                SceneManager.LoadScene(SceneManager.GetActiveScene().name);

            }
        }

        public void God() {
            GodMode = !GodMode;
        }
    }

   

}
