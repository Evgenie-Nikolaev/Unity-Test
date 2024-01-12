using UnityEngine;
using UnityEngine.SceneManagement;

public class GoPlanets : MonoBehaviour
{
    public int Planets;
    public bool WAS = false;
    public GameObject No;
    public void Go()
    {
        SceneManager.LoadScene(Planets);
    }
    public void Praverka()
    {
        if (WAS)
        {
            Go();
        }
        else
        {
            No.SetActive(true);
        }
    }
}
