using System.Collections.Generic;
using UnityEngine;
using RoR2;
using EntityStates;

namespace UnlimitedRain
{
    public class FireWork : BaseState
    {
        public void FireMissile(GameObject targeObject)
        {
            Ray aimRay = base.GetAimRay();
            if (this.modelTransform && this.modelTransform.GetComponent<ChildLocator>())
            {
                Transform transform = null;
                if (transform)
                {
                    aimRay.origin = transform.position;
                }
            }

        }






        // Token: 0x04000AFB RID: 2811
        public static GameObject effectPrefab;

        // Token: 0x04000AFC RID: 2812
        public static GameObject projectilePrefab;

        // Token: 0x04000AFD RID: 2813
        public static float damageCoefficient = 1f;

        // Token: 0x04000AFE RID: 2814
        public static float baseFireInterval = 0.1f;

        // Token: 0x04000AFF RID: 2815
        public static float minSpread = 0f;

        // Token: 0x04000B00 RID: 2816
        public static float maxSpread = 5f;

        // Token: 0x04000B01 RID: 2817
        public static float arcAngle = 5f;

        // Token: 0x04000B02 RID: 2818
        public List<GameObject> targetsList;

        // Token: 0x04000B03 RID: 2819
        private Transform modelTransform;

        // Token: 0x04000B04 RID: 2820
        private AimAnimator aimAnimator;

        // Token: 0x04000B05 RID: 2821
        private float fireTimer;

        // Token: 0x04000B06 RID: 2822
        private float fireInterval;

        // Token: 0x04000B07 RID: 2823
        private int currentTargetIndex;
    }
}
