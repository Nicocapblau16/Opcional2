using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Counter : MonoBehaviour
{
    private int startCounter = 10;

    private TextMeshProUGUI counterText;

    //public string counterString;


    void Start()
    {
        counterText = GetComponent<TextMeshProUGUI>();
        StartCoroutine("BackwardCounter");
        counterText.text = "Starting...";
    }

  
    private IEnumerator BackwardCounter()
    {
        for (int counter = startCounter; counter >= 0; counter -= 1)
        {
            //counter = counter.ToString();
            counterText.text = counter.ToString();
            yield return new WaitForSeconds(1f);
        }
        

    }
    //no he podido cambiar la opcion a solid color porque ni me aparece la opcion

    //https://youtu.be/57n4dZAPxNY min 3:00 
}
