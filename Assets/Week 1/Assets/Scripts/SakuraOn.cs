using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class SakuraOn : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler
{
    //variable for flowers
    public Image sakuraFlower;

    //sound for mouse over menu options
    //public AudioSource mouseOver;

    private void Start()
    {
        //disable flowers
        sakuraFlower.gameObject.SetActive(false);   
    }

    //on hover of button
    public void OnPointerEnter(PointerEventData eventData)
    {
        //enable onBulb
        sakuraFlower.gameObject.SetActive(true);

        //add sound
        //mouseOver.Play();

        //change cursor image on hover??
    }

    public void OnPointerExit(PointerEventData eventData)
    {
        //disable onBulb
        sakuraFlower.gameObject.SetActive(false);

    }
}
