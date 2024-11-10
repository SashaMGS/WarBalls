using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyBox : MonoBehaviour
{
    [SerializeField] private Events EventsScript;
    [SerializeField] private EnemyAI EnemyAIScript;
    private void OnTriggerStay2D(Collider2D col)
    {
        if (col.tag == "Player")
        {
            if (EnemyAIScript.Player_LVL > col.gameObject.GetComponent<PlayerStats>().Player_LVL)
            {
                EventsScript.Dead();
            }
        }
        if (col.tag == "Enemy")
        {
            if (EnemyAIScript.Player_LVL > col.gameObject.GetComponent<EnemyAI>().Player_LVL)
            {
                if (col.gameObject.GetComponent<EnemyAI>().Player_LVL < 5 && col.gameObject.GetComponent<EnemyAI>().Player_LVL > 1)
                {
                    col.gameObject.GetComponent<EnemyAI>().Player_LVL -= 1;
                }
                if (EnemyAIScript.Player_LVL > 5)
                {
                    col.gameObject.GetComponent<EnemyAI>().Player_LVL -= 5;
                }
                EnemyAIScript.RandVector.Set(Random.Range(-60.0f, 60.0f), Random.Range(-60.0f, 60.0f));
                EnemyAIScript.transform.position = EnemyAIScript.RandVector;
            }
        }
    }
    private void OnTriggerEnter2D(Collider2D col)
    {
        if (col.tag == "Eat")
        {
            EnemyAIScript.mass_int_lvl += EnemyAIScript.massUp;
            EnemyAIScript.RandVector.Set(Random.Range(-99.5f, 99.5f), Random.Range(-99.5f, 99.5f));
            col.gameObject.transform.position = EnemyAIScript.RandVector;
        }
        if (col.tag == "Player")
        {
            if (EnemyAIScript.Player_LVL > col.gameObject.GetComponent<PlayerStats>().Player_LVL)
            {
                EventsScript.Dead();
            }
            if (EnemyAIScript.Player_LVL < col.gameObject.GetComponent<PlayerStats>().Player_LVL)
            {
                col.gameObject.GetComponent<PlayerStats>().mass_int_lvl += EnemyAIScript.mass_int_lvl;
                if (EnemyAIScript.Player_LVL < 5 && EnemyAIScript.Player_LVL > 1)
                {
                    EnemyAIScript.Player_LVL -= 1;
                }
                if (EnemyAIScript.Player_LVL > 5)
                {
                    EnemyAIScript.Player_LVL -= 5;
                }
                EnemyAIScript.RandomEnemy();
                EnemyAIScript.RandVector.Set(Random.Range(-60.0f, 60.0f), Random.Range(-60.0f, 60.0f));
                EnemyAIScript.transform.position = EnemyAIScript.RandVector;
            }
        }
        if (col.tag == "Enemy")
        {
            if (EnemyAIScript.Player_LVL > col.gameObject.GetComponent<EnemyAI>().Player_LVL)
            {
                if (col.gameObject.GetComponent<EnemyAI>().Player_LVL < 5 && col.gameObject.GetComponent<EnemyAI>().Player_LVL > 1)
                {
                    col.gameObject.GetComponent<EnemyAI>().Player_LVL -= 1;
                }
                if (EnemyAIScript.Player_LVL > 5)
                {
                    col.gameObject.GetComponent<EnemyAI>().Player_LVL -= 5;
                }
                EnemyAIScript.RandVector.Set(Random.Range(-60.0f, 60.0f), Random.Range(-60.0f, 60.0f));
                EnemyAIScript.transform.position = EnemyAIScript.RandVector;
            }
        }
    }
}
