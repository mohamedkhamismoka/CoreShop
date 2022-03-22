using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using WebApplication12.BL.helper;
using WebApplication12.BL.Interfaces;
using WebApplication12.BL.VM;
using WebApplication12.DAL.Entity;

namespace WebApplication12.Controllers
{
    public class ProductController : Controller
    {// private to be hidden
        //readonly to assign in constructor to achieve DI
        private readonly IProduct product;
        private readonly IMapper map;

        //for dependency injection
        public ProductController(IProduct product, IMapper map)
        {
            this.product = product;
            this.map = map;
        }
        public IActionResult Index()
        {
            var data = product.GET();
            var res = map.Map<IEnumerable<ProductVM>>(data);
            return View(res);
        }


        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(ProductVM prd, string img)
        {
            try
            {

                if (ModelState.IsValid && DateValidator.validate(prd.production_date, prd.expire_date) == true)
                {
                    if (prd.barcodeImg != null)
                    {


                        var data = product.GET();
                        var x = false;

                        foreach (var item in data)
                        {
                            if (item.Name == prd.Name)
                            {
                                ViewBag.namewarn = "Already Existed Product";
                                x = true;
                            }


                        }
                        if (x == true)
                        {
                            return View(prd);
                        }
                        else
                        {
                            var imgname = ImageUPLOADER.uploader("BarCodes", prd.barcodeImg);
                            prd.barcode = imgname;
                            var res = map.Map<Product>(prd);
                            product.add(res);
                            return RedirectToAction("Index");
                        }
                    }
                    else
                    {
                        ViewBag.imgwarn = "Please specify image";
                        return View(prd);
                    }

                }
                ViewBag.date = "Production date must be less than expireation date";
                prd.barcode = prd.barcode;
                return View(prd);
            }
            catch (Exception ex)
            {
                return View(prd);
            }

        }

        public IActionResult update(int id)
        {
            var data = product.GEtById(id);
            var res = map.Map<ProductVM>(data);
            return View(res);
        }
        [HttpPost]
        public IActionResult update(ProductVM prd, string nname, string img)
        {
            try
            {
                if (ModelState.IsValid && DateValidator.validate(prd.production_date, prd.expire_date) == true)
                {
                    if (prd.barcodeImg != null)
                    {

                        var data = product.GET();
                        var x = false;
                        foreach (var item in data)
                        {
                            if (item.Name == prd.Name && item.Name != nname)
                            {
                                ViewBag.namewarn = "Already Existed Product";
                                x = true;
                            }


                        }
                        if (x == true)
                        {


                            return View(prd);
                        }
                        else
                        {
                            var imgname = ImageUPLOADER.uploader("BarCodes", prd.barcodeImg);
                            prd.barcode = imgname;
                            var res = map.Map<Product>(prd);
                            product.update(res, prd.Id);
                            return RedirectToAction("Index");
                        }

                    }
                    else
                    {
                        var data = product.GET();
                        var x = false;
                        foreach (var item in data)
                        {
                            if (item.Name == prd.Name && item.Name != nname)
                            {
                                ViewBag.namewarn = "Already Existed Product";
                                x = true;
                            }


                        }
                        if (x == true)
                        {

                            prd.barcode = img;
                            return View(prd);
                        }
                        else
                        {

                            prd.barcode = img;

                            var res = map.Map<Product>(prd);
                            product.update(res, prd.Id);
                            return RedirectToAction("Index");
                        }

                    }


                }
                ViewBag.date = "Production date must be less than expireation date";
                prd.barcode = img;
                return View(prd);

            }
            catch (Exception ex)
            {

                prd.barcode = img;
                return View(prd);
            }


        }


        public IActionResult Delete(int id, string img)
        {
            var data = product.GEtById(id);
            var res = map.Map<ProductVM>(data);
            res.barcode = img;
            return View(res);
        }
        [HttpPost]
        [ActionName("Delete")]
        public IActionResult ConDelete(int Id)
        {
            var data = product.GEtById(Id);
            if (data.quantity.Equals(0))
            {
                product.delete(Id);
                return RedirectToAction("Index");
            }
            else
            {
                var data2 = product.GEtById(Id);
                var res = map.Map<ProductVM>(data2);
                ViewBag.warn = "Quantity must = zero to delete";


                return View(res);
            }
        }
        public IActionResult Details(int Id)
        {
            var data2 = product.GEtById(Id);
            var res = map.Map<ProductVM>(data2);
            return View(res);

        }
    }
}
