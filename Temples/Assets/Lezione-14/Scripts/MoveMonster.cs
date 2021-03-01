using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace L13.RispoliFederico
{
    public class MoveMonster : MonoBehaviour
    {
        [SerializeField] int x;
        [SerializeField] float rad;
        [SerializeField] float bouncex;
        [SerializeField] float bouncey;
        [SerializeField] int xrange = 10;
        int direction;
        private int changedir = 1;
        // Start is called before the first frame update
        void Start()
        {
            direction=Direction();
        }

        // Update is called once per frame
        void Update()
        {
            x++;
            if (x > 180)
            {
                x = 0;
                changedir = -changedir;
            }
            rad = Mathf.Deg2Rad * x;
            bouncey = (Mathf.Cos(rad));
            bouncex = (Mathf.Sin(rad)) * changedir;
            
            transform.position += new Vector3(bouncex*xrange*direction, -bouncey, 0) * Time.deltaTime;

        }


        int  Direction() {
            int dir;
            if (transform.position.x > 0) {
                dir = -1;
            }
            else { 
                dir = 1;
            }
            return dir;
        }
      
    }
}
