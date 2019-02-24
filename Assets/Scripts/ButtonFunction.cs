using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonFunction : MonoBehaviour {

	public void RestartScene()
    {
        SceneManager.LoadScene(0);
    }
}
