using SQLite;
using SQLiteDemoWithBlazorApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//using static Android.Content.ClipData;

namespace SQLiteDemoWithBlazorApp.Services
{
    public class StudentService : IStudentService
    {
        private SQLiteAsyncConnection _dbConnection;

        public StudentService()
        {
            SetUpDb();
        }

        private async void SetUpDb()
        {
            if (_dbConnection == null)
            {
                string dbPath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "Student2.db3");
                _dbConnection = new SQLiteAsyncConnection(dbPath);
                await _dbConnection.CreateTableAsync<province>();
                await _dbConnection.CreateTableAsync<StudentModel>();


                await _dbConnection.CreateTableAsync<district>();
                await _dbConnection.CreateTableAsync<tambon>();
                await _dbConnection.CreateTableAsync<const_prenme>();
                await _dbConnection.CreateTableAsync<const_sex>();
                await _dbConnection.CreateTableAsync<const_currlev>();
                await _dbConnection.CreateTableAsync<const_disability_type>();
                await _dbConnection.CreateTableAsync<const_edulev>();
                await _dbConnection.CreateTableAsync<const_elderly_grp>();
                await _dbConnection.CreateTableAsync<const_house_conditions>();
                await _dbConnection.CreateTableAsync<const_occ>();
                await _dbConnection.CreateTableAsync<const_pertyp>();
                await _dbConnection.CreateTableAsync<const_reg>();
                await _dbConnection.CreateTableAsync<const_reltyp>();
                await _dbConnection.CreateTableAsync<const_school>();
                await _dbConnection.CreateTableAsync<const_stsmar>();
                await _dbConnection.CreateTableAsync<const_vaccination>();
               
            }
        }

        public async Task<int> AddStudent(StudentModel studentModel)
        {
            return await _dbConnection.InsertAsync(studentModel);
        }
        public async Task<int> AddProvince(province provinceModel)
        {
            return await _dbConnection.InsertOrReplaceAsync(provinceModel);
        }

        public async Task<int> DeleteStudent(StudentModel studentModel)
        {
            return await _dbConnection.DeleteAsync(studentModel);
        }
        public async Task<int> UpdateStudent(StudentModel studentModel)
        {
            return await _dbConnection.UpdateAsync(studentModel);
        }
        public async Task<List<StudentModel>> GetAllStudent()
        {
            return await _dbConnection.Table<StudentModel>().ToListAsync();
        }public async Task<List<province>> GetAll_province()
        {
            return await _dbConnection.Table<province>().ToListAsync();
        }

        public async Task<StudentModel> GetStudentByID(int StudentID)
        {
            var student = await _dbConnection.QueryAsync<StudentModel>($"Select * From {nameof(StudentModel)} where StudentID={StudentID} ");
            return student.FirstOrDefault();
        }
        public async Task<int> addAllProvince(List<province> all_province)
        {
            List<province> todoList = all_province;
            int deserilizeResponse = -1;
            foreach (var item in todoList)
            {
                deserilizeResponse = await this.AddProvince(item);
            }
            return deserilizeResponse;
            ;
        }


        public async Task<int> Add_district(district districtModel)
        {
            return await _dbConnection.InsertOrReplaceAsync(districtModel);
        }

        public async Task<int> Delete_district(district districtModel)
        {
            return await _dbConnection.DeleteAsync(districtModel);
        }
        public async Task<int> Update_district(district districtModel)
        {
            return await _dbConnection.UpdateAsync(districtModel);
        }
        public async Task<List<district>> GetAll_district()
        {
            return await _dbConnection.Table<district>().ToListAsync();
        }


        public async Task<int> addAll_district(List<district> all_district)
        {
            List<district> todoList = all_district;
            int deserilizeResponse = -1;
            foreach (var item in todoList)
            {
                deserilizeResponse = await this.Add_district(item);
            }
            return deserilizeResponse;
            ;
        }


        public async Task<int> Add_tambon(tambon tambonModel)
        {
            return await _dbConnection.InsertOrReplaceAsync(tambonModel);
        }

        public async Task<int> Delete_tambon(tambon tambonModel)
        {
            return await _dbConnection.DeleteAsync(tambonModel);
        }
        public async Task<int> Update_tambon(tambon tambonModel)
        {
            return await _dbConnection.UpdateAsync(tambonModel);
        }
        public async Task<List<tambon>> GetAll_tambon()
        {
            return await _dbConnection.Table<tambon>().ToListAsync();
        }


        public async Task<int> addAll_tambon(List<tambon> all_tambon)
        {
            List<tambon> todoList = all_tambon;
            int deserilizeResponse = -1;
            foreach (var item in todoList)
            {
                deserilizeResponse = await this.Add_tambon(item);
            }
            return deserilizeResponse;
            ;
        }


