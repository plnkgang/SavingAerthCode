using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelLoader : MonoBehaviour
{
    #region Singleton

    public static LevelLoader instance;

    private void Awake()
    {
        instance = this;
    }

    #endregion

    public Animator transition;

    public float transitionTime = 1f;

    public void LoadNextLevel(string SceneName)
    {
        StartCoroutine(LoadLevel(SceneName));
    }

    IEnumerator LoadLevel(string SceneName)
    {
        //Play animation
        transition.SetTrigger("Start");

        //Wait
        yield return new WaitForSeconds(transitionTime);

        //Load scene
        SceneManager.LoadScene(SceneName);
    }
}
