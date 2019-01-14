using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Task4.Models;

namespace Task4.Controllers
{ 
    public class PostsController : Controller
    {
        private Post getPost(int id)
        {

            var post = Post.GetListPosts().SingleOrDefault(item  => item.Id ==id );

            return post;
        }

        // GET: Posts
        public ActionResult Index()
        {
            return View(Post.GetListPosts());
        }

        // GET: Posts/Details/5
        public ActionResult Details(int id)
        {
            return View(getPost(id));
        }

        // GET: Posts/Create
        public ActionResult Create()
        { 

            
            return View(new Post());
        }

        // POST: Posts/Create
        [HttpPost]
        public ActionResult Create(Post post)
        {
            try
            {
                // TODO: Add insert logic here
                Post.AddNewPost(post);

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Posts/Edit/5
        public ActionResult Edit(int id)
        {
            return View(getPost(id));
        }

        // POST: Posts/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, Post post)
        {
            try
            {
                // TODO: Add update logic here
                Post.UpdatePost(post);

                return RedirectToAction("Index");
            }
            catch
            {
                return View(post);
            }
        }

        // GET: Posts/Delete/5
        public ActionResult Delete(int id)
        {
            
            return View(getPost(id));
        }

        // POST: Posts/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, Post post)
        {
            try
            {
                // TODO: Add delete logic here
                if (Post.DeletePost(id))
                {
                    return RedirectToAction("Index");
                }
                else
                {
                    return Content("Error , Can not deleted !!");

                }

            }
            catch
            {
                return View(post);
            }
        }
    }
}
