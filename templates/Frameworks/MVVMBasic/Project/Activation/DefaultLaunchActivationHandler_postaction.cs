class DefaultLaunchActivationHandler : ActivationHandler<LaunchActivatedEventArgs>
{
    //{[{
    private readonly Type _navElement;

    public DefaultLaunchActivationHandler(Type navElement)
    {
        _navElement = navElement;
    }

    //}]}
}