using System;
using System.Collections.Generic;
using System.Text;
using System.Collections.Generic;
using BusinessLogic.Repository;
using Model;

namespace BusinessLogic.Controller
{
    public class SectionController
    {
        private readonly SectionRepository _sectionRepo = new SectionRepository();

        public List<Section> GetAllSections() 
        { 
            return _sectionRepo.GetAllSections(); 
        }

        public string CreateSection(Section section)
        {
            if (string.IsNullOrWhiteSpace(section.SectionCode)) return "Section Code is required.";
            if (section.Capacity <= 0) return "Capacity must be greater than zero.";
            return _sectionRepo.CreateSection(section) ? "Success" : "Failed to create section.";
        }

        public string UpdateSection(Section section)
        {
            if (string.IsNullOrWhiteSpace(section.SectionName)) return "Section Name is required.";
            return _sectionRepo.UpdateSection(section) ? "Success" : "Failed to update section.";
        }

        public string DeactivateSection(string sectionCode)
        {
            return _sectionRepo.DeactivateSection(sectionCode) ? "Success" : "Failed to deactivate.";
        }
    }
}
