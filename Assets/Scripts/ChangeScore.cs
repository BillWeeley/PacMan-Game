using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeScore : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        ScoringSystem.theScore += 50;
        Destroy(gameObject);

    }
}
