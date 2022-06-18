using EntityFramework.Entities;
using EntityFramework.Logic;
using EntityFramework.MVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace EntityFramework.MVC.Controllers
{
    public class CategoriesController : Controller

    {

        CategoriesLogic logic = new CategoriesLogic();
        // GET: Categories
        public ActionResult Index()
        {
            
            
            List<Entities.Categories> categories = logic.GetAll();

            List<CategoriesView> categoriesViews = categories.Select(x => new CategoriesView
            {

                Id = x.CategoryID,
                CategoryName = x.CategoryName,


            }).ToList();    




            return View(categoriesViews);



        }
        public ActionResult InsertUpdate()
        {


            return View();

        }

        [HttpPost]
        public ActionResult InsertUpdate(CategoriesView categoriesView)

        {
            if (categoriesView.Id == 0)
            {
                try
                {
                    Categories categoriesEntity = new Categories
                    {


                        CategoryName = categoriesView.CategoryName,





                    };

                    logic.Add(categoriesEntity);



                    return RedirectToAction("Index");

                }

               /*
                catch (Exception e)
                {


                    return RedirectToAction("Index", "Error");


                }
               */
                 catch (OverflowException ex)
                 {
                    return RedirectToAction("Index", "Error", new
                    {
                        exceptionMessage = ex.Message,
                        customMessage = "ERROR"
                    });


                }
                 
                 
                 catch (FormatException ex)
                 {
                    return RedirectToAction("Index", "Error", new
                    {
                        exceptionMessage = ex.Message,
                        customMessage = "ERROR"
                    });
                }
                
                catch (CharacterLimitExceededException ex)
                {
                    return RedirectToAction("Index", "Error", new
                    {
                        exceptionMessage = ex.Message,
                        customMessage = "ERROR"
                    });
                }
                catch(System.Data.Entity.Validation.DbEntityValidationException ex)
                
                
                {
                    return RedirectToAction("Index", "Error", new
                    {
                        exceptionMessage = ex.Message,
                        customMessage = "ERROR"
                    });


                }

                catch (InvalidOperationException ex)
                {
                    return RedirectToAction("Index", "Error", new
                    {
                        exceptionMessage = ex.Message,
                        customMessage = "ERROR"
                    });
                }
            }

            else

            {
                try
                {
                    Categories categoriesEntity = new Categories


                    {

                        CategoryName = categoriesView.CategoryName,

                        CategoryID = categoriesView.Id





                    };

                    logic.Update(categoriesEntity);


                    return RedirectToAction("Index");


                }
                catch (OverflowException ex)

                {
                    return RedirectToAction("Index", "Error", new
                    {
                        exceptionMessage = ex.Message,
                        customMessage = "ERROR"
                    });


                }


                catch (FormatException ex)
                {
                    return RedirectToAction("Index", "Error", new
                    {
                        exceptionMessage = ex.Message,
                        customMessage = "ERROR"
                    });
                }

                catch (CharacterLimitExceededException ex)
                {
                    return RedirectToAction("Index", "Error", new
                    {
                        exceptionMessage = ex.Message,
                        customMessage = "ERROR"
                    });
                }
                catch (System.Data.Entity.Validation.DbEntityValidationException ex)


                {
                    return RedirectToAction("Index", "Error", new
                    {
                        exceptionMessage = ex.Message,
                        customMessage = "ERROR"
                    });


                }

                catch (InvalidOperationException ex)
                {
                    return RedirectToAction("Index", "Error", new
                    {
                        exceptionMessage = ex.Message,
                        customMessage = "ERROR"
                    });
                }




            }



        }
        public ActionResult Delete(int id)
        {

            try
            {
                logic.Delete(id);

                return RedirectToAction("Index");
            }

            catch (System.Data.Entity.Infrastructure.DbUpdateException ex)
            {
                return RedirectToAction("Index", "Error", new
                {
                    exceptionMessage = ex.Message,
                    customMessage = "ERROR"
                });

            }


        }
    }
}