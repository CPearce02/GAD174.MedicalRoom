using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightBehaviour : MonoBehaviour
{
    public GameObject[] lights;
    public AudioSource[] sounds;
    [SerializeField] float chance;
    private bool lightsOn;
     
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(LightFlickerTimer());
        lightsOn = true;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

      IEnumerator LightFlickerTimer()
    {
        
        Debug.Log("light flicker triggered.");
        chance = Random.Range(0f, 5f);

        yield return new WaitForSeconds(chance);

        for (int i = 0; i < lights.Length; i++)
        {
            if (lightsOn == true)
            {
                lights[i].SetActive(false);
                sounds[0].Stop();
                sounds[1].Stop();
                lightsOn = false;
            }
            else if (lightsOn == false)
            {
                lights[i].SetActive(true);
                sounds[0].Play();
                sounds[1].Play(); 
                lightsOn = true;
            }
                

        }

        StartCoroutine(LightFlickerTimer());   

        
    }

}