        public async Task<int> Add_const_prenme(const_prenme const_prenmeModel)
        {
            return await _dbConnection.InsertOrReplaceAsync(const_prenmeModel);
        }

        public async Task<int> Delete_const_prenme(const_prenme const_prenmeModel)
        {
            return await _dbConnection.DeleteAsync(const_prenmeModel);
        }
        public async Task<int> Update_const_prenme(const_prenme const_prenmeModel)
        {
            return await _dbConnection.UpdateAsync(const_prenmeModel);
        }
        public async Task<List<const_prenme>> GetAll_const_prenme()
        {
            return await _dbConnection.Table<const_prenme>().ToListAsync();
        }


        public async Task<int> addAll_const_prenme(List<const_prenme> all_const_prenme)
        {
            List<const_prenme> todoList = all_const_prenme;
            int deserilizeResponse = -1;
            foreach (var item in todoList)
            {
                deserilizeResponse = await this.Add_const_prenme(item);
            }
            return deserilizeResponse;
            ;
        }


        public async Task<int> Add_const_sex(const_sex const_sexModel)
        {
            return await _dbConnection.InsertOrReplaceAsync(const_sexModel);
        }

        public async Task<int> Delete_const_sex(const_sex const_sexModel)
        {
            return await _dbConnection.DeleteAsync(const_sexModel);
        }
        public async Task<int> Update_const_sex(const_sex const_sexModel)
        {
            return await _dbConnection.UpdateAsync(const_sexModel);
        }
        public async Task<List<const_sex>> GetAll_const_sex()
        {
            return await _dbConnection.Table<const_sex>().ToListAsync();
        }


        public async Task<int> addAll_const_sex(List<const_sex> all_const_sex)
        {
            List<const_sex> todoList = all_const_sex;
            int deserilizeResponse = -1;
            foreach (var item in todoList)
            {
                deserilizeResponse = await this.Add_const_sex(item);
            }
            return deserilizeResponse;
            ;
        }


        public async Task<int> Add_const_currlev(const_currlev const_currlevModel)
        {
            return await _dbConnection.InsertOrReplaceAsync(const_currlevModel);
        }

        public async Task<int> Delete_const_currlev(const_currlev const_currlevModel)
        {
            return await _dbConnection.DeleteAsync(const_currlevModel);
        }
        public async Task<int> Update_const_currlev(const_currlev const_currlevModel)
        {
            return await _dbConnection.UpdateAsync(const_currlevModel);
        }
        public async Task<List<const_currlev>> GetAll_const_currlev()
        {
            return await _dbConnection.Table<const_currlev>().ToListAsync();
        }


        public async Task<int> addAll_const_currlev(List<const_currlev> all_const_currlev)
        {
            List<const_currlev> todoList = all_const_currlev;
            int deserilizeResponse = -1;
            foreach (var item in todoList)
            {
                deserilizeResponse = await this.Add_const_currlev(item);
            }
            return deserilizeResponse;
            ;
        }


        public async Task<int> Add_const_disability_type(const_disability_type const_disability_typeModel)
        {
            return await _dbConnection.InsertOrReplaceAsync(const_disability_typeModel);
        }

        public async Task<int> Delete_const_disability_type(const_disability_type const_disability_typeModel)
        {
            return await _dbConnection.DeleteAsync(const_disability_typeModel);
        }
        public async Task<int> Update_const_disability_type(const_disability_type const_disability_typeModel)
        {
            return await _dbConnection.UpdateAsync(const_disability_typeModel);
        }
        public async Task<List<const_disability_type>> GetAll_const_disability_type()
        {
            return await _dbConnection.Table<const_disability_type>().ToListAsync();
        }


        public async Task<int> addAll_const_disability_type(List<const_disability_type> all_const_disability_type)
        {
            List<const_disability_type> todoList = all_const_disability_type;
            int deserilizeResponse = -1;
            foreach (var item in todoList)
            {
                deserilizeResponse = await this.Add_const_disability_type(item);
            }
            return deserilizeResponse;
            ;
        }


        public async Task<int> Add_const_edulev(const_edulev const_edulevModel)
        {
            return await _dbConnection.InsertOrReplaceAsync(const_edulevModel);
        }

        public async Task<int> Delete_const_edulev(const_edulev const_edulevModel)
        {
            return await _dbConnection.DeleteAsync(const_edulevModel);
        }
        public async Task<int> Update_const_edulev(const_edulev const_edulevModel)
        {
            return await _dbConnection.UpdateAsync(const_edulevModel);
        }
        public async Task<List<const_edulev>> GetAll_const_edulev()
        {
            return await _dbConnection.Table<const_edulev>().ToListAsync();
        }


