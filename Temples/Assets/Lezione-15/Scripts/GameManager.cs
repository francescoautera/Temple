using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace L15.Fruit { 
public class GameManager : MonoBehaviour
{
    public float timer;
    public float velocity;
    [SerializeField] float event1; 
    [SerializeField] float event2;    
    [SerializeField] float event3;
    public float spawnTimer; 
    private bool isDone1;
    private bool isDone2;
    private bool isDone3;
    public  int points;
    private bool timerStop;

        
     // Start is called before the first frame update
    void Start()
    {
            timer=60f;
            event1 = 30f;
            event2 = 15f;
            event3 = 5f;
            isDone1=false;
            isDone2=false;
            isDone3=false;
            points = 0;
            timerStop = false;
    }

        // Update is called once per frame
        void Update()
        {
            if (!timerStop)
            {
                timer -= Time.deltaTime;
                if (timer < event1 && !isDone1)
                {
                    IncreaseVelocity();
                    IncreaseSpawn();
                    isDone1 = true;
                }
                else if (timer < event2 && !isDone2)
                {
                    IncreaseSpawn();
                    isDone2 = true;
                }
                else if (timer < event3 && !isDone3)
                {
                    IncreaseVelocity();
                    isDone3 = true;
                }
                else if (timer < 0)
                {
                    SceneManager.LoadScene(SceneManager.GetActiveScene().name);
                }
            }
    }

        public void IncreaseVelocity() {
            velocity += 10;
        }

        private void IncreaseSpawn() {
            spawnTimer -= 0.3f;
        }

        public void StopTimer() {
            timerStop = !timerStop;
        }

        public void DecreaseVelocity() {
            velocity -= 10;
        }
}
}