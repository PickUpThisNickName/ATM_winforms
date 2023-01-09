using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATM_winforms
{
    public class ATM
    {
        private Dictionary<int, int> banknotes;
        private readonly int limit;
        private int userbalance;
        private readonly List<string> banknotes_type = new List<string>();
        public ATM(Dictionary<int, int> _banknotes, int _limit, int _userbalance)
        {
            banknotes = _banknotes;
            limit = _limit;
            userbalance = _userbalance;
            foreach (var item in banknotes)
                banknotes_type.Add(item.Key.ToString());
        }
        public bool AddCash(List<List<string>> items)
        {
            int cashCount = 0;
            foreach (var item in items)
                cashCount += int.Parse(item[1]);

            if ((Limit() - cashCount) >= 0)
            {
                foreach (var item in items)
                {
                    int key = int.Parse(item[0]);
                    int count = int.Parse(item[1]);

                    if (banknotes.ContainsKey(key))
                        banknotes[key] += count;
                    else
                        banknotes.Add(key, count);
                }
                return true;
            }
            else
                return false;
        }
        public int Limit()
        {
            int banknotesCount = 0;
            foreach (var item in banknotes)
                banknotesCount += item.Value;

            return limit - banknotesCount;
        }
        public int CardBalance(List<List<string>> arr)
        {
            int Summary = 0;

            foreach (var item in arr)
            {
                int key = int.Parse(item[0]);
                int count = int.Parse(item[1]);
                Summary += (key * count);
            }
            return Summary;
        }
        public int GetBalance()
        {
            return userbalance;
        }
        public List<string> GetBancnotesType()
        {
            return banknotes_type;
        }
        public void IncrementBalance(int sum)
        {
            userbalance += sum;
        }

        public bool GetCash(ref Dictionary<int, int> toIssue, int amount, bool orderAscending)
        {
            var left = amount;
            var data = orderAscending
                ? banknotes.Keys.OrderBy(x => x)
                : banknotes.Keys.OrderByDescending(x => x);

            foreach (var nominal in data)
            {
                var count = Math.Min(left / nominal, banknotes[nominal]);
                toIssue[nominal] = count;
                left -= count * nominal;
            }

            if (left > 0)
                return false;
            else
                return true;
        }
        public void DecrementATM(ref Dictionary<int, int> toIssue)
        {
            foreach (var nominal in toIssue.Keys)
            {
                if (toIssue[nominal] != 0)
                {
                    banknotes[nominal] -= toIssue[nominal];
                    userbalance -= nominal * toIssue[nominal];
                }
            }

        }
    }
}
