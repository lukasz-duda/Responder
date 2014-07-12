namespace Responder
{
    class Program
    {
        static void Main(string[] args)
        {
            var useCase = new PlaceAnOrderUseCase();
            var responder = new PlaceAnOrderPresenter();
            useCase.Execute(responder);
        }
    }
}
