using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice8
{
    public class Post
    {
        private int _like = 0;
        public string Title { get; set; }
        public string Description { get; set; }

        public int LikeCount { get { return _like; } }
        public DateTime CreatedOn { get; } = DateTime.Now;



        public void Like()
        {
            _like += 1;
        }
        public void DisLike()
        {
            if (_like > 0)
                _like -= 1;
            else Console.WriteLine("The Like numbers is 0 ");

        }
    }
}
