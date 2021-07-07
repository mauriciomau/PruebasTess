using System.Collections;
using System.Collections.Generic;
using UnityEngine.Audio;
using UnityEngine;

public class Sonidos : MonoBehaviour
{

    public GameObject sonido;
    bool numero = true;
  //  public AudioSource sound;
    //bool prender = true;

    // Start is called before the first frame update
    void Start()
    {
     //   sound = GetComponent<AudioSource>();      
    }

    // Update is called once per frame
    void Update()
    {
        /*  if ((Input.GetKeyDown(KeyCode.P)) && (prender == true))
          {
              sound.Play();
          }

              if (sound.isPlaying)
          {

              prender = false;
          }

          if (!sound.isPlaying)
          {

              prender = true;
          }
        */
          if (Input.GetKeyDown(KeyCode.P) && (numero == true) )
          {
              
           Instantiate(sonido); 
            numero = false;
        }
        

    }
}
