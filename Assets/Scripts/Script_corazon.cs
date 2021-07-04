using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Script_corazon : MonoBehaviour
{

    public ParticleSystem [] particulas;
  


    public void boton()
    {
        foreach (var item in particulas)
        {
            item.Play();

        }


    }

}
