using System;
using System.Collections.Generic;
using System.Text;
using BusinessLogic.Repository;
using Model;

namespace BusinessLogic.Controller
{
    public class StudentSearchController
    {
        private readonly StudentSearchRepository _repo = new StudentSearchRepository();
        public StudentProfileDTO SearchStudent(string keyword)
        {
            if (string.IsNullOrWhiteSpace(keyword))
                return null;

            return _repo.SearchStudent(keyword.Trim());
        }
    }
}
