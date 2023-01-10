using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PositionRenderer : MonoBehaviour
{
    //Setting the layer to front according to y Axis
    public int sortingOrderBase = 5000;
    private Renderer myRenderer;
    public int offset = 0;

    void Awake()
    {
        myRenderer = gameObject.GetComponent<Renderer>();
    }

    void LateUpdate()
    {
        myRenderer.sortingOrder = (int)(sortingOrderBase - transform.position.y - offset);
    }
}
