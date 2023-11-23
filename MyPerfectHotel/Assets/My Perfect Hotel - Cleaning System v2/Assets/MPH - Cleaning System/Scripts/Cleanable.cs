using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Cleanable : MonoBehaviour
{
    [Header("Elements")]
    [SerializeField] private Image gageFill;

    [Header("Settings")]
    private bool isClean;

    private void Start()
    {
        MessUp();
    }

    public void Clean(float value)
    {
        gageFill.fillAmount += value;

        if (gageFill.fillAmount >= 1)
            SetAsClean();
    }

    public void MessUp()
    {
        gageFill.fillAmount = 0;

        isClean = false;
    }

    private void SetAsClean()
    {
        isClean = true;
        Debug.Log("Hey, I'm clean");
    }

    public bool IsClean()
    {
        return isClean;
    }
}
