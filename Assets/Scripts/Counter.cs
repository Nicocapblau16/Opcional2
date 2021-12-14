using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Counter : MonoBehaviour
{
    private int counter = 10;

    private TextMeshProUGUI counterText;

    public string counterString;


    // Start is called before the first frame update
    void Start()
    {
        counterText = GetComponent<TextMeshProUGUI>();
        StartCoroutine("BackwardCounter");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private IEnumerator BackwardCounter()
    {
        while (counter > 0)
        {
            counter -= 1;
            counterString = counter.ToString();
            counterText.Text = counterString;
            yield return WaitForSeconds(1f);
        }
        

    }
}
