using EntityFramework.Entities;
using EntityFramework.Logic;
using EntityFramework.WebApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using System.Web.Http.Cors;
using System.Web.Mvc;
using HttpDeleteAttribute = System.Web.Http.HttpDeleteAttribute;
using HttpGetAttribute = System.Web.Http.HttpGetAttribute;
using HttpPostAttribute = System.Web.Http.HttpPostAttribute;
using HttpPutAttribute = System.Web.Http.HttpPutAttribute;


namespace EntityFramework.WebApi.Controllers
{
   [EnableCors(origins: "*", headers: "*", methods: "*")]
    
    public class CategoriesApiController : ApiController
    {
        // GET: CategoriesControllerApi
        
        
            public CategoriesLogic logic = new CategoriesLogic();

            [HttpGet]
            public IHttpActionResult Get()
            {
                try
                {
                    List<CategoriesResponse> categoriesResponse;

                    var categories = logic.GetAll();

                    categoriesResponse = categories.Select(s => new CategoriesResponse
                    {
                       

                        Id = s.CategoryID,

                        CategoryName = s.CategoryName,

                    }).ToList();

                    return Ok(categoriesResponse);
                }
                catch (Exception ex)
                {
                    return InternalServerError(ex);
                }
            }

            [HttpGet]
            public IHttpActionResult Get(int id)
            {
                try
                {
                    var categories = logic.GetAll();
                    Categories categoriesToMap = categories.Find(s => s.CategoryID == id);

                    if (categoriesToMap == null)
                    {
                        return NotFound();
                    }
                    else
                    {
                        CategoriesResponse categoriesResponse = new CategoriesResponse
                        {
                          Id = categoriesToMap.CategoryID,
                          CategoryName = categoriesToMap.CategoryName,
                            
                        };

                        return Ok(categoriesResponse);
                    }

                }
                catch (Exception ex)
                {
                    return InternalServerError(ex);
                }
            }

            [HttpPost]
            public IHttpActionResult Add([FromBody] CategoriesRequest categoriesRequest)
            {
                try
                {
                    if (ModelState.IsValid)
                    {
                        Categories categoriesToInsert = new Categories
                        {
                            CategoryID = categoriesRequest.Id,
                            CategoryName = categoriesRequest.CategoryName,
                            
                        };

                        logic.Add(categoriesToInsert);
                        return Ok(categoriesToInsert);
                    }
                    else
                    {
                        return BadRequest();
                    }
                }
                catch (Exception ex)
                {

                    return InternalServerError(ex);
                }
            }

            [HttpPut]
            public IHttpActionResult Update(int id, [FromBody] CategoriesRequest categoriesRequest)
            {
                try
                {
                    if (ModelState.IsValid)
                    {
                        bool categoriesExists = logic.GetAll().Exists(s => s.CategoryID == id);

                        if (categoriesExists)
                        {
                            Categories updatedCategories = new Categories
                            {
                                CategoryID = categoriesRequest.Id,
                                CategoryName = categoriesRequest.CategoryName,
                                
                            };

                            logic.Update(updatedCategories);

                            return Ok();
                        }
                        else
                        {
                            return NotFound();
                        }
                    }
                    else
                    {
                        return BadRequest();
                    }
                }
                catch (Exception ex)
                {
                    return InternalServerError(ex);
                }
            }

            [HttpDelete]
            public IHttpActionResult Delete(int id)
            {
                try
                {
                    var categoriesToDelete = logic.GetAll().Find(s => s.CategoryID == id);
                    if (categoriesToDelete != null)
                    {
                        logic.Delete(id);

                        return Ok(categoriesToDelete);
                    }
                    else
                    {
                        return NotFound();
                    }
                }
                catch (Exception ex)
                {

                    return InternalServerError(ex);
                }
            }
        }

    }
