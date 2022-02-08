using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class GameController : MonoBehaviour
{
    public GameObject button;
    public GameObject respawn;
    public GameObject goal;

    void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.CompareTag("Hazard"))
        {
            transform.position = new Vector3(respawn.transform.position.x, respawn.transform.position.y, respawn.transform.position.z);
        }
        else if (other.gameObject.CompareTag("Goal"))
        {
            goal.SetActive(false);
            button.SetActive(true);
        }
    }

    public void StartOver()
    {
        SceneManager.LoadScene("Game");
    }
}
