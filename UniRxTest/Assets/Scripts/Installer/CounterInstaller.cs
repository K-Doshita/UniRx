using UnityEngine;
using Zenject;

public class CounterInstaller : MonoInstaller
{
    public override void InstallBindings()
    {
        Container.Bind<CounterPresenter>().AsSingle();
        Container.Bind<CounterModel>().AsSingle();
    }
}