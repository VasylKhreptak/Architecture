using System;
using Infrastructure.Services.Screen.Core;
using UniRx;
using UnityEngine;
using Zenject;

public class SafeAreaUpdater : MonoBehaviour
{
    [Header("References")]
    [SerializeField] private RectTransform _rectTransform;

    private IDisposable _subscription;

    private IScreenService _screeService;

    [Inject]
    private void Constructor(IScreenService screenService)
    {
        _screeService = screenService;
    }

    #region MonoBehaiour

    private void OnValidate()
    {
        _rectTransform ??= GetComponent<RectTransform>();
    }

    private void OnEnable()
    {
        StartObserving();
    }

    private void OnDisable()
    {
        StopObserving();
    }

    #endregion

    private void StartObserving()
    {
        StopObserving();
        _subscription = Observable
            .CombineLatest(_screeService.ScreenOrientation, _screeService.ScreenResolution, (orientation, resolution) => (orientation, resolution))
            .DoOnSubscribe(UpdateArea)
            .Subscribe(tuple => UpdateArea());
    }

    private void StopObserving()
    {
        _subscription?.Dispose();
    }

    private void UpdateArea()
    {
        Rect safeArea = Screen.safeArea;
        Vector2 anchorMin = safeArea.position;
        Vector2 anchorMax = safeArea.position + safeArea.size;

        anchorMin.x /= Screen.width;
        anchorMin.y /= Screen.height;
        anchorMax.x /= Screen.width;
        anchorMax.y /= Screen.height;

        _rectTransform.anchorMin = anchorMin;
        _rectTransform.anchorMax = anchorMax;
    }
}
