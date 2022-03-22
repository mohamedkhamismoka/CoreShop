using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using WebApplication12.BL.Interfaces;
using WebApplication12.BL.VM;
using WebApplication12.DAL.Entity;

namespace WebApplication12.Controllers
{
    public class BranchController : Controller
    {   // private to be hidden
        //readonly to assign in constructor to achieve DI
        private readonly IMapper map;
        private readonly IBranch br;
        public BranchController(IBranch br, IMapper map)
        {
            this.br = br;
            this.map = map;
        }
        //page contain all branches
        public IActionResult Index()
        {
            var data = br.getAll();
            var res = map.Map<IEnumerable<BranchVM>>(data);
            return View(res);
        }
        //****************************************************************************
        //show branch detail
        public IActionResult Details(int id)
        {
            var data = br.getBYID(id);
            var res = map.Map<BranchVM>(data);
            return View(res);
        }
        //****************************************************************************
        //to update branch
        public IActionResult update(int id)
        {
            var data = br.getBYID(id);
            var res = map.Map<BranchVM>(data);
            return View(res);


        }
        [HttpPost]
        public IActionResult update(BranchVM bran, string nname, string pphone)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    var data = br.getAll();
                    var x = false;
                    var y = false;
                    foreach (var item in data)
                    {
                        if (item.Name == bran.Name && nname != item.Name)
                        {
                            ViewBag.Namewarn = "Already Existed Name";
                            x = true;
                        }
                        if (item.Phone == bran.Phone && item.Phone != pphone)
                        {
                            ViewBag.phonewarn = "Already Existed phone";
                            y = true;
                        }

                    }
                    if (x == true || y == true)
                    {
                        return View(bran);
                    }
                    else
                    {
                        var res = map.Map<Branch>(bran);
                        br.update(bran.Branc_Id, res);
                        return RedirectToAction("Index");
                    }

                }

                return View(bran);
            }
            catch (Exception ex)
            {
                return View(bran);
            }


        }
        //****************************************************************************
        //to add branch
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(BranchVM bran)
        {

            try
            {
                if (ModelState.IsValid)
                {
                    var data = br.getAll();
                    var x = false;
                    var y = false;
                    foreach (var item in data)
                    {
                        if (item.Name == bran.Name)
                        {
                            ViewBag.Namewarn = "Already Existed Name";
                            x = true;
                        }
                        if (item.Phone == bran.Phone)
                        {
                            ViewBag.phonewarn = "Already Existed phone";
                            y = true;
                        }

                    }
                    if (x == true || y == true)
                    {
                        return View(bran);
                    }
                    else
                    {
                        var res = map.Map<Branch>(bran);
                        br.add(res);
                        return RedirectToAction("Index");
                    }


                }
                return View(bran);
            }
            catch (Exception ex)
            {
                return View(bran);
            }
        }
        //****************************************************************************
        //to delete branch
        public IActionResult Delete(int id)
        {
            var data = br.getBYID(id);
            var res = map.Map<BranchVM>(data);
            return View(res);

        }
        [HttpPost]
        [ActionName("Delete")]
        public IActionResult ConfirmDelete(int id)
        {

            br.remove(id);
            return RedirectToAction("Index");

        }
    }


}
