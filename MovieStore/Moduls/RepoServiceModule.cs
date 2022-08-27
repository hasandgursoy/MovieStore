using Autofac;
using MovieStore.Core.Repositories;
using MovieStore.Repository.Repositories;
using System.Reflection;
using Module = Autofac.Module;

namespace MovieStore.API.Moduls
{
    public class RepoServiceModule : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterGeneric(typeof(Repository<>)).As(typeof(IRepository<>)).InstancePerLifetimeScope();

        }
    }
}
