using UnityEngine;
using UnityEngine.SceneManagement;

public class GazeButton : MonoBehaviour
{
    public void OnPointerEnter()
    {
        SceneManager.LoadScene("Gaze2");
    }
}
