using System;
using System.Collections.Generic;
using System.Text;
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

        public List<string> GetDistinctSchoolYears()
        {
            return _sectionRepo.GetDistinctSchoolYears();
        }

        public string CreateSection(Section section)
        {
            if (string.IsNullOrWhiteSpace(section.SectionCode)) return "Section Code is required.";
            if (string.IsNullOrWhiteSpace(section.SectionName)) return "Section Name is required.";
            if (string.IsNullOrWhiteSpace(section.GradeLevel)) return "Please select a Grade Level.";
            if (string.IsNullOrWhiteSpace(section.SchoolYear)) return "School Year is required.";
            if (section.Capacity <= 0) return "Capacity must be greater than zero.";

            section.SectionCode = section.SectionCode.Trim();
            section.SectionName = section.SectionName.Trim();

            try
            {
                if (_sectionRepo.SectionCodeExists(section.SectionCode))
                    return $"Section Code '{section.SectionCode}' already exists. Please use a different code.";

                return _sectionRepo.CreateSection(section) ? "Success" : "Failed to create section.";
            }
            catch (Exception ex)
            {
                return "Database error while creating section: " + ex.Message;
            }
        }

        public string UpdateSection(Section section)
        {
            if (string.IsNullOrWhiteSpace(section.SectionCode)) return "Please select a section to update.";
            if (string.IsNullOrWhiteSpace(section.SectionName)) return "Section Name is required.";
            if (string.IsNullOrWhiteSpace(section.GradeLevel)) return "Please select a Grade Level.";
            if (string.IsNullOrWhiteSpace(section.SchoolYear)) return "School Year is required.";
            if (section.Capacity <= 0) return "Capacity must be greater than zero.";

            section.SectionName = section.SectionName.Trim();

            try
            {
                return _sectionRepo.UpdateSection(section) ? "Success" : "Failed to update section.";
            }
            catch (Exception ex)
            {
                return "Database error while updating section: " + ex.Message;
            }
        }

        public string DeactivateSection(string sectionCode)
        {
            if (string.IsNullOrWhiteSpace(sectionCode))
                return "Please select a section to deactivate.";

            try
            {
                if (_sectionRepo.DeactivateSection(sectionCode))
                {
                    return "Success";
                }
                else
                {
                    return "Failed to deactivate section. It may already be Inactive.";
                }
            }
            catch (Exception ex)
            {
                return "Database error while deactivating section: " + ex.Message;
            }
        }

        public string ActivateSection(string sectionCode)
        {
            if (string.IsNullOrWhiteSpace(sectionCode))
                return "Section Code is required.";

            try
            {
                if (_sectionRepo.ActivateSection(sectionCode))
                {
                    return "Success";
                }
                else
                {
                    return "Failed to activate section. It may already be Active.";
                }
            }
            catch (Exception ex)
            {
                return "Database error while activating section: " + ex.Message;
            }
        }
    }
}