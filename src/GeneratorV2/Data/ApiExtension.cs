using System.Collections.Generic;

namespace GeneratorV2.Data
{
    public class ApiExtension : Dictionary<(string api, string vendor), List<Extension>>
    {
        public void AddExtension(string api, Extension extension)
        {
            var key = (api, extension.Vendor);
            if (!TryGetValue(key, out var extensionList))
            {
                extensionList = new List<Extension>();
                Add(key, extensionList);
            }
            extensionList.Add(extension);
        }

        public Dictionary<(string api, string extensionName), Extension[]> ToDictionaryArray()
        {
            var array = new Dictionary<(string api, string extensionName), Extension[]>();

            foreach (var (k, v) in this)
            {
                array.Add(k, v.ToArray());
            }
            return array;
        }
    }
}
