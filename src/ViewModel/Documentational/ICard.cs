namespace Lolchicer.Umlsql.ViewModel.Documentational;

public interface ICard : Model.Documentational.ICard
{
    public new Core.IModel Model { get; }

    Model.Core.IModel
        Model.Documentational.ICard.Model => Model;
}
