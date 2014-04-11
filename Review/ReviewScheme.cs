using System.Collections.Generic;
using System.Linq;

namespace Review
{
    public class ReviewScheme
    {
        private readonly IDictionary<string, string> scheme = new Dictionary<string, string>();

        public IEnumerable<string> Revievers
        {
            get { return scheme.Values.Distinct(); }
        }

        public void Add(string author, string reviewer)
        {
            scheme.Add(author.ToLower(), reviewer.ToLower());
        }

        public IEnumerable<string> GetAuthors(string reviewer)
        {
            reviewer = reviewer.ToLower();
            return scheme.Where(t => t.Value == reviewer)
                .Select(t => t.Key);
        }
    }
}