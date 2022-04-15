using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CountNumberView : MonoBehaviour
{
    private Text numText;

    void Awake()
    {
        numText = gameObject.GetComponent<Text>();
    }

    public void SetNumber(int num)
    {
        numText.text = num.ToString();
    }
}
