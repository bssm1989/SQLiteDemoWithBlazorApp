using SQLiteDemoWithBlazorApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SQLiteDemoWithBlazorApp.Services
{
    public interface IStudentService
    {
        Task<List<StudentModel>> GetAllStudent();
        Task<List<province>> GetAll_province();
        Task<StudentModel> GetStudentByID(int StudentID);
        Task<int> AddStudent(StudentModel studentModel);
        Task<int> UpdateStudent(StudentModel studentModel);
        Task<int> DeleteStudent(StudentModel studentModel);
        Task<int> addAllProvince(List<province> provinces);
        Task<List<district>> GetAll_district();

        Task<int> Add_district(district districtModel);
        Task<int> Update_district(district districtModel);
        Task<int> Delete_district(district districtModel);
        Task<int> addAll_district(List<district> districts);

        Task<List<tambon>> GetAll_tambon();

        Task<int> Add_tambon(tambon tambonModel);
        Task<int> Update_tambon(tambon tambonModel);
        Task<int> Delete_tambon(tambon tambonModel);
        Task<int> addAll_tambon(List<tambon> tambons);

        Task<List<const_prenme>> GetAll_const_prenme();

        Task<int> Add_const_prenme(const_prenme const_prenmeModel);
        Task<int> Update_const_prenme(const_prenme const_prenmeModel);
        Task<int> Delete_const_prenme(const_prenme const_prenmeModel);
        Task<int> addAll_const_prenme(List<const_prenme> const_prenmes);

        Task<List<const_sex>> GetAll_const_sex();

        Task<int> Add_const_sex(const_sex const_sexModel);
        Task<int> Update_const_sex(const_sex const_sexModel);
        Task<int> Delete_const_sex(const_sex const_sexModel);
        Task<int> addAll_const_sex(List<const_sex> const_sexs);

        Task<List<const_currlev>> GetAll_const_currlev();

        Task<int> Add_const_currlev(const_currlev const_currlevModel);
        Task<int> Update_const_currlev(const_currlev const_currlevModel);
        Task<int> Delete_const_currlev(const_currlev const_currlevModel);
        Task<int> addAll_const_currlev(List<const_currlev> const_currlevs);

        Task<List<const_disability_type>> GetAll_const_disability_type();

        Task<int> Add_const_disability_type(const_disability_type const_disability_typeModel);
        Task<int> Update_const_disability_type(const_disability_type const_disability_typeModel);
        Task<int> Delete_const_disability_type(const_disability_type const_disability_typeModel);
        Task<int> addAll_const_disability_type(List<const_disability_type> const_disability_types);

        Task<List<const_edulev>> GetAll_const_edulev();

        Task<int> Add_const_edulev(const_edulev const_edulevModel);
        Task<int> Update_const_edulev(const_edulev const_edulevModel);
        Task<int> Delete_const_edulev(const_edulev const_edulevModel);
        Task<int> addAll_const_edulev(List<const_edulev> const_edulevs);

        Task<List<const_elderly_grp>> GetAll_const_elderly_grp();

        Task<int> Add_const_elderly_grp(const_elderly_grp const_elderly_grpModel);
        Task<int> Update_const_elderly_grp(const_elderly_grp const_elderly_grpModel);
        Task<int> Delete_const_elderly_grp(const_elderly_grp const_elderly_grpModel);
        Task<int> addAll_const_elderly_grp(List<const_elderly_grp> const_elderly_grps);

        Task<List<const_house_conditions>> GetAll_const_house_conditions();

        Task<int> Add_const_house_conditions(const_house_conditions const_house_conditionsModel);
        Task<int> Update_const_house_conditions(const_house_conditions const_house_conditionsModel);
        Task<int> Delete_const_house_conditions(const_house_conditions const_house_conditionsModel);
        Task<int> addAll_const_house_conditions(List<const_house_conditions> const_house_conditionss);

        Task<List<const_occ>> GetAll_const_occ();

        Task<int> Add_const_occ(const_occ const_occModel);
        Task<int> Update_const_occ(const_occ const_occModel);
        Task<int> Delete_const_occ(const_occ const_occModel);
        Task<int> addAll_const_occ(List<const_occ> const_occs);

        Task<List<const_pertyp>> GetAll_const_pertyp();

        Task<int> Add_const_pertyp(const_pertyp const_pertypModel);
        Task<int> Update_const_pertyp(const_pertyp const_pertypModel);
        Task<int> Delete_const_pertyp(const_pertyp const_pertypModel);
        Task<int> addAll_const_pertyp(List<const_pertyp> const_pertyps);

        Task<List<const_reg>> GetAll_const_reg();

        Task<int> Add_const_reg(const_reg const_regModel);
        Task<int> Update_const_reg(const_reg const_regModel);
        Task<int> Delete_const_reg(const_reg const_regModel);
        Task<int> addAll_const_reg(List<const_reg> const_regs);

        Task<List<const_reltyp>> GetAll_const_reltyp();

        Task<int> Add_const_reltyp(const_reltyp const_reltypModel);
        Task<int> Update_const_reltyp(const_reltyp const_reltypModel);
        Task<int> Delete_const_reltyp(const_reltyp const_reltypModel);
        Task<int> addAll_const_reltyp(List<const_reltyp> const_reltyps);

        Task<List<const_school>> GetAll_const_school();

        Task<int> Add_const_school(const_school const_schoolModel);
        Task<int> Update_const_school(const_school const_schoolModel);
        Task<int> Delete_const_school(const_school const_schoolModel);
        Task<int> addAll_const_school(List<const_school> const_schools);

        Task<List<const_stsmar>> GetAll_const_stsmar();

        Task<int> Add_const_stsmar(const_stsmar const_stsmarModel);
        Task<int> Update_const_stsmar(const_stsmar const_stsmarModel);
        Task<int> Delete_const_stsmar(const_stsmar const_stsmarModel);
        Task<int> addAll_const_stsmar(List<const_stsmar> const_stsmars);

        Task<List<const_vaccination>> GetAll_const_vaccination();

        Task<int> Add_const_vaccination(const_vaccination const_vaccinationModel);
        Task<int> Update_const_vaccination(const_vaccination const_vaccinationModel);
        Task<int> Delete_const_vaccination(const_vaccination const_vaccinationModel);
        Task<int> addAll_const_vaccination(List<const_vaccination> const_vaccinations);

    }
}
