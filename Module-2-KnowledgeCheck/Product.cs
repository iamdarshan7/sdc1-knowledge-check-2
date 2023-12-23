using System;
namespace Module_2_KnowledgeCheck
{
	public class Product
	{
        public string Name { get; set; }
        public decimal Price { get; set; }
        public int Quantity { get; set; }
        public string Description { get; set; }

        public override string ToString()
        {
            return $"Name: {Name}, Price: {Price}, Quantity: {Quantity}, Description: {Description}";
        }
    }
}

