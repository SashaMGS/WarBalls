using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyPatryl : MonoBehaviour
{
    public float Mass;
    public Vector3 MassVector;
    public int Speed;
    private float WaitTime;
    public float StartWaitTime;

    public Transform[] moveSpots;
    private int randomSpot;
    void Start()
    {
        WaitTime = StartWaitTime;
        randomSpot = Random.Range(0, moveSpots.Length);
    }

    void Update()
    {
        MassVector.Set(Mass, Mass, 1);
        transform.localScale = MassVector;
        transform.position = Vector2.MoveTowards(transform.position, moveSpots[randomSpot].position, Speed * Time.deltaTime);

        if (Vector2.Distance(transform.position, moveSpots[randomSpot].position) < 0.2f)
        {
            if (WaitTime <= 0)
            {
                randomSpot = Random.Range(0, moveSpots.Length);
                WaitTime = StartWaitTime;
            }
            else
                WaitTime -= Time.deltaTime;
        }
    }
}
