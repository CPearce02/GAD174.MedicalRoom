using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class TriggerText : MonoBehaviour
{
    public TextMeshProUGUI flavourText;
    public string text;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        flavourText.text = text;
        flavourText.gameObject.SetActive(true);
    }

    private void OnTriggerExit(Collider other)
    {
        flavourText.gameObject.SetActive(false);
    }

}
