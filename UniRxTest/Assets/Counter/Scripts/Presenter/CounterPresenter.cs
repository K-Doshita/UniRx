using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using Zenject;
using UniRx;

using Counter.View;
using Counter.Model;

namespace Counter.Presenter
{
    public class CounterPresenter : MonoBehaviour
    {

        private CountNumberView _countNumberView;
        private CountButtonPushView _countButtonPushView;
        private CounterModel _counterModel;

        [Inject]
        public void Construct(
            CountNumberView countNumberView,
            CountButtonPushView CountButtonPushView,
            CounterModel counterModel)
        {
            _countNumberView = countNumberView;
            _countButtonPushView = CountButtonPushView;
            _counterModel = counterModel;
        }

        // Start is called before the first frame update
        void Start()
        {
            _countButtonPushView.OnClickCountButtonObservable()
                .Subscribe(_ =>
                {
                    Debug.Log("PUSH");
                    _counterModel.OnCountValue();
                })
                .AddTo(this);

            _counterModel.OnCountValueObservable()
                .Subscribe(count =>
                {
                    _countNumberView.SetNumber(count);
                })
                .AddTo(this);
        }

        // Update is called once per frame
        void Update()
        {

        }

        private Subject<Unit> clickCountButtonSubject = new Subject<Unit>();

        public void OnClickCountButton()
        {
            Debug.Log("BUTTON");
            clickCountButtonSubject.OnNext(Unit.Default);
        }

        public IObservable<Unit> OnClickCountButtonObservable()
        {
            return clickCountButtonSubject;
        }
    }
}
