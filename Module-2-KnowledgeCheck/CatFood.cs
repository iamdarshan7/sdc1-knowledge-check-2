using System;
namespace Module_2_KnowledgeCheck
{
	public class CatFood : Product
	{
        public override string ToString()
        {
            // Implements the ToString method to include CatFood specific properties
            return base.ToString() + " [CatFood Specific]";
        }
    }
}