        public async Task<int> addAll_const_edulev(List<const_edulev> all_const_edulev)
        {
            List<const_edulev> todoList = all_const_edulev;
            int deserilizeResponse = -1;
            foreach (var item in todoList)
            {
                deserilizeResponse = await this.Add_const_edulev(item);
            }
            return deserilizeResponse;
            ;
        }


        public async Task<int> Add_const_elderly_grp(const_elderly_grp const_elderly_grpModel)
        {
            return await _dbConnection.InsertOrReplaceAsync(const_elderly_grpModel);
        }

        public async Task<int> Delete_const_elderly_grp(const_elderly_grp const_elderly_grpModel)
        {
            return await _dbConnection.DeleteAsync(const_elderly_grpModel);
        }
        public async Task<int> Update_const_elderly_grp(const_elderly_grp const_elderly_grpModel)
        {
            return await _dbConnection.UpdateAsync(const_elderly_grpModel);
        }
        public async Task<List<const_elderly_grp>> GetAll_const_elderly_grp()
        {
            return await _dbConnection.Table<const_elderly_grp>().ToListAsync();
        }


        public async Task<int> addAll_const_elderly_grp(List<const_elderly_grp> all_const_elderly_grp)
        {
            List<const_elderly_grp> todoList = all_const_elderly_grp;
            int deserilizeResponse = -1;
            foreach (var item in todoList)
            {
                deserilizeResponse = await this.Add_const_elderly_grp(item);
            }
            return deserilizeResponse;
            ;
        }


        public async Task<int> Add_const_house_conditions(const_house_conditions const_house_conditionsModel)
        {
            return await _dbConnection.InsertOrReplaceAsync(const_house_conditionsModel);
        }

        public async Task<int> Delete_const_house_conditions(const_house_conditions const_house_conditionsModel)
        {
            return await _dbConnection.DeleteAsync(const_house_conditionsModel);
        }
        public async Task<int> Update_const_house_conditions(const_house_conditions const_house_conditionsModel)
        {
            return await _dbConnection.UpdateAsync(const_house_conditionsModel);
        }
        public async Task<List<const_house_conditions>> GetAll_const_house_conditions()
        {
            return await _dbConnection.Table<const_house_conditions>().ToListAsync();
        }


        public async Task<int> addAll_const_house_conditions(List<const_house_conditions> all_const_house_conditions)
        {
            List<const_house_conditions> todoList = all_const_house_conditions;
            int deserilizeResponse = -1;
            foreach (var item in todoList)
            {
                deserilizeResponse = await this.Add_const_house_conditions(item);
            }
            return deserilizeResponse;
            ;
        }


        public async Task<int> Add_const_occ(const_occ const_occModel)
        {
            return await _dbConnection.InsertOrReplaceAsync(const_occModel);
        }

        public async Task<int> Delete_const_occ(const_occ const_occModel)
        {
            return await _dbConnection.DeleteAsync(const_occModel);
        }
        public async Task<int> Update_const_occ(const_occ const_occModel)
        {
            return await _dbConnection.UpdateAsync(const_occModel);
        }
        public async Task<List<const_occ>> GetAll_const_occ()
        {
            return await _dbConnection.Table<const_occ>().ToListAsync();
        }


        public async Task<int> addAll_const_occ(List<const_occ> all_const_occ)
        {
            List<const_occ> todoList = all_const_occ;
            int deserilizeResponse = -1;
            foreach (var item in todoList)
            {
                deserilizeResponse = await this.Add_const_occ(item);
            }
            return deserilizeResponse;
            ;
        }


        public async Task<int> Add_const_pertyp(const_pertyp const_pertypModel)
        {
            return await _dbConnection.InsertOrReplaceAsync(const_pertypModel);
        }

        public async Task<int> Delete_const_pertyp(const_pertyp const_pertypModel)
        {
            return await _dbConnection.DeleteAsync(const_pertypModel);
        }
        public async Task<int> Update_const_pertyp(const_pertyp const_pertypModel)
        {
            return await _dbConnection.UpdateAsync(const_pertypModel);
        }
        public async Task<List<const_pertyp>> GetAll_const_pertyp()
        {
            return await _dbConnection.Table<const_pertyp>().ToListAsync();
        }


        public async Task<int> addAll_const_pertyp(List<const_pertyp> all_const_pertyp)
        {
            List<const_pertyp> todoList = all_const_pertyp;
            int deserilizeResponse = -1;
            foreach (var item in todoList)
            {
                deserilizeResponse = await this.Add_const_pertyp(item);
            }
            return deserilizeResponse;
            ;
        }


        public async Task<int> Add_const_reg(const_reg const_regModel)
        {
            return await _dbConnection.InsertOrReplaceAsync(const_regModel);
        }

