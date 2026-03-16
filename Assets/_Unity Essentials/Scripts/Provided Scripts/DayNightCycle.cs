using UnityEngine;

public class DayNightCycle : MonoBehaviour
{
    [Tooltip("How many real-time seconds a full day lasts")]
    public float dayDurationInSeconds = 120f;

    private float rotationSpeed;

    void Start()
    {
        // 360 degrees divided by the total duration gives degrees per second
        rotationSpeed = 360f / dayDurationInSeconds;
    }

    void Update()
    {
        // Rotate around the X axis to simulate the sun moving across the sky
        transform.Rotate(Vector3.right * rotationSpeed * Time.deltaTime);
    }

    void OnValidate()
    {
        if (dayDurationInSeconds <= 0)
            dayDurationInSeconds = 1f;

        rotationSpeed = 360f / dayDurationInSeconds;
    }
}