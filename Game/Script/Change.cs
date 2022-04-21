using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Change : MonoBehaviour
{
    // Start is called before the first frame update
  public void change()
    {
        SceneManager.LoadScene("tankgame");
    }
    public void Switch()
    {
        SceneManager.LoadScene("Scoreboard");
    }
}
