using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
namespace L13.RispoliFederico
{
    public class timer : MonoBehaviour
    {
        public Text text;
        [SerializeField] float time = 20f;
        bool stoptimer;
        // Start is called before the first frame update
        void Start()
        {
            text.text = "Timer:" + time;
            text.gameObject.SetActive(false);
            stoptimer = false;
        }

        // Update is called once per frame
        void Update()
        {

        }

        public IEnumerator StartTimer()
        {
            text.gameObject.SetActive(true);

            while (time > 0 && !stoptimer)
            {
                time -= Time.deltaTime;
                text.text = "Timer:" + time;
                yield return null;
            }
            if (time < 0) {
                SceneManager.LoadScene(SceneManager.GetActiveScene().name);
            }
        }

        public void StopTimer() {
            stoptimer = !stoptimer;
        }
    }
}