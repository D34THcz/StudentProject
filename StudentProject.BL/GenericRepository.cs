using System;
using System.Collections.ObjectModel;
using System.Linq;

namespace StudentProject.BL
{
    public class GenericRepository<T> where T : class, IRepositoryModel
    {
        public ItemListCollection ItemsList = new ();

        public T GetById(int id)
        {
            return (T)ItemsList.SingleOrDefault(item => item.Id == id)?.Clone();
        }
        public void Add(T item)
        {
            ItemsList.Add(item);
        }
        public void Remove(T item)
        {
            ItemsList.Remove(item.Id);
        }
        public void Update(T item)
        {
            ItemsList.Update(item);
        }
        public bool IsEmpty()
        {
            var isEmpty = true;
            if (ItemsList.Count > 0)
                isEmpty = false;
            return isEmpty;
            
        }
    }

    public class ItemListCollection : KeyedCollection<int, IRepositoryModel>
    {
        protected override int GetKeyForItem(IRepositoryModel item)
        {
            return item.Id;
        }

        public void Update(IRepositoryModel model)
        {
            var index = IndexOf(this.First(x => x.Id == model.Id));
            RemoveAt(index);
            InsertItem(index, model);
        }
    }

    public interface IRepositoryModel : ICloneable
    {
        public int Id { get; }
    }
}
