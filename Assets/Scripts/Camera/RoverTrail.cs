using UnityEngine;
using System.Collections;

public class RoverTrail : MonoBehaviour
{

    public TrailRenderer rightTrailRenderer;
    public TrailRenderer leftTrailRenderer;

    public float maxThickness;

    void Start()
    {
        rightTrailRenderer.emitting = false;
        leftTrailRenderer.emitting = false;
    }

    public void UpdateRightThickness(float thickness)
    {
        thickness *= maxThickness;

        if (thickness == 0)
        {
            rightTrailRenderer.emitting = false;
        }
        else
        {
            rightTrailRenderer.emitting = true;
            rightTrailRenderer.startWidth = rightTrailRenderer.endWidth = maxThickness;
        }
    }

    public void UpdateLeftThickness(float thickness)
    {
        thickness *= maxThickness;

        if (thickness == 0)
        {
            leftTrailRenderer.emitting = false;
        }
        else
        {
            leftTrailRenderer.emitting = true;
            leftTrailRenderer.startWidth = leftTrailRenderer.endWidth = maxThickness;
        }
    }
}
