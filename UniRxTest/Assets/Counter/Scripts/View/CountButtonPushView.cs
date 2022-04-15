using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

using Zenject;
using UniRx;

using Counter.View;
using Counter.Model;
using Counter.Presenter;

namespace Counter.View
{
    public class CountButtonPushView : MonoBehaviour
    {
        //[SerializeField]
        //private Button _countButton;

        //private CountNumberView _countNumberView;
        //private CountButtonPushView _countButtonPushView;
        //private CounterModel _counterModel;
        //public CounterPresenter _counterPresenter;

        private Subject<Unit> clickCountButtonSubject = new Subject<Unit>();

        //[Inject]
        //public void Construct(
        //    CountNumberView countNumberView,
        //    CountButtonPushView CountButtonPushView,
        //    CounterModel counterModel,
        //    CounterPresenter counterPresenter
        //    )
        //{
        //    _countNumberView = countNumberView;
        //    _countButtonPushView = CountButtonPushView;
        //    _counterModel = counterModel;
        //    _counterPresenter = counterPresenter;
        //}

        // Start is called before the first frame update
        void Awake()
        {
            //_countButton = gameObject.GetComponent<Button>();
        }

        private void Start()
        {
            //_countButton.OnClickAsObservable()
            //    .Subscribe(_ => OnClick())
            //    .AddTo(this);
            //_counterPresenter.OnClickCountButtonObservable()
            //    .Subscribe(_ =>
            //    {
            //        Debug.Log("GOAL");
            //    })
            //    .AddTo(this);
        }

        //public void OnClick()
        //{
        //    _counterPresenter.OnClickCountButton();
        //    Debug.Log("PUSH");
        //}

        public void OnClickCountButton()
        {
            clickCountButtonSubject.OnNext(Unit.Default);
        }

        public IObservable<Unit> OnClickCountButtonObservable()
        {
            return clickCountButtonSubject;
        }
    }
}
