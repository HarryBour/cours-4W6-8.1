namespace labo8._1_serveur.Model
{
    public class Item
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Value { get; set; }

        public Item(int id, string name, int value)
        {
            Id = id;
            Name = name;
            Value = value;
        }

    }
}
