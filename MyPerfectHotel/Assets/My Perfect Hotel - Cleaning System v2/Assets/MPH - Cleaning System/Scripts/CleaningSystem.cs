using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(PlayerController))]
public class CleaningSystem : MonoBehaviour
{
    [Header(" Elements ")]
    private PlayerController playerController;

    [Header(" Settings ")]
    [SerializeField] private float detectionRadius;
    [SerializeField] private float cleanSpeed;

    [Header(" Test ")]
    [SerializeField] private int frameRate;

    // Start is called before the first frame update
    void Start()
    {
        playerController = GetComponent<PlayerController>();
        Application.targetFrameRate = frameRate;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
            Debug.Log("Mouse");

        if (Input.GetKeyDown(KeyCode.Space))
            Debug.Log("Space");

        if (Input.GetKeyDown(KeyCode.M))
        {
            Debug.Log("Here");
            
            foreach (Cleanable cleanable in FindObjectsOfType<Cleanable>())
                cleanable.MessUp();

        }

        if (!playerController.IsMoving())
            DetectCleanables();
    }

    private void DetectCleanables()
    {
        Collider[] detectedColliders = Physics.OverlapSphere(transform.position, detectionRadius);

        foreach (Collider collider in detectedColliders)
            if (collider.transform.parent.TryGetComponent(out Cleanable cleanable))
            {
                if (!cleanable.IsClean())
                {
                    cleanable.CleanProcess(cleanSpeed * Time.deltaTime);
                    break;
                }
            }
    }
}
