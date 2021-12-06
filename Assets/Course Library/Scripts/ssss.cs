using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ssss : MonoBehaviour
{

    public GameObject timeDisplay;
    public int seconds = 20;
    public bool deductingTime;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (seconds == 0)
        {
            seconds = 0;
            Debug.Log("Game over!");
        }
        else
        {

            if (deductingTime == false)
            {
                deductingTime = true;
                StartCoroutine(DetuctSecond());
            }
        }
    }

    IEnumerator DetuctSecond()
    {
        yield return new WaitForSeconds(1);
        seconds -= 1;
        timeDisplay.GetComponent<Text>().text = "Time:" + seconds;
        deductingTime = false;

    }
}
