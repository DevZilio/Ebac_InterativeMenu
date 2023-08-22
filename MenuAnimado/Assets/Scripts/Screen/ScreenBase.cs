using System.Collections;
using System.Collections.Generic;
using DG.Tweening;
using NaughtyAttributes;
using UnityEngine;


namespace Screens
{
    public enum ScreenType
    {
        Panel,
        Info_Panel,
        Shop,
    }
    public class ScreenBase : MonoBehaviour
    {
        public ScreenType screenType;

        public List<Transform> listofobjects;

        public bool startHide = false;

        [Header("Animation")]
        public float delayBetweenObjects = .05f;
        public float animationDuration = .3f;

        private void Start()
        {
            if (startHide)
            {
                HideObjects();
            }
        }


        [Button]
        protected virtual void Show()
        {
            ShowObjects();
            Debug.Log("Show");
        }
        [Button]
        protected virtual void Hide()
        {
            HideObjects();
            Debug.Log("HIDE");
        }

        private void HideObjects()
        {
            listofobjects.ForEach(i => i.gameObject.SetActive(false));
        }


        private void ShowObjects()
        {
            for (int i = 0; i < listofobjects.Count; i++)
            {
                var obj = listofobjects[i];

                obj.gameObject.SetActive(true);
                obj.DOScale(0, animationDuration).From().SetDelay(i * delayBetweenObjects);
            }
        }
        private void ForceShowObjects()
        {
            listofobjects.ForEach(i => i.gameObject.SetActive(true));
        }

    }
}