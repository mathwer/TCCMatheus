using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;


public class Zoom : MonoBehaviour
{

    int counter = 0;
    RectTransform RTrans;
    public void toque()

    {
        Vector2 anMax = GetComponent<RectTransform>().anchorMin;
        Vector2 anMin = GetComponent<RectTransform>().anchorMax;
        Vector2 pivot = GetComponent<RectTransform>().pivot;
        counter++;

        if (counter % 2 == 1)
        {
            GetComponent<RectTransform>().SetAsLastSibling();
            GetComponent<RectTransform>().localScale = new Vector2(2f, 2f);

        }
        else
        {
            GetComponent<RectTransform>().localScale = new Vector2(1f, 1f);
            //GetComponent<Transform>().position = new Vector3(1f, 1f, 1f);

        }
        Debug.Log(counter);

    }
}



