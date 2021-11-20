using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using static blazorsvr.Data.AppDBContext;

namespace blazorsvr.Data
{
    public class StudentService
    {
        #region Property
        private readonly AppDBContext _appDBContext;
        #endregion

        #region Constructor
        public StudentService(AppDBContext appDBContext)
        {
            _appDBContext = appDBContext;
        }
        #endregion

        #region Get List of Employees
        public async Task<List<Student>> GetAllStudentsAsync()
        {
            return await _appDBContext.Students.ToListAsync();
        }
        #endregion

        #region Insert Employee
        public async Task<bool> InsertStudentAsync(Student student)
        {
            await _appDBContext.Students.AddAsync(student);
            await _appDBContext.SaveChangesAsync();
            return true;
        }
        #endregion

        #region Get Employee by Id
        public async Task<Student> GetStudentAsync(int Id)
        {
            Student employee = await _appDBContext.Students.FirstOrDefaultAsync(c => c.Id.Equals(Id));
            return employee;
        }
        #endregion

        #region Update Employee
        public async Task<bool> UpdateStudentAsync(Student student)
        {
            _appDBContext.Students.Update(student);
            await _appDBContext.SaveChangesAsync();
            return true;
        }
        #endregion

        #region DeleteEmployee
        public async Task<bool> DeleteStudentAsync(Student student)
        {
            _appDBContext.Remove(student);
            await _appDBContext.SaveChangesAsync();
            return true;
        }
        #endregion
    }
}
