using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Database
{
    public class TestTable : NotifyingEntity
    {
        private int id;
        public int Id
        {
            get => id;
            set => SetWithNotify(value, out id);
        }
        private bool flag;
        public bool Flag
        {
            get => flag;
            set => SetWithNotify(value, out flag);
        }
        private string text;
        public string Text
        {
            get => text;
            set => SetWithNotify(value, out text);
        }
    }
}
