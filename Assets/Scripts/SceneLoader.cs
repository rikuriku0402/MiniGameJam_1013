using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneLoader : SingletonMonoBehaviour<SceneLoader>
{
    public void SceneChange(string scene) => SceneManager.LoadSceneAsync(scene);


    public void RetryScene() => SceneManager.LoadScene(SceneManager.GetActiveScene().name);
}
