namespace LinkedList.Model
{
    public class Item<T>
    {
        private T data = default;
        public T Data
        {
            get { return data; }
            set
            {
                if (value != null)
                    data = value;
                else throw new ArgumentNullException(nameof(value));
            }
        }
        public Item<T> Next { get; set; }
        public Item(T data)
        {
            Data = data;
        }
        public override string ToString()
        {
            return Data.ToString();
        }
    }
}
