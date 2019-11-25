using SkillManagement.Model;
using System.Collections.Generic;
using System.Linq;

namespace SkillManagement.Repository
{
    public class Dfs
    {
        public SkillTree createNode()
        {
            SkillTree node = new SkillTree();
            node.skills = null;
            return node;
        }
        public List<SkillTree> GenerateTree(List<temp> table, Dictionary<int, SkillTree> map, int? parentId = null)
        {
            var result = table.Where(x => x.parentId.Equals(parentId)).Select(item => new SkillTree
            {
                id = item.id,
                parentId = item.parentId,
                skills = GenerateTree(table, map, item.id)
            }).ToList();
            foreach (var element in result)
            {
                if (element.skills.Count == 0)
                {
                    map.Add(element.id, null);
                }
            }
            return result;
        }
        public void drive()
        {
            var map = new Dictionary<int, SkillTree>();
            var table = new List<temp>();
            table.Add(new temp() { id = 1, parentId = null });
            table.Add(new temp() { id = 2, parentId = 1 });
            table.Add(new temp() { id = 3, parentId = 1 });
            table.Add(new temp() { id = 4, parentId = 2 });
            table.Add(new temp() { id = 5, parentId = 2 });
            table.Add(new temp() { id = 6, parentId = 4 });
            table.Add(new temp() { id = 7, parentId = 1 });
            table.Add(new temp() { id = 8, parentId = 3 });
            table.Add(new temp() { id = 9, parentId = 3 });
            table.Add(new temp() { id = 10, parentId = 4 });
            table.Add(new temp() { id = 11, parentId = 4 });
            table.Add(new temp() { id = 12, parentId = 8 });
            table.Add(new temp() { id = 13, parentId = 3 });
            table.Add(new temp() { id = 14, parentId = 3 });
            table.Add(new temp() { id = 15, parentId = 4 });
            List<SkillTree> tree = GenerateTree(table, map, null);
        }
    }
}
