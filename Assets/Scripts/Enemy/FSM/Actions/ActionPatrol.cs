using UnityEngine;

public class ActionPatrol : FSMAction
{
    [Header("Config")]
    [SerializeField] private float speed;

    private Waypoint Waypoint;
    private int pointIndex;
    private Vector3 nextPosition;

    private void Awake()
    {
        Waypoint = GetComponent<Waypoint>();
    }
    public override void Act()
    {
        FollowPath();
    }

    private void FollowPath()
    {
        transform.position = Vector3.MoveTowards(transform.position,GetCurrentPosition(),speed * Time.deltaTime);
        if (Vector3.Distance(transform.position, GetCurrentPosition()) <= 0.1f)
        {
            UpdateNextPosition();
        }
    }

    private void UpdateNextPosition()
    {
        pointIndex++;
        if(pointIndex > Waypoint.Points.Length - 1)
        {
            pointIndex = 0; 
        }
    }

    private Vector3 GetCurrentPosition()
    {
        return Waypoint.GetPosition(pointIndex);
    }
}
