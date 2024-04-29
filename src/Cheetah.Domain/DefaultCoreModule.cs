using Autofac;
using Module = Autofac.Module;

/// <summary>
/// An Autofac module that is responsible for wiring up services defined in the Core project.
/// </summary>
public class DefaultCoreModule : Module
{
    protected override void Load(ContainerBuilder builder)
    {
        //builder.RegisterType<DeleteTagService>()
        //    .As<IDeleteTagService>().InstancePerLifetimeScope();
    }
}
