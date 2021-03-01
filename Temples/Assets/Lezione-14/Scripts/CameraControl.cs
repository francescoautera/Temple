using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace L13.RispoliFederico.MyFirstGame
{
    public class CameraControl : MonoBehaviour
    {

        public float speedH = 2.0f;
        public float speedV = 2.0f;

        private float moveH = 0.0f;
        private float moveV = 0.0f;



        // Use this for initialization
        void Start()
        {

        }

        // Update is called once per frame
        void Update()
        {

            moveH += speedH * Input.GetAxis("Mouse X");
            moveV -= speedV * Input.GetAxis("Mouse Y");

            transform.eulerAngles = new Vector3(moveV, moveH, 0.0f);
        }
    }
}