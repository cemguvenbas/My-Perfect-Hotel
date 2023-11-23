using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Cleanable : MonoBehaviour
{
    [Header(" Elements ")]
    [SerializeField] private Image fillImage;
    [SerializeField] private Animator animator;
    [SerializeField] private Canvas canvas;
    [SerializeField] private ParticleSystem cleanParticles;

    [Header(" Settings ")]
    private bool isClean;

    // Start is called before the first frame update
    void Start()
    {
        MessUp();
    }

    // Update is called once per frame
    void Update()
    {
        FaceCanvas();
    }

    private void FaceCanvas()
    {
        canvas.transform.forward = (Camera.main.transform.position - canvas.transform.position).normalized;
    }

    public void CleanProcess(float value)
    {
        fillImage.fillAmount += value;

        if (fillImage.fillAmount >= 1)
            SetAsClean();
    }

    private void SetAsClean()
    {
        isClean = true;

        canvas.gameObject.SetActive(false);

        animator.Play("Clean");

        Debug.Log(string.Format("{0} is now clean", name));

        cleanParticles.Play();
    }

    public void MessUp()
    {
        isClean = false;

        canvas.gameObject.SetActive(true);

        fillImage.fillAmount = 0;

        animator.Play("MessUp");

        Debug.Log("Messing up " + name);
    }

    public bool IsClean()
    {
        return isClean;
    }

}
