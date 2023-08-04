namespace Mediator._01;

public interface ICallCenter
{
    void Register(ICab cab);
    void BookCab(IPassenger passenger);
}
