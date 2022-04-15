using UnityEngine;
using Zenject;

using Counter.View;
using Counter.Presenter;
using Counter.Model;

public class CounterInstaller : MonoInstaller
{
    public override void InstallBindings()
    {
        Container.Bind<CountButtonPushView>().FromNewComponentOnNewGameObject().AsSingle();
        Container.Bind<CountNumberView>().FromNewComponentOnNewGameObject().AsSingle();
        Container.Bind<CounterPresenter>().AsSingle();
        Container.Bind<CounterModel>().AsSingle();
    }
}