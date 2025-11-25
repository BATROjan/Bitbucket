namespace DragObjects
{
    public interface IdragObjectController
    {
        bool CheckAllCells();
        void Spawn();
        void ActivateDrag(int id);
        void Despawn();
        bool IsActive();
    }
}