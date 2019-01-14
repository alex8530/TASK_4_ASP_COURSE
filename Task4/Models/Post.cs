using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI.WebControls;

namespace Task4.Models
{




    public class Post
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public DateTime TimePosted { get; set; }
        public string Content { get; set; }
        public string  Owner { get; set; }
        public string  Type { get; set; }


        private  static List<Post> _Posts = new List<Post>
        {

            new Post
            {
                Id = 1,
                Owner = "Alex Abu Harb",
                TimePosted = DateTime.Now,
                Title = "I Love Food",
                Content = "Food is my passion. Lorem ipsum dolor sit amet, consectetur adipiscing elit, " +
                          "sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim " +
                          "ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip" +
                          " ex ea commodo consequat. Excepteur sint occaecat cupidatat non proident," +
                          " sunt in culpa qui officia deserunt mollit anim id est laborum consectetur " +
                          "adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna" +
                          " aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris" +
                          " nisi ut aliquip ex ea commodo consequat.",
                Type = "Food"

            },
            new Post
            {
                Id = 2,
                Owner = "Soma Somanooo",
                TimePosted = DateTime.Now,
                Title = "Blogging 2",
                Content = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor" +
                          " incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis " +
                          "nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat." +
                          " Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia " +
                          "deserunt mollit anim id est laborum consectetur adipiscing elit, sed do eiusmod " +
                          "tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, " +
                          "quis nostrud " +"exercitation ullamco laboris nisi ut aliquip ex ea commodo " +
                          "consequat.",
                Type = "Sport"
            },
            new Post
            {
                Id = 3,
                Owner = "Ahmad  ",
                TimePosted = DateTime.Now,
                Title = "Blogging 3",
                Content = " sed do eiusmod tempor" +
                          " incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis " +
                          "nostrud exercitation ullamc adipiscing elit, sed do eiusmod " +
                          "tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, " +
                          "quis nostrud " +"exercitation ullamco laboris nisi ut aliquip ex ea commodo " +
                          "consequat.",
                Type = "Playing"
            }

        };


        public static List<Post> GetListPosts()
        {
            return _Posts;
        }

        public static void AddNewPost(Post post)
        {
            _Posts.Add(post);
        }

        public  static void  UpdatePost(Post post)
        {

            for (int i = 0; i < _Posts.Count; i++)
            {
                if (post.Id == _Posts[i].Id)
                {
                    _Posts[i] = post;
                }
            }
        }

        public static Boolean DeletePost(int  id)
        {
            bool b = false;

            for (int i = 0; i < _Posts.Count; i++)
            {
                if (id == _Posts[i].Id)
                {
                    _Posts.RemoveAt(i);
                    b = true;
                }
            }

            return b;
        }

        
    }
}