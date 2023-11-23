using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Cleanable : MonoBehaviour
{
    [Header("Elements")]
    [SerializeField] private Image gageFill;

    public void Clean(float value)
    {
        gageFill.fillAmount += value;

        if (gageFill.fillAmount >= 1)
            SetAsClean();
    }

    private void SetAsClean()
    {
        Debug.Log("Hey, I'm clean");
    }
}
