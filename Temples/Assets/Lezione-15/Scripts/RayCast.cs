using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace L15.Fruit
{
    public class RayCast : MonoBehaviour
    {
       
        [SerializeField] public float range;
        

        // Start is called before the first frame update
        void Start()
        {
            range = 100f;
        }

        // Update is called once per frame
        void Update()
        {


            if (Input.GetMouseButton(0))
            {
                Debug.Log("Bang");

                Ray pos = Camera.main.ScreenPointToRay(Input.mousePosition);
                RaycastHit hit;

                int layerMask = 1 << 2;

                layerMask = ~layerMask;

                if (Physics.Raycast(pos,out hit, range, layerMask));
                {               
                    Destroy(hit.collider.gameObject);
                }
            }
        }
    }
}