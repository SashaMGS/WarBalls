using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Priwiew_Script : MonoBehaviour
{
    public float Time1;
    private void Update()
    {
        Time1 += 1 * Time.deltaTime;
        if(Time1 >= 10.5)
        SceneManager.LoadScene("Menu");
    }
}
