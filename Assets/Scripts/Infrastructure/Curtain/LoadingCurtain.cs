using System;
using DG.Tweening;
using Infrastructure.Curtain.Core;
using UnityEngine;

namespace Infrastructure.Curtain
{
    public class LoadingCurtain : MonoBehaviour, ILoadingCurtain
    {
        [Header("References")]
        [SerializeField] private RectTransform _rectTransform;

        [Header("Preferences")]
        [SerializeField] private float _duration;
        [SerializeField] private Ease _ease;

        private Tween _moveTween;

        public event Action OnHidden;

        #region MonoBehaviour

        private void Awake()
        {
            DontDestroyOnLoad(gameObject);
        }

        private void OnDestroy()
        {
            KillTween();
        }

        #endregion

        public void Show()
        {
            KillTween();

            _rectTransform.anchoredPosition = Vector2.zero;
            gameObject.SetActive(true);
        }

        public void Hide()
        {
            KillTween();

            _moveTween = _rectTransform
                .DOAnchorPosY(_rectTransform.rect.height, _duration)
                .OnComplete(() =>
                {
                    gameObject.SetActive(false);
                    OnHidden?.Invoke();
                })
                .SetEase(_ease)
                .Play();
        }

        private void KillTween()
        {
            _moveTween.Kill();
        }
    }
}