using EntityFramework.Data;
using EntityFramework.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFramework.Logic
{
    public class CategoriesLogic : BaseLogic, ILogic<Categories>
    {
        

        public CategoriesLogic()
        {
            
        }

        public List<Categories> GetAll()
        {

            return _context.Categories.ToList();


        }

       

        public void Delete(int id)
        {
            var deleteCategories = _context.Categories.Find(id);

            _context.Categories.Remove(deleteCategories);

            _context.SaveChanges();

            


        }

        

        public void Add(Categories insertedObject)
        {
            try
            {

                Categories category = insertedObject;
                _context.Categories.Add(category);
                _context.SaveChanges();

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void DataCheck(Categories checkedObject)
        {
            Categories category = checkedObject;
            if ((category).CategoryName.Length > 15)
            {
                throw new CharacterLimitExceededException();
            }
            else if (string.IsNullOrEmpty((category).CategoryName))
            {
                throw new FormatException();
            }
        }

        public void Update(Categories updatedItem)
        {
            try
            {
                Categories updatedCategory = updatedItem;
                var itemToUpdate = _context.Categories.Single(x => x.CategoryID == (updatedCategory).CategoryID);
                itemToUpdate.CategoryID = (updatedCategory).CategoryID;
                itemToUpdate.CategoryName = (updatedCategory).CategoryName;
                itemToUpdate.Description = (updatedCategory).Description;
                _context.SaveChanges();
            }
            catch (OverflowException ex)
            {
                throw ex;
            }
            catch (InvalidOperationException ex)
            {
                throw ex;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
