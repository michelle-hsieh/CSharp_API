using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace Addition_API.Data
{
    public class DeptService
    {
        // Private members
        private ApplicationDBContext dbContext;

        // Constructor
        public DeptService(ApplicationDBContext dbContext)
        {
            this.dbContext = dbContext;
        }

        // Public methods
        // This method returns the list of dept
        public async Task<List<Dept>> GetDeptAsync()
        {
            return await dbContext.Dept.ToListAsync();
        }

        // This method add a new dept to the DbContext and saves it
        public async Task<Dept> AddDeptAsync(Dept dept)
        {
            try
            {
                dbContext.Dept.Add(dept);
                await dbContext.SaveChangesAsync();
            }
            catch (Exception)
            {
                throw;
            }
            return dept;
        }

        // This method update and existing dept and saves the changes
        public async Task<Dept> UpdateDeptAsync(Dept dept)
        {
            try
            {
                var deptExist = dbContext.Dept.FirstOrDefault(d => d.deptid == dept.deptid);
                if (deptExist != null)
                {
                    dbContext.Update(dept);
                    await dbContext.SaveChangesAsync();
                }
            }
            catch (Exception)
            {
                throw;
            }
            return dept;
        }

        // This method removes and existing dept from the DbContext and saves it
        public async Task DeleteDeptAsync(Dept dept)
        {
            try
            {
                dbContext.Dept.Remove(dept);
                await dbContext.SaveChangesAsync();
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
