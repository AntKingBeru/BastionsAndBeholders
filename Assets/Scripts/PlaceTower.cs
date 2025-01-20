using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class PlaceTower : MonoBehaviour
{
    private Vector3 mousePos;
    private Vector3 objectPos;
    public GameObject Tower;
    public TMP_Text cash;
    public TMP_Text cost;

    void Update()
    {
        int diff = int.Parse(cash.text) - int.Parse(cost.text);
        if(Input.GetButtonDown("Fire1"))
        {
            mousePos = Input.mousePosition;
            mousePos.z = 2.0f;
            objectPos = Camera.main.ScreenToWorldPoint(mousePos);
            if (diff >= 0)
            {
                Instantiate(Tower, objectPos, Quaternion.identity);
                cash.text = $"{diff}";
            }
        }
    }
}
