using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lec12
{
    //1.define delegate 
    //2.object from delegate
    //3.fire delegate
    //publisher


    internal class Group
    {
        public string Name { get; set; }
        List<User> members;
        List<Post> posts;
        public event Action<string,Group> PostAdd;
        public Group() 
        {
            members = new List<User>();
            posts = new List<Post>();
        }
        public void AddMember(User u)
        {
            members.Add(u);
            //subscribtion
            PostAdd += u.GetNotified;
        }
        public void RemoveMember(User u)
        {
            members.Remove(u);
            //PostAdd += u.GetNotified;
        }
        public void AddPost(Post p)
        {
            posts.Add(p);
            PostAdd?.Invoke(p.Title,this);
        }
    }
}
