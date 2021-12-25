using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CrossbarTrap : Obstacle
{
    [SerializeField, Range(-3.5f, -10)] private float _bulgeDistance;

    private void Awake()
    {
        SetObstacleParametres();
    }

    protected override void SetObstacleParametres(float waitingTime = 0)
    {
        transform.localPosition = new Vector3(transform.localPosition.x, _bulgeDistance, transform.localPosition.z);
    }
}