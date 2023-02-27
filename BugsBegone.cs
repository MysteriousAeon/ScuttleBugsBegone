using MelonLoader;
using UnityEngine;

namespace ScuttleBugsBegone
{
    public class BugsBegone : MelonMod
    {
        private GameObject bugsGameObject;
        private bool bugsGameObjectPresent = false;
        public override void OnInitializeMelon()
        {
            LoggerInstance.Msg("ScuttleBugsBegone loaded!");
        }
        public override void OnUpdate()
        {
            // Check if the "Bugs" gameobject is present
            if (bugsGameObject == null)
            {
                bugsGameObject = GameObject.Find("Bugs");
                if (bugsGameObject == null)
                {
                    bugsGameObjectPresent = false;
                    return;
                }
                else
                {
                    bugsGameObjectPresent = true;
                }
            }
            else
            {
                bugsGameObjectPresent = true;
            }

            // Clean the grass if the "Bugs" gameobject is present
            if (bugsGameObjectPresent)
            {
                Transform bug = GameObject.Find("Bugs").GetComponent<Transform>();
                bug.localScale = new Vector3(-1000, -1000, -1000);
                bug.forward = new Vector3(-1, -1, -1);
            }
        }
    }
}
