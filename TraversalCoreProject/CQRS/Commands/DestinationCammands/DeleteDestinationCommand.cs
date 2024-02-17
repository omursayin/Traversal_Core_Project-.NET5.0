namespace TraversalCoreProject.CQRS.Commands.DestinationCammands
{
    public class DeleteDestinationCommand
    {
        public DeleteDestinationCommand(int id)
        {
            Id = id;
        }

        public int Id { get; set; }
    }
}
