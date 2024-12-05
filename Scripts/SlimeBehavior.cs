using UnityEngine;

public class SlimeBehavior : MonoBehaviour
{
    public Animator slimeAnimator;
    public GameObject pointOfView;
    public float sleepWakeCycleTime = 5f;  // Time for sleep/wake cycle

    private bool isAwake = true;

    void Start()
    {
        // Start the cycle of sleep/wake
        InvokeRepeating("ToggleSleepWake", 0f, sleepWakeCycleTime);
    }

    void Update()
    {

    }

    // toggles between sleep and wake states
    void ToggleSleepWake()
    {
        isAwake = !isAwake;  // Toggle the awake state
        
        if (isAwake)
        {
            // Play the awake (idle) animation and enable the PointOfView
            slimeAnimator.Play("IdleNormal");  // Play the awake animation
            pointOfView.SetActive(true);  // Enable the PointOfView game object
            Debug.Log("Slime is Awake!");
        }
        else
        {
            // Play the sleep (die) animation and disable the PointOfView
            slimeAnimator.Play("Die");  // Play the death animation
            pointOfView.SetActive(false); // Disable the PointOfView game object
            Debug.Log("Slime is Asleep!");
        }
    }
}
