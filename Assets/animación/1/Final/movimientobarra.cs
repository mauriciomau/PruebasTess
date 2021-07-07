using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class movimientobarra : MonoBehaviour
{

    public Image barra;
    public Transform rotate;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        rotate.eulerAngles = new Vector3(0, 0, barra.fillAmount * -360);
    }
}
