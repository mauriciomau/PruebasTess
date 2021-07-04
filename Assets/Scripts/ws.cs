using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ws : MonoBehaviour
{

    public RectTransform ab;
    [Range(0,1)]
    public float valor;
    

    // Update is called once per frame
    void Update()
    {

        ab.sizeDelta = new Vector2(valor*500,ab.sizeDelta.y);

    }
}
