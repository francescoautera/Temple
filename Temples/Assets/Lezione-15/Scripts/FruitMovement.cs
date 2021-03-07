using System.Collections;
using UnityEngine;

namespace L15.Fruit 
{
    public class FruitMovement : MonoBehaviour
    {

        private int mid = 0;
        [SerializeField] public float vel;
        [SerializeField] public float gravity = 1f;
        Vector3 vect;

        private void Start()
        {
            if (gameObject.transform.position.x >= mid)
            {
                vect = new Vector3(-vel, -gravity);
            }
            else
            {
                vect = new Vector3(vel, -gravity);
            }
        }

        private void Update()
        {
            transform.position += vect * Time.deltaTime;
        }

        private void OnTriggerEnter(Collider other)
        {
            if (other.CompareTag("Finish")) {
                Destroy(gameObject);
            }
        }
    }
}
