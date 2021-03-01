using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
namespace L13.RispoliFederico{ 
public class timer : MonoBehaviour
{
     public Text text;
     [SerializeField] float time=20f;
    // Start is called before the first frame update
    void Start()
    {
      text.text = "Timer:" + time;
      text.gameObject.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

        public IEnumerator  StartTimer()
        {
            text.gameObject.SetActive(true);
            while (time > 0)
            {
                time -= Time.deltaTime;
                text.text = "Timer:" + time;
                yield return null;
            }
           

    }   
}
}