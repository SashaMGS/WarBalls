using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyZone : MonoBehaviour
{
    [SerializeField] private EnemyAI EnemyAIScript;

    private void Update()
    {
        transform.position = EnemyAIScript.gameObject.transform.position;
    }
    private void OnTriggerEnter2D(Collider2D col)
    {
        if (col.tag == "Eat")
        {
            EnemyAIScript.Target = col.transform;
        }
        if (col.tag == "Player")
        {
            if (EnemyAIScript.Player_LVL > col.gameObject.GetComponent<PlayerStats>().Player_LVL)
            {
                EnemyAIScript.Target = col.transform;
            }
            if (EnemyAIScript.Player_LVL < col.gameObject.GetComponent<PlayerStats>().Player_LVL)
            {

            }
        }
        if (col.tag == "Enemy")
        {
            if (EnemyAIScript.Player_LVL > col.gameObject.GetComponent<EnemyAI>().Player_LVL)
            {
                EnemyAIScript.Target = col.transform;
            }
        }
    }
    private void OnTriggerStay2D(Collider2D col)
    {
        if (col.tag == "Player")
        {
            if (EnemyAIScript.Player_LVL > col.gameObject.GetComponent<PlayerStats>().Player_LVL)
            {
                EnemyAIScript.Target = col.transform;
            }
            if (EnemyAIScript.Player_LVL < col.gameObject.GetComponent<PlayerStats>().Player_LVL)
            {

            }
        }
    }
}
