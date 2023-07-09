using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TutorialManager : MonoBehaviour
{
    public GameObject[] popUps;
    public int popUpIndex;
    public float waitTime;
    public bool continuepressed;
    public PlayerController player;
    public SwitchGravity gravity;
    public SwitchGravityObjects objectGravity;

    public void Start()
    {
        player.speed = 0f;
        gravity.enabled = false;
        objectGravity.enabled = false;
    }

    public void Update()
    {

        for (int i = 0; i < popUps.Length; i++)
        {
            if (i == popUpIndex)
            {
                popUps[i].SetActive(true);
            }
            else
            {
                popUps[i].SetActive(false);
            }
        }

        if (popUpIndex == 0)
        {
            if (Time.time > waitTime)
            {
                popUpIndex++;
            }
        }
         else if (popUpIndex == 1)
        {
            if (Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.LeftArrow) || Input.GetKey(KeyCode.D) || Input.GetKey(KeyCode.RightArrow))
            {
                player.speed = 10f;
                popUpIndex++;
            }
        }
        else if (popUpIndex == 2)
        {
            gravity.enabled = true;
            objectGravity.enabled = true;
            if (Input.GetKeyDown(KeyCode.Space) || Input.GetKeyDown(KeyCode.UpArrow))
            {
                popUpIndex++;
            }
        }
        else if (popUpIndex == 3)
        {
            if (Input.GetKeyDown(KeyCode.Space))
            {
                popUpIndex++;
            }
        }
    }

    public void Contiue()
    {
        continuepressed = true;
    }
}
