using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using VContainer;
using VContainer.Unity;

public class GameLifeTimeScope : LifetimeScope
{
    protected override void Configure(IContainerBuilder builder)
    {
        builder.RegisterComponentInHierarchy<GameInjector>().AsSelf();

        builder.RegisterComponentInHierarchy<PoolFactory>().As<IPoolFactory>();
    }
}