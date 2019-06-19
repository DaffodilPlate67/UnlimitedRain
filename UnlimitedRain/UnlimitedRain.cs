using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading.Tasks;
using Unity;
using UnityEngine;
using RoR2;
using R2API;
using On;
using IL;
using RoR2.UI.MainMenu;
using BepInEx.Logging;
using BepInEx;
using UnityEngine.Networking;
using RoR2.Projectile;

namespace UnlimitedRain 
{

    [BepInDependency("com.bepis.r2api")]

    [BepInPlugin("com.Vonce.unlimitedRain", "UnlimitedRain", "0.1")]



    public class UnlimitedRain : BaseUnityPlugin
    {
        
        public void Awake()
        {
            R2API.SurvivorAPI.SurvivorCatalogReady += (s, e) =>
            {
                var survivor = new SurvivorDef
                {
                    bodyPrefab = BodyCatalog.FindBodyPrefab("BanditBody"),
                    descriptionToken = "BANDIT_DESCRIPTION",
                    displayPrefab = Resources.Load<GameObject>("Prefaps/Characters/BanditDisplay"),
                    primaryColor = new Color(0.8039216f, 0.482352942f, 0.843137264f),
                    unlockableName = ""
                };

                R2API.SurvivorAPI.SurvivorDefinitions.Insert(3, survivor);
            };

            Logger.LogDebug("===========================UNLIMITED POWWWERRRRRRRRRRRRRRRRRRRRRRR============");

        }

        //The Update() method is run on every frame of the game.
        public void Update()
        {
            //This if statement checks if the player has currently pressed F2, and then proceeds into the statement:
          /*  if (Input.GetKeyDown(KeyCode.F2))
            {
                //We grab a list of all available Tier 3 drops:
                var dropList = Run.instance.availableTier3DropList;

                //Randomly get the next item:
                var nextItem = Run.instance.treasureRng.RangeInt(0, dropList.Count);

                //Get the player body to use a position:
                var transform = PlayerCharacterMasterController.instances[0].master.GetBodyObject().transform;

                //And then finally drop it infront of the player.
                PickupDropletController.CreatePickupDroplet(dropList[nextItem], transform.position, transform.forward * -20f);
            }
            */

            if (Input.GetMouseButton(0))
            {
              
            }
        }

        //Vars
        FireWork fireWork = new FireWork();

        //Tokens for items and prefab

        // Token: 0x0400137B RID: 4987
        public GameObject projectilePrefab;

        // Token: 0x0400137C RID: 4988
        public float launchInterval = 0.1f;

        // Token: 0x0400137D RID: 4989
        public float damageCoefficient = 3f;

        // Token: 0x0400137E RID: 4990
        public float coneAngle = 10f;

        // Token: 0x0400137F RID: 4991
        public float randomCircleRange;

        // Token: 0x04001380 RID: 4992
        [HideInInspector]
        public GameObject owner;

        // Token: 0x04001381 RID: 4993
        [HideInInspector]
        public TeamIndex team;

        // Token: 0x04001382 RID: 4994
        [HideInInspector]
        public int remaining;

        // Token: 0x04001383 RID: 4995
        [HideInInspector]
        public bool crit;

        // Token: 0x04001384 RID: 4996
        private float nextFireTimer;
    }
}