        public async Task<int> Delete_const_reg(const_reg const_regModel)
        {
            return await _dbConnection.DeleteAsync(const_regModel);
        }
        public async Task<int> Update_const_reg(const_reg const_regModel)
        {
            return await _dbConnection.UpdateAsync(const_regModel);
        }
        public async Task<List<const_reg>> GetAll_const_reg()
        {
            return await _dbConnection.Table<const_reg>().ToListAsync();
        }


        public async Task<int> addAll_const_reg(List<const_reg> all_const_reg)
        {
            List<const_reg> todoList = all_const_reg;
            int deserilizeResponse = -1;
            foreach (var item in todoList)
            {
                deserilizeResponse = await this.Add_const_reg(item);
            }
            return deserilizeResponse;
            ;
        }


        public async Task<int> Add_const_reltyp(const_reltyp const_reltypModel)
        {
            return await _dbConnection.InsertOrReplaceAsync(const_reltypModel);
        }

        public async Task<int> Delete_const_reltyp(const_reltyp const_reltypModel)
        {
            return await _dbConnection.DeleteAsync(const_reltypModel);
        }
        public async Task<int> Update_const_reltyp(const_reltyp const_reltypModel)
        {
            return await _dbConnection.UpdateAsync(const_reltypModel);
        }
        public async Task<List<const_reltyp>> GetAll_const_reltyp()
        {
            return await _dbConnection.Table<const_reltyp>().ToListAsync();
        }


        public async Task<int> addAll_const_reltyp(List<const_reltyp> all_const_reltyp)
        {
            List<const_reltyp> todoList = all_const_reltyp;
            int deserilizeResponse = -1;
            foreach (var item in todoList)
            {
                deserilizeResponse = await this.Add_const_reltyp(item);
            }
            return deserilizeResponse;
            ;
        }


        public async Task<int> Add_const_school(const_school const_schoolModel)
        {
            return await _dbConnection.InsertOrReplaceAsync(const_schoolModel);
        }

        public async Task<int> Delete_const_school(const_school const_schoolModel)
        {
            return await _dbConnection.DeleteAsync(const_schoolModel);
        }
        public async Task<int> Update_const_school(const_school const_schoolModel)
        {
            return await _dbConnection.UpdateAsync(const_schoolModel);
        }
        public async Task<List<const_school>> GetAll_const_school()
        {
            return await _dbConnection.Table<const_school>().ToListAsync();
        }


        public async Task<int> addAll_const_school(List<const_school> all_const_school)
        {
            List<const_school> todoList = all_const_school;
            int deserilizeResponse = -1;
            foreach (var item in todoList)
            {
                deserilizeResponse = await this.Add_const_school(item);
            }
            return deserilizeResponse;
            ;
        }


        public async Task<int> Add_const_stsmar(const_stsmar const_stsmarModel)
        {
            return await _dbConnection.InsertOrReplaceAsync(const_stsmarModel);
        }

        public async Task<int> Delete_const_stsmar(const_stsmar const_stsmarModel)
        {
            return await _dbConnection.DeleteAsync(const_stsmarModel);
        }
        public async Task<int> Update_const_stsmar(const_stsmar const_stsmarModel)
        {
            return await _dbConnection.UpdateAsync(const_stsmarModel);
        }
        public async Task<List<const_stsmar>> GetAll_const_stsmar()
        {
            return await _dbConnection.Table<const_stsmar>().ToListAsync();
        }


        public async Task<int> addAll_const_stsmar(List<const_stsmar> all_const_stsmar)
        {
            List<const_stsmar> todoList = all_const_stsmar;
            int deserilizeResponse = -1;
            foreach (var item in todoList)
            {
                deserilizeResponse = await this.Add_const_stsmar(item);
            }
            return deserilizeResponse;
            ;
        }


        public async Task<int> Add_const_vaccination(const_vaccination const_vaccinationModel)
        {
            return await _dbConnection.InsertOrReplaceAsync(const_vaccinationModel);
        }

        public async Task<int> Delete_const_vaccination(const_vaccination const_vaccinationModel)
        {
            return await _dbConnection.DeleteAsync(const_vaccinationModel);
        }
        public async Task<int> Update_const_vaccination(const_vaccination const_vaccinationModel)
        {
            return await _dbConnection.UpdateAsync(const_vaccinationModel);
        }
        public async Task<List<const_vaccination>> GetAll_const_vaccination()
        {
            return await _dbConnection.Table<const_vaccination>().ToListAsync();
        }


        public async Task<int> addAll_const_vaccination(List<const_vaccination> all_const_vaccination)
        {
            List<const_vaccination> todoList = all_const_vaccination;
            int deserilizeResponse = -1;
            foreach (var item in todoList)
            {
                deserilizeResponse = await this.Add_const_vaccination(item);
            }
            return deserilizeResponse;
            ;
        }


    }
}
