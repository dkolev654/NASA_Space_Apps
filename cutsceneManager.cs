using UnityEngine;
using UnityEngine.SceneManagement;
public class CutsceneManager : MonoBehaviour
{
    public string nextSceneName;

    void Start()
    {
        // Start the cutscene or animation
        PlayCutscene();
    }

    void PlayCutscene()
    {
        // Play the cutscene logic (Timeline/Animator)
        // Once the cutscene is complete, transition to the next scene
        StartCoroutine(EndCutscene());
    }

    IEnumerator EndCutscene()
    {
        // Wait for the duration of the cutscene
        yield return new WaitForSeconds(10f);  // Replace with the actual cutscene duration

        // Load the next scene when cutscene finishes
        SceneManager.LoadScene(nextSceneName);
    }
}
