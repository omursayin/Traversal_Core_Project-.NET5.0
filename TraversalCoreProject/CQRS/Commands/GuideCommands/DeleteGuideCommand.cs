namespace TraversalCoreProject.CQRS.Commands.GuideCommands
{
    public class DeleteGuideCommand
    {
        public DeleteGuideCommand(int ıd)
        {
            Id = ıd;
        }

        public int Id { get; set; }
    }
}
