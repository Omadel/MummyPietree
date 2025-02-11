﻿using UnityEngine;

namespace MummyPietree
{
    [CreateAssetMenu(menuName = "MummyPietree/Plant")]
    public class PlantData : ItemData
    {
        public float ItemGrowthDuration => itemGrowthDuration;
        public Mesh[] GrowingStateMeshes => growingStateMeshes;
        public Material[] GrowingStateMaterials => growingStateMaterials;

        [SerializeField] private float itemGrowthDuration;
        [SerializeField] private Mesh[] growingStateMeshes;
        [SerializeField] Material[] growingStateMaterials;
    }


}
