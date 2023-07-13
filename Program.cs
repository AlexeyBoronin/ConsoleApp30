using Mylib1;
class StateConsumer
{
    public void PrintState()
    {
        DefaultState defaultState = new DefaultState();

        InternalState internalState=new InternalState();

        PublicState publicState = new PublicState();

        publicState.PrintInternal();

        publicState.PrintProtectedIntenal();

        publicState.PrintPublic();
    }
}