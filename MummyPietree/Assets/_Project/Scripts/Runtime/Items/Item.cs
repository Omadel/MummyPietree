﻿using UnityEngine;

namespace MummyPietree
{
    public class Item : Interactable
    {
        public override bool IsInteractable => isInteractabe && renderer.enabled && !PlayerController.Instance.HasItem;
        public bool HasItem => itemData != null;
        public ItemData ItemSO => itemData;

        [SerializeField] bool isInteractabe = true;
        [SerializeField] private ItemData itemData;
        private new SpriteRenderer renderer;

        protected override void Start()
        {
            base.Start();
            renderer = GetComponent<SpriteRenderer>();
            renderer.enabled = false;
        }

        public void SetItem(ItemData item)
        {
            itemData = item;
            renderer.sprite = item.ItemSprite;
            renderer.enabled = true;
        }

        public ItemData RemoveItem()
        {
            ItemData item = itemData;
            itemData = null;
            renderer.enabled = false;
            return item;
        }

        protected override void OnInteractionEnded()
        {

            PlayerController.Instance.TransportItem(itemData);
            RemoveItem();
        }
    }
}
