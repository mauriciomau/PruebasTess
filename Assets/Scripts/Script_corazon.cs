using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Script_corazon : MonoBehaviour
{

    public ParticleSystem [] particulas;
  

    public void Update()
        {
      /*  if (Input.GetKeyDown(KeyCode.A))
        {
            foreach (var item in particulas)
            {
                item.Play();

            }
        }    
      */


    }

    public void boton()
    {
        foreach (var item in particulas)
        {
            item.Play();

        }


    }

}
