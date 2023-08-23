using System.Collections;
using System.Collections.Generic;
using DG.Tweening;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;
                                         //Serve pra identificar o mouse em cima do objeto  IPointerClickHandler, IPointerDownHandler, IPointerUpHandler
public class ButtonScaler: MonoBehaviour, IPointerEnterHandler, IPointerExitHandler
{
    public float finalScale = 1.2f;
    public float scaleDuration = .1f;


    //Salvar scala original do objeto
    private Vector3 _defaultScale;


    private Tween _currentTween;

    public void Awake() {
        _defaultScale = transform.localScale;
    }


    //Serve pra identificar o mouse em cima do objeto
    public void OnPointerEnter(PointerEventData eventData)
    {
        Debug.Log("Enter");
        // transform.localScale = Vector3.one * 1.2f;
       _currentTween= transform.DOScale(finalScale, scaleDuration);
    }

    public void OnPointerExit(PointerEventData eventData)
    {
        Debug.Log("Exit");
        _currentTween.Kill();
        transform.localScale = _defaultScale;
    }
}
