using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
namespace L15.Fruit
{
    public class TextManager : MonoBehaviour
    {
        public Text point;
        public Text timer;
        GameManager manager;
        // Start is called before the first frame update
        void Start()
        {
            manager = FindObjectOfType<GameManager>();
            point.text = "Punteggio:" + manager.points;
            timer.text = "Timer:" + manager.timer;
        }

        // Update is called once per frame
        void Update()
        {
            timer.text = "Timer:" + manager.timer;
            point.text = "Punteggio:" + manager.points;
        }


    }
}
