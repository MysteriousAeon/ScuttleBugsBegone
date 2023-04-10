using MelonLoader;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace ScuttleBugsBegone
{
    public class BugsBegone : MelonMod
    {
        public override void OnInitializeMelon()
        {
            LoggerInstance.Msg("ScuttleBugsBegone loaded!");
            System.Action<Scene, LoadSceneMode> scneneLoaded = (s, s1) =>
            {
                if (s.name.Equals("GameCore"))
                {
                    var patchCoop = Resources.FindObjectsOfTypeAll<GameObject>().First(x => x.name.Equals("patchCoop"));
                    var Bugs = patchCoop.transform.GetChild(4).GetChild(10).transform;
                    Bugs.gameObject.SetActive(false);
                    Bugs.transform.localScale = UnityEngine.Vector3.zero;
                }
            };
            SceneManager.add_sceneLoaded(scneneLoaded);
        }
    }
}
