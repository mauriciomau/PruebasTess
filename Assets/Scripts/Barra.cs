using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Barra : MonoBehaviour
{

    public Image barrapr;
    [Range(0, 100)]
    public float scoreAc;
    [Range(0, 100)]
    public float scoreMax;


    // Start is called before the first frame update
    void Start()
    {

        
    }

    // Update is called once per frame
    void Update()
    {
        scoreAc = Mathf.Clamp(scoreAc, 0, 100);
        scoreMax = Mathf.Clamp(scoreMax, 0, 100);

        barrapr.fillAmount = scoreAc / scoreMax;

        
    }
}
