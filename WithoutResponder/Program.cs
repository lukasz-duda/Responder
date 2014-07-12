namespace WithoutResponder
{
    class Program
    {
        static void Main(string[] args)
        {
            var useCase = new PlaceAnOrderUseCase();
            PlaceAnOrderResponse response = useCase.Execute();
            var presenter = new PlaceAnOrderPresenter();
            presenter.HandleResponse(response);// Not needed with responder.
        }
    }
}
