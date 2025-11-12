using System.Text;

namespace HanoiLib
{
    public class Hanoi
    {
        private readonly int _amountOfDisk;
        private readonly Dictionary<string, Stack<int>> _poles;

        public Hanoi(int n)
        {
            if (n < 1) throw new ArgumentOutOfRangeException("n");

            _amountOfDisk = n;

            _poles = new()
            {
                { "A", new(Enumerable.Range(1, n).Reverse()) },
                { "B", new() },
                { "C", new() }
            };
        }

        public (bool IsSuccessful, bool IsFinished) Move(string from, string to)
        {
            if (from == to) return (false, IsFinished());

            if (_poles[from].Count == 0) return (false, IsFinished());

            int item = _poles[from].Peek();

            if (_poles[to].Count != 0 && item > _poles[to].Peek())
                return (false, IsFinished());

            _poles[from].Pop();
            _poles[to].Push(item);
            return (true, IsFinished());
        }

        public bool IsFinished() => _poles.Last().Value.Count == _amountOfDisk;

        public override string ToString()
        {
            var sb = new StringBuilder();

            foreach (var item in _poles)
            {
                sb.Append($"{item.Key}: {string.Join(", ", item.Value.Reverse())}\n");
            }

            if (IsFinished()) sb.Append("\nGame Over!!!\n\n");

            return sb.ToString();
        }
    }
}
