namespace Di;

public enum LifeTime
{
    Singleton,
    Scoped,
    Transient
}
public abstract class ServiceDescriptor
{
    public required Type ServiceType { get; init; }
    public LifeTime LifeTime { get; init; }
}

interface IContainerBuilder
{
    void Register(ServiceDescriptor descriptor);

    IContainer Build();
}

interface IContainer
{
    IScope CreateScope();
}

interface IScope
{
    object Resolve(Type service);
}