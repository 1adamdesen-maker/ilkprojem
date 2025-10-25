using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace HamurKralligi
{
    public class BootLoader : MonoBehaviour
    {
        [SerializeField]
        private string menuSceneName = "AnaMenu";

        private void Awake()
        {
            Application.targetFrameRate = 60;
        }

        private IEnumerator Start()
        {
            yield return null;
            SceneManager.LoadSceneAsync(menuSceneName, LoadSceneMode.Single);
        }
    }
}
